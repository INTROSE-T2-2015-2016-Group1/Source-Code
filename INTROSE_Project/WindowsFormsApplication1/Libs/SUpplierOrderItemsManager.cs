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

        public void getOrderItems(ComboBox itemComboBox, string supplierPONumber)     //fills up the combo box with values within the database
        {
            itemComboBox.Items.Clear();

            string query = "SELECT B.description FROM supplier_order_items A, items B " +
                           "WHERE A.supplierPONumber = '" + supplierPONumber + "' AND A.itemNumber = B.itemNumber";

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

        public bool isItemExists(int itemNumber)
        {
            string query = "SELECT  COUNT(itemNumber) FROM supplier_order_items A WHERE A.itemNumber = " + itemNumber + "";
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

        public static SupplierOrderItemsManager instance
        {
            get { return theInstance; }
        }
    }
}
