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
                MessageBox.Show("Error: Unable to show table due to connection problems");
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
                MessageBox.Show("Purchase Order Added");
            }
            catch
            {
                MessageBox.Show("Unable to add customer purchase order");
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
                MessageBox.Show("Error: Unable to retrieve data due to connection problems");
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
                MessageBox.Show("Unable to retrieve data due to connection problems");
            }
            finally
            {
                connection.Close();
            }

            return false;
        
        }

        public static CustomerPOManager instance
        {
            get { return theInstance; }
        }

    }
}
