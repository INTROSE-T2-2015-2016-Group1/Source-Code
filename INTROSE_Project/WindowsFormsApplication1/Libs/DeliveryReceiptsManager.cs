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
            string query = "SELECT	 A.deliveryReceiptNumber		AS 'Delivery Receipt Number'," +
                                    "A.supplierPONumber			AS 'Supplier PO Number'," +
                                    "A.dateReceived				AS 'Date Received' " +
                            "FROM 	delivery_receipts A " +
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

        public int getCount()
        {
            string query = "SELECT  COUNT(*) FROM delivery_receipts";
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

        public static DeliveryReceiptsManager instance
        {
            get { return theInstance; }
        }
    }
}
