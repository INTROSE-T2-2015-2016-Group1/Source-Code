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
                                    "A.itemNumber			    AS 'Item Number'," +
                                    "B.description			    AS 'Description'," +
                                    "A.quantity			        AS 'Quantity'," +
                                    "A.currency              	AS 'Currency'," +
                                    "A.pricePerUnit             AS 'Price Per Unit'," +
                                    "A.totalPrice               AS 'Total Price'," +
                                    "A.isFinished               AS 'Order Status' " +
                            "FROM 	customer_order_items A " +
                                "LEFT JOIN items B " +
                                    "ON B.itemNumber = A.itemNumber " +
                            "WHERE  A.customerPONumber = '" + customerPONumber + "' " +
                            "ORDER BY A.customerOrderID ASC;";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["roiConn"].ConnectionString);
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
                MessageBox.Show("Error: Unable to show table due to connection problems");
            }
        }

        public void addData(string customerPONumber, int itemNumber, int quantity, string currency, double pricePerUnit, double totalPrice)
        {
            string query = "INSERT INTO customer_order_items (customerPONumber, itemNumber, quantity, currency, pricePerUnit, totalPrice, isFinished) " +
                           "values (@customerPONumber, @itemNumber, @quantity, @currency, @pricePerUnit, @totalPrice, false)";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["jutsconn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@customerPONumber", customerPONumber);
                command.Parameters.AddWithValue("@itemNumber", itemNumber);
                command.Parameters.AddWithValue("@quantity", quantity);
                command.Parameters.AddWithValue("@currency", currency);
                command.Parameters.AddWithValue("@pricePerUnit", pricePerUnit);
                command.Parameters.AddWithValue("@totalPrice", totalPrice);

                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Item Added");
            }
            catch
            {
                MessageBox.Show("Unable to add item to purchase order");
            }
            finally
            {
                connection.Close();
            }
        }

        public static CustomerOrderItemsManagercs instance
        {
            get { return theInstance; }
        }

    }
}
