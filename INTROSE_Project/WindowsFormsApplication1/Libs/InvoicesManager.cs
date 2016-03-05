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
        public void viewAll(DataGridView dataGridView)      //Displays all invoices, the delivered items within the invoice and the customer's QA inspection results
        {
            string query = "SELECT	A.invoiceNumber						AS 'Invoice Number'," +
                            "A.deliveryReceiptNumber 			        AS 'Delivery Receipt Number'," +
                            "A.customerPONumber					        AS 'Customer PO Number'," +
                            "A.invoiceTotalPrice					    AS 'Total Invoice Price'," +
                            "E.itemNumber						        AS 'Item Number'," +
                            "G.description						        AS 'Item Description'," +
                            "E.pricePerUnit						        AS 'Price Per Unit'," +
                            "E.pricePerUnit*B.deliveredQuantity	        AS 'Total Item Price'," +
                            "A.dateReceived						        AS 'Date Received' " +
                    "FROM invoices A " +
                        "JOIN invoice_items B " +
                            "ON B.invoiceNumber = A.invoiceNumber " +
                        "JOIN delivered_items C " +
                            "ON C.deliveryItemID = B.deliveryItemID " +
                        "JOIN customer_po D " +
                            "ON D.customerPONumber = A.customerPONumber " +
                        "JOIN customer_order_items E " +
                            "ON E.customerOrderID = B.customerOrderID " +
                        "JOIN customer_inspection_results F " +
                            "ON F.invoiceItemID = B.invoiceItemID " +
                        "JOIN items G " +
                            "ON G.itemNumber = E.itemNumber " +
                    "ORDER BY A.invoiceNumber DESC;";

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
        
        }

    }
}
