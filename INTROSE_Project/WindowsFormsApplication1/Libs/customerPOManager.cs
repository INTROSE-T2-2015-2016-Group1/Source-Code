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
    class CustomerPOManager
    {
        private static CustomerPOManager theInstance = new CustomerPOManager();

        private CustomerPOManager(){}

        public void viewAll(DataGridView dataGridView)          //Displays all customer purchase orders and the PO's ordered items
        {

            string query = "SELECT	 A.customerPONumber		    AS 'Customer PO Number'," +
                                    "A.customerName			    AS 'Customer Name'," +
                                    "A.dateIssued			    AS 'Date Issued'," +
                                    "A.expectedDeliveryDate 	AS 'Expected Delivery Date'," +
                                    "A.isFinished               AS 'Customer PO Status' " +
                            "FROM 	customer_po A " +
                            "ORDER BY A.customerPONumber DESC;";

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
                MessageBox.Show("Error: Unable to show table due to connection problems", "ERROR");
            }
            finally
            {
                connection.Close();
            }

        }

        public void addData(string customerPONumber, string customerName, string dateIssued, string expectedDeliveryDate)
        {
            string query = "INSERT INTO customer_po (customerPONumber, customerName, dateIssued, expectedDeliveryDate, isFinished) " +
                            "values (@customerPONumber, @customerName, @dateIssued, @expectedDeliveryDate, false)";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@customerPONumber", customerPONumber);
                command.Parameters.AddWithValue("@customerName", customerName);
                command.Parameters.AddWithValue("@dateIssued", dateIssued);
                command.Parameters.AddWithValue("@expectedDeliveryDate", expectedDeliveryDate);

                command.ExecuteNonQuery();

                connection.Close();
            }
            catch
            {
                MessageBox.Show("Unable to add customer purchase order", "ERROR");
            }
            finally
            {
                connection.Close();
            }

        }

        public int getCount()
        {
            string query = "SELECT  COUNT(*) FROM customer_po";
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

        public bool pkExists(string cPONumber)
        {
            string query = "SELECT  COUNT(customerPONumber) FROM customer_po A WHERE A.customerPONumber = '"+ cPONumber +"'";
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

            string query = "SELECT customerPONumber FROM customer_po WHERE isFinished = false";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;

            try
            {
                connection.Open();

                reader = command.ExecuteReader();

                while (reader.Read())
                    itemComboBox.Items.Add(reader.GetString("customerPONumber"));


                connection.Close();
            }
            catch
            {
                MessageBox.Show("Unable to read customer PO database", "ERROR");
            }
            finally
            {
                connection.Close();
            }
        }

        public void setPONotFinished(string customerPONumber)
        {
            string query = "UPDATE customer_po SET isFinished = false WHERE customerPONumber = '" + customerPONumber + "'";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
            catch
            {
                MessageBox.Show("Unable to update data due to connection errors", "ERROR");
            }
            finally
            {
                connection.Close();
            }        
        }

        public void setPOFinished(string customerPONumber)
        {
            string query = "UPDATE customer_po SET isFinished = true WHERE customerPONumber = '" + customerPONumber + "'";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
            catch
            {
                MessageBox.Show("Unable to update data due to connection errors", "ERROR");
            }
            finally
            {
                connection.Close();
            }
        }

        public string getDateIssued(string customerPONumber)
        {
            string query = "SELECT dateIssued FROM customer_po WHERE customerPONumber = '" + customerPONumber + "'";
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
                MessageBox.Show("Unable to retrieve date data", "ERROR");
            }
            finally
            {
                connection.Close();
            }

            return value;
        }

        public static CustomerPOManager instance
        {
            get { return theInstance; }
        }

    }
}
