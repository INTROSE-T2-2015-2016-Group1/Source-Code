using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace introse_project.Libs
{
    class SupplierOrderItemsManager
    {
        private static SupplierOrderItemsManager theInstance = new SupplierOrderItemsManager();

        private SupplierOrderItemsManager() {}

        public void viewAll(String supplierPONumber, DataGridView dataGridView)  //Displays all ordered items for all the customer PO's
        {

            string query = "SELECT	 A.supplierPONumber		    AS 'Supplier PO Number'," +
                                    "B.description        	    AS 'Item Description'," +
                                    "A.quantity			        AS 'Quantity'," +
                                    "A.currency              	AS 'Currency'," +
                                    "A.pricePerUnit             AS 'Price Per Unit'," +
                                    "A.totalPrice               AS 'Total Price'," +
                                    "A.isFinished               AS 'Order Status' " +
                            "FROM 	supplier_order_items A, items B " +
                            "WHERE  A.supplierPONumber = '" + supplierPONumber + "' AND A.itemNumber = B.itemNumber " +
                            "ORDER BY A.supplierOrderID ASC;";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                MySqlDataAdapter data = new MySqlDataAdapter();
                data.SelectCommand = command;

                connection.Open();

                DataTable table = new DataTable();
                data.Fill(table);

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = table;

                dataGridView.DataSource = bindingSource;
                data.Update(table);

                connection.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nError: Unable to show table due to connection problems", "SOIM");
            }
        }

        public void addData(string supplierPONumber, int itemNumber, int quantity, string currency, double pricePerUnit, double totalPrice)
        {
            string query = "INSERT INTO supplier_order_items (supplierPONumber, itemNumber, quantity, currency, pricePerUnit, totalPrice, isFinished) " +
                           "values (@supplierPONumber, @itemNumber, @quantity, @currency, @pricePerUnit, @totalPrice, false)";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@supplierPONumber", supplierPONumber);
                command.Parameters.AddWithValue("@itemNumber", itemNumber);
                command.Parameters.AddWithValue("@quantity", quantity);
                command.Parameters.AddWithValue("@currency", currency);
                command.Parameters.AddWithValue("@pricePerUnit", pricePerUnit);
                command.Parameters.AddWithValue("@totalPrice", totalPrice);

                command.ExecuteNonQuery();

                connection.Close();
            }
            catch
            {
                MessageBox.Show("Unable to add item to purchase order", "ERROR");
            }
            finally
            {
                connection.Close();
            }
        }

        public void updateFinished(int supplierOrderID)
        {
            string query = "UPDATE supplier_order_items SET isFinished = CASE " +
                           "WHEN quantity <= " + DeliveryItemsManager.instance.getTotalApprovedQuantity(supplierOrderID).ToString() + " " +
                                "THEN true " +
                           "ELSE false " +
                           "END "+
                           "WHERE supplierOrderID = " + supplierOrderID.ToString() + "";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch
            {
                MessageBox.Show("\nUnable to add inspection results", "ERROR");
            }
            finally
            {
                connection.Close();
            }
        }

        /*
        public bool getTotalApprovedQuantity(string supplierPONumber)
        {
            string query = "SELECT  SUM(approvedQuantity) FROM godo_inspection_results A, delivered_items B " +
                           "WHERE A.deliveryItemID = B.deliveryItemID AND B.supplierOrderID = " + supplierOrderID.ToString() + "";
            int value = 0;
            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                value = Convert.ToInt32(command.ExecuteScalar().ToString());

                connection.Close();

                return value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nUnable to get count data", "ERROR");
            }
            finally
            {
                connection.Close();
            }

            return value;

        }
        */

        public void getOrderItems(ComboBox itemComboBox, string supplierPONumber)
        {
            itemComboBox.Items.Clear();

            string query = "SELECT B.description FROM supplier_order_items A, items B " +
                           "WHERE A.supplierPONumber = '" + supplierPONumber + "' AND A.itemNumber = B.itemNumber AND A.isFinished = false";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;

            try
            {
                connection.Open();

                reader = command.ExecuteReader();

                while (reader.Read())
                    itemComboBox.Items.Add(reader.GetString("description"));


                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nUnable to read items database", "ERROR");
            }
            finally
            {
                connection.Close();
            }
        }

        public int itemOrderedID(int itemNumber, string supplierPONumber)     //gets the itemID given an itemNumber and a supplierPONumber
        {          
            string query = "SELECT A.supplierOrderID FROM supplier_order_items A " +
                           "WHERE A.supplierPONumber = '" + supplierPONumber + "' AND A.itemNumber = " + itemNumber.ToString() + " ";
            int id = 0;

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                id = Convert.ToInt32(command.ExecuteScalar().ToString());
                connection.Close();
                return id;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nUnable to read ordered items database", "ERROR");
            }
            finally
            {
                connection.Close();
            }
            return id;
        }

        public bool isItemExists(int itemNumber, string supplierPONumber)
        {
            string query = "SELECT  COUNT(itemNumber) FROM supplier_order_items A WHERE A.itemNumber = " + itemNumber + " AND A.supplierPONumber = '"+ supplierPONumber +"'";
            int count = 0;
            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                count = Convert.ToInt32(command.ExecuteScalar().ToString());

                connection.Close();

                if (count > 0)
                {
                    return true;
                }
            }
            catch
            {
                MessageBox.Show("Unable to retrieve data due to connection problems", "ERROR");
            }
            finally
            {
                connection.Close();
            }

            return false;

        }

        public void fillComboBox(ComboBox supplierComboBox)   
        {
            supplierComboBox.Items.Clear();

            string query = "SELECT supplierOrderID FROM supplier_order_items WHERE isFinished = false";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;

            try
            {
                connection.Open();

                reader = command.ExecuteReader();

                while (reader.Read())
                    supplierComboBox.Items.Add(reader.GetString("supplierPONumber"));


                connection.Close();
            }
            catch
            {
                MessageBox.Show("Unable to read supplier database", "ERROR");
            }
            finally
            {
                connection.Close();
            }
        }

        public int getCount()
        {
            string query = "SELECT  COUNT(*) FROM supplier_order_items";
            int value = 0;
            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                value = Convert.ToInt32(command.ExecuteScalar().ToString());

                connection.Close();

                return value;
            }
            catch
            {
                MessageBox.Show("Unable to retrieve count data");
            }
            finally
            {
                connection.Close();
            }

            return value;

        }

        public int getQuantityOrdered(int supplierOrderID)
        {
            string query = "SELECT quantity FROM supplier_order_items WHERE supplierOrderID = "+ supplierOrderID.ToString() +" ";
            int value = 0;
            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                value = Convert.ToInt32(command.ExecuteScalar().ToString());

                connection.Close();

                return value;
            }
            catch
            {
                MessageBox.Show("Unable to retrieve count data");
            }
            finally
            {
                connection.Close();
            }

            return value;
        }

        public bool isOrdersDone(string supplierPONumber)
        {
            string query = "SELECT isFinished FROM supplier_order_items WHERE supplierPONumber = '" + supplierPONumber + "'";
            bool isFinished = true;

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;

            try
            {
                connection.Open();

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (!reader.GetBoolean("isFinished"))
                    {
                        isFinished = false;
                    }
                }

                connection.Close();

                return isFinished;
            }
            catch
            {
                MessageBox.Show("Unable to read supplier order items database", "ERROR");
                isFinished = false;
            }
            finally
            {
                connection.Close();
            }

            return isFinished;
        }

        public static SupplierOrderItemsManager instance
        {
            get { return theInstance; }
        }
    }
}
