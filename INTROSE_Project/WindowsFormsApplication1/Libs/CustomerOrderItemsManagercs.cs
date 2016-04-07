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
    class CustomerOrderItemsManagercs
    {

        private static CustomerOrderItemsManagercs theInstance = new CustomerOrderItemsManagercs();

        private CustomerOrderItemsManagercs(){}

        public void viewAll(String customerPONumber, DataGridView dataGridView)  //Displays all ordered items for all the customer PO's
        {

            string query = "SELECT	 A.customerPONumber		    AS 'Customer PO Number'," +
                                    "A.itemDescription			AS 'Item'," +
                                    "A.quantity			        AS 'Quantity'," +
                                    "A.currency              	AS 'Currency'," +
                                    "A.pricePerUnit             AS 'Price Per Unit'," +
                                    "A.totalPrice               AS 'Total Price'," +
                                    "A.isFinished               AS 'Order Status' " +
                            "FROM 	customer_order_items A " +
                            "WHERE  A.customerPONumber = '" + customerPONumber + "' " +
                            "ORDER BY A.customerOrderID ASC;";

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
            catch
            {
                MessageBox.Show("Error: Unable to show table due to connection problems", "ERROR");
            }
        }

        public void addData(string customerPONumber, string itemDescription, int quantity, string currency, double pricePerUnit, double totalPrice)
        {
            string query = "INSERT INTO customer_order_items (customerPONumber, itemDescription, quantity, currency, pricePerUnit, totalPrice, isFinished) " +
                           "values (@customerPONumber, @itemDescription, @quantity, @currency, @pricePerUnit, @totalPrice, false)";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@customerPONumber", customerPONumber);
                command.Parameters.AddWithValue("@itemDescription", itemDescription);
                command.Parameters.AddWithValue("@quantity", quantity);
                command.Parameters.AddWithValue("@currency", currency);
                command.Parameters.AddWithValue("@pricePerUnit", pricePerUnit);
                command.Parameters.AddWithValue("@totalPrice", totalPrice);

                command.ExecuteNonQuery();

                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nUnable to add item to purchase order", "ERROR");
            }
            finally
            {
                connection.Close();
            }
        }

        public void getPossibleSuppliers(ComboBox itemComboBox, string customerPONumber)     //fills up the combo box with values within the database
        {
            itemComboBox.Items.Clear();

            string query = "SELECT DISTINCT(B.supplierName) FROM customer_order_items A, items B " +
                           "WHERE A.itemDescription = B.description AND A.customerPONumber = '"+ customerPONumber +"' AND A.isFinished = false";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;

            try
            {
                connection.Open();

                reader = command.ExecuteReader();

                while (reader.Read())
                    itemComboBox.Items.Add(reader.GetString("supplierName"));


                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nUnable to read suppliers database", "ERROR");
            }
            finally
            {
                connection.Close();
            }
        }

        public int getOrderID(string customerPONumber, string itemDescription)
        {
            string query = "SELECT  customerOrderID FROM customer_order_items WHERE customerPONumber = '" + customerPONumber + "' AND itemDescription = '" + itemDescription + "' ";
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
                MessageBox.Show("Unable to retrieve ID data");
            }
            finally
            {
                connection.Close();
            }

            return value;

        }

        public double getItemPricePerUnit(int customerOrderID)
        {
            string query = "SELECT pricePerUnit FROM customer_order_items WHERE customerOrderID = " + customerOrderID + "";
            double value = 0;
            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                value = double.Parse(command.ExecuteScalar().ToString());

                connection.Close();

                return value;
            }
            catch
            {
                MessageBox.Show("Unable to retrieve ID data");
            }
            finally
            {
                connection.Close();
            }

            return value;

        }

        public void updateFinished(int customerOrderID)
        {
            string query = "UPDATE customer_order_items SET isFinished = CASE " +
                           "WHEN quantity = " + InvoicesItemsManager.instance.getTotalApprovedQuantity(customerOrderID).ToString() + " " +
                                "THEN true " +
                           "ELSE false " +
                           "END " +
                           "WHERE customerOrderID = " + customerOrderID.ToString() + "";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nUnable to add inspection results", "ERROR");
            }
            finally
            {
                connection.Close();
            }
        }

        public int getCount()
        {
            string query = "SELECT  COUNT(*) FROM customer_order_items";
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

        public int getOrderCount(string customerPONumber)
        {
            string query = "SELECT  COUNT(*) FROM customer_order_items A WHERE A.customerPONumber = '"+ customerPONumber +"'";
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

        public void getOrderItems(ComboBox itemComboBox, string customerPONumber, string supplierName)     //fills up the combo box with values within the database
        {
            itemComboBox.Items.Clear();

            string query = "SELECT A.itemDescription FROM customer_order_items A, items B " +
                           "WHERE A.customerPONumber = '"+ customerPONumber +"' AND B.supplierName = '"+ supplierName +"' AND A.itemDescription = B.description";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;

            try
            {
                connection.Open();

                reader = command.ExecuteReader();

                while (reader.Read())
                    itemComboBox.Items.Add(reader.GetString("itemDescription"));


                connection.Close();
            }
            catch
            {
                MessageBox.Show("Unable to read items database", "ERROR");
            }
            finally
            {
                connection.Close();
            }
        }

        public bool isItemExists(string itemDescription, string customerPONumber)
        {
            string query = "SELECT  COUNT(itemDescription) FROM customer_order_items A WHERE A.itemDescription = '"+ itemDescription +"' AND A.customerPONumber = '" + customerPONumber + "'";
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

        public static CustomerOrderItemsManagercs instance
        {
            get { return theInstance; }
        }

    }
}
