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
                MessageBox.Show(ex.Message + "\nError: Unable to show table due to connection problems", "ERROR");
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

        public static SupplierOrderItemsManager instance
        {
            get { return theInstance; }
        }
    }
}
