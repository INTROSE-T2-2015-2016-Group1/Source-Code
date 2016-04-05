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
            string query = "SELECT	 A.deliveryItemID           AS 'Delivery Item ID'," +
                                    "A.supplierOrderID          AS 'Supplier Order ID'," +
                                    "A.deliveryReceiptNumber    AS 'Delivery Receipt Number'," +
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

                dataGridView.Columns["Delivery Item ID"].Visible = false;
                dataGridView.Columns["Supplier Order ID"].Visible = false;
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

        public void addData(string deliveryReceiptNumber, int supplierOrderID, int deliveredQuantity)
        {
            string query = "INSERT INTO delivered_items (deliveryReceiptNumber, supplierOrderID, deliveredQuantity) values (@deliveryReceiptNumber, @supplierOrderID, @deliveredQuantity)";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@deliveryReceiptNumber", deliveryReceiptNumber);
                command.Parameters.AddWithValue("@supplierOrderID", supplierOrderID);
                command.Parameters.AddWithValue("@deliveredQuantity", deliveredQuantity);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch
            {
                MessageBox.Show("Unable to add item", "ERROR");
            }
            finally
            {
                connection.Close();
            }
        }

        public int getTotalApprovedQuantity(int supplierOrderID)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nUnable to get count data", "ERROR");
            }
            finally
            {
                connection.Close();
            }

            return value;

        }

        public static DeliveryItemsManager instance
        {
            get { return theInstance; }
        }
    }
}
