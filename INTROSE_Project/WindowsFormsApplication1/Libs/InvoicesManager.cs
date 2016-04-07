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
    class InvoicesManager
    {
        private static InvoicesManager theInstance = new InvoicesManager();

        private InvoicesManager(){}

        public void viewAll(DataGridView dataGridView)      //Displays all invoices, the delivered items within the invoice and the customer's QA inspection results
        {
            string query = "SELECT	A.invoiceNumber						        AS 'Invoice Number'," +
                                   "A.deliveryReceiptNumber 			        AS 'Related Delivery Receipt Number'," +
                                   "C.customerPONumber					        AS 'Related Customer PO Number'," +
                                   "A.invoiceTotalPrice					        AS 'Total Invoice Price'," +
                                   "A.dateReceived						        AS 'Date Received' " +
                                   "FROM invoices A, delivery_receipts B, supplier_po C " +
                                   "WHERE A.deliveryReceiptNumber = B.deliveryReceiptNumber AND B.supplierPONumber = C.supplierPONumber " +
                                   "ORDER BY A.invoiceNumber DESC";

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
                MessageBox.Show("Error: Unable to show table due to connection problems");
            }
            finally
            {
                connection.Close();
            }

        }

        public void addData(string invoiceNumber, string deliveryReceiptNumber, string dateReceived, double invoiceTotalPrice)
        {
            string query = "INSERT INTO invoices (invoiceNumber, deliveryReceiptNumber, dateReceived, invoiceTotalPrice) values (@invoiceNumber, @deliveryReceiptNumber, @dateReceived, @invoiceTotalPrice)";
            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@invoiceNumber", invoiceNumber);
                command.Parameters.AddWithValue("@deliveryReceiptNumber", deliveryReceiptNumber);
                command.Parameters.AddWithValue("@dateReceived", dateReceived);
                command.Parameters.AddWithValue("@invoiceTotalPrice", invoiceTotalPrice);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nUnable to add invoice", "ERROR");
            }
            finally
            {
                connection.Close();
            }
        }

        public int getCount()
        {
            string query = "SELECT  COUNT(*) FROM invoices";
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
                MessageBox.Show("Unable to retrieve count data", "ERROR");
            }
            finally
            {
                connection.Close();
            }

            return value;
        }

        public static InvoicesManager instance
        {
            get { return theInstance; }
        }

    }
}
