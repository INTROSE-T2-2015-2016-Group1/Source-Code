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

        public string getSupplierPONumber(string deliveryReceiptNumber)
        {
            string query = "SELECT  supplierPONumber FROM delivery_receipts WHERE deliveryReceiptNumber = '" + deliveryReceiptNumber + "'";
            string value = "";
            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                value = command.ExecuteScalar().ToString();

                connection.Close();

                return value;
            }
            catch
            {
                MessageBox.Show("Unable to supplier PO number from database", "ERROR");
            }
            finally
            {
                connection.Close();
            }

            return value;

        }

        public void addData(string deliveryReceiptNumber, string supplierPONumber, string dateReceived)
        {
            string query = "INSERT INTO delivery_receipts (deliveryReceiptNumber, supplierPONumber, dateReceived) values (@deliveryReceiptNumber, @supplierPONumber, @dateReceived)";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@deliveryReceiptNumber", deliveryReceiptNumber);
                command.Parameters.AddWithValue("@supplierPONumber", supplierPONumber);
                command.Parameters.AddWithValue("@dateReceived", dateReceived);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch
            {
                MessageBox.Show("Unable to add supplier", "ERROR");
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

        public bool pkExists(string deliveryReceiptNumber)
        {
            string query = "SELECT  COUNT(deliveryReceiptNumber) FROM delivery_receipts A WHERE A.deliveryReceiptNumber = '" + deliveryReceiptNumber + "'";
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
                MessageBox.Show("Unable to retreieve data for validation", "ERROR");
            }
            finally
            {
                connection.Close();
            }

            return false;

        }

        public void fillComboBox(ComboBox itemComboBox)     //fills up the combo box with values within the database
        {
            itemComboBox.Items.Clear();

            string query = "SELECT A.deliveryReceiptNumber FROM delivered_items A, invoice_items B " +
                           "WHERE A.deliveryItemID = B.deliveryItemID AND A.approvedQuantity > B.deliveredQuantity";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;

            try
            {
                connection.Open();

                reader = command.ExecuteReader();

                while (reader.Read())
                    itemComboBox.Items.Add(reader.GetString("deliveryReceiptNumber"));


                connection.Close();
            }
            catch
            {
                MessageBox.Show("Unable to read customer list database", "ERROR");
            }
            finally
            {
                connection.Close();
            }
        }

        public string getDateReceived(string deliveryReceiptNumber)
        {
            string query = "SELECT  dateReceived FROM delivery_receipts A WHERE A.deliveryReceiptNumber = '" + deliveryReceiptNumber + "'",
                   date = "";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                date = command.ExecuteScalar().ToString();

                connection.Close();

                return date;
            }
            catch
            {
                MessageBox.Show("Unable to retrieve data due to connection problems", "ERROR");
            }
            finally
            {
                connection.Close();
            }

            return date;
        }

        public static DeliveryReceiptsManager instance
        {
            get { return theInstance; }
        }
    }
}
