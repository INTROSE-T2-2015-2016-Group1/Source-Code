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
    class DeliveryItemsManager
    {
        private static DeliveryItemsManager theInstance = new DeliveryItemsManager();

        private DeliveryItemsManager() { }

        public void viewAll(String deliveryReceiptNumber , DataGridView dataGridView)      //Displays all delivery receipts, the DR's related supplier PO and the delivered items
        {
            string query = "SELECT	 A.deliveryReceiptNumber    AS 'Delivery Receipt Number'," +
                                    "C.description              AS 'Delivered Item',"  +    
                                    "A.deliveredQuantity		AS 'Delivered Quantity' " +
                            "FROM 	delivered_items A, supplier_order_items B, items C " +
                            "WHERE 	A.deliveryReceiptNumber = '" + deliveryReceiptNumber + "' " +
                            "AND    A.supplierOrderID = B.supplierOrderID " +
                            "AND    B.itemNumber = C.itemNumber " +
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
        public static DeliveryItemsManager instance
        {
            get { return theInstance; }
        }
    }
}
