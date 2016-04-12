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
    class InvoicesItemsManager
    {
        private static InvoicesItemsManager theInstance = new InvoicesItemsManager();

        private InvoicesItemsManager() { }

        public void viewAll(String invoiceNumber, DataGridView dataGridView)      //Displays all delivery receipts, the DR's related supplier PO and the delivered items
        {
            string query = "SELECT A.invoiceItemID AS 'Invoice Item ID'," +
                                  "A.customerOrderID AS 'Customer Order ID'," +    
                                  "A.invoiceNumber AS 'Invoice Number'," +                  
                                  "B.description AS 'Item Description'," +
                                  "A.deliveredQuantity AS 'Delivered Quantity'," +
                                  "A.itemPrice AS 'Item Price' " +
                           "FROM invoice_items A, items B " +
                           "WHERE A.invoiceNumber = '" + invoiceNumber + "' " +
                           "AND A.itemNumber = B.itemNumber ";

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

                dataGridView.Columns["Invoice Item ID"].Visible = false;
                dataGridView.Columns["Customer Order ID"].Visible = false;
            }
            catch
            {
                MessageBox.Show("Error: Unable to show table due to connection problems");
            }
            finally
            {
                connection.Close();
            }

        }

        public bool isItemExists(int itemNumber, string invoiceNumber)
        {
            string query = "SELECT  COUNT(itemNumber) FROM invoice_items A WHERE A.itemNumber = " + itemNumber + " AND A.invoiceNumber = '" + invoiceNumber + "'";
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

        public void addData(string invoiceNumber, int deliveryItemID, int customerOrderID, int itemNumber, double itemPrice, int deliveredQuantity)
        {
            string query = "INSERT INTO invoice_items (invoiceNumber, deliveryItemID, customerOrderID, itemNumber, itemPrice, deliveredQuantity, approvedQuantity, rejectedQuantity) values (@invoiceNumber, @deliveryItemID, @customerOrderID, @itemNumber, @itemPrice, @deliveredQuantity, @approvedQuantity, @rejectedQuantity)";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@invoiceNumber", invoiceNumber);
                command.Parameters.AddWithValue("@deliveryItemID", deliveryItemID);
                command.Parameters.AddWithValue("@customerOrderID", customerOrderID);
                command.Parameters.AddWithValue("@itemNumber", itemNumber);
                command.Parameters.AddWithValue("@itemPrice", itemPrice);
                command.Parameters.AddWithValue("@deliveredQuantity", deliveredQuantity);
                command.Parameters.AddWithValue("@approvedQuantity", 0);
                command.Parameters.AddWithValue("@rejectedQuantity", 0);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nUnable to add item", "ERROR");
            }
            finally
            {
                connection.Close();
            }
        }

        #region Customer Result Functions
        public int getApprovedQuantity(int invoiceItemID)
        {
            string query = "SELECT approvedQuantity FROM invoice_items WHERE invoiceItemID = " + invoiceItemID.ToString() + "";
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
                MessageBox.Show("Unable to get count data", "ERROR");
            }
            finally
            {
                connection.Close();
            }

            return value;

        }

        public int getRejectedQuantity(int invoiceItemID)
        {
            string query = "SELECT rejectedQuantity FROM invoice_items WHERE invoiceItemID = " + invoiceItemID.ToString() + "";
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
                MessageBox.Show("Unable to get count data", "ERROR");
            }
            finally
            {
                connection.Close();
            }

            return value;

        }

        public void updateData(int invoiceItemID, int approvedQuantity, int rejectedQuantity)
        {
            string query = "UPDATE invoice_items SET approvedQuantity = @approvedQuantity, rejectedQuantity = @rejectedQuantity WHERE invoiceItemID = " + invoiceItemID.ToString() + "";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@approvedQuantity", approvedQuantity);
                command.Parameters.AddWithValue("@rejectedQuantity", rejectedQuantity);
                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Inspection Resut updated!");
            }
            catch
            {
                MessageBox.Show("Unable to add inspection results", "ERROR");
            }
            finally
            {
                connection.Close();
            }
        }


        public int getTotalApprovedQuantity(int invoiceItemID)
        {
            string query = "SELECT SUM(approvedQuantity) FROM invoice_items A " +
                           "WHERE A.invoiceItemID = " + invoiceItemID.ToString() + "";
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
        #endregion

        public static InvoicesItemsManager instance
        {
            get { return theInstance; }
        }

    }
}
