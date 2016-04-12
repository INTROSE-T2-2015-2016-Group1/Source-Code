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
    class DeliveryReceiptsManager
    {
        private static DeliveryReceiptsManager theInstance = new DeliveryReceiptsManager();

        private DeliveryReceiptsManager(){}

        public void viewAll(DataGridView dataGridView)      //Displays all delivery receipts, the DR's related supplier PO and the delivered items
        {
            string query = "SELECT	A.deliveryReceiptNumber		AS 'Delivery Receipt Number'," +
                                    "D.supplierPONumber			AS 'Supplier PO Number'," +
                                    "D.itemNumber				AS 'Item Number'," +
                                    "E.description				AS 'Item Description'," +
                                    "A.dateReceived				AS 'Date Received'," +
                                    "B.deliveredQuantity			AS 'Delivered Quantity'," +
                                    "C.approvedQuantity			AS 'Approved Quantity', " +
                                    "C.rejectedQuantity			AS 'Rejected Quantity' " +
                            "FROM 	delivery_receipts A " +
                                    "JOIN delivered_items B " +
                                        "ON B.deliveryReceiptNumber = A.deliveryReceiptNumber " +
                                    "JOIN godo_inspection_results C " +
                                        "ON C.deliveryItemID = B.deliveryItemID " +
                                    "JOIN supplier_order_items D " +
                                        "ON D.supplierOrderID = B.supplierOrderID " +
                                    "JOIN items E " +
                                        "ON D.itemNumber = E.itemNumber " +
                            "ORDER BY A.deliveryReceiptNumber DESC;";

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
        public static DeliveryReceiptsManager instance
        {
            get { return theInstance; }
        }
    }
}
