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
    class CustomerManager
    {

        private static CustomerManager theInstance = new CustomerManager();

        private CustomerManager(){}

        public void viewAll(DataGridView dataGridView)      //Displays all listed customers
        {

            string query = "SELECT customerName AS 'Customer Name' " +
                            "FROM  customers " +
                            "ORDER BY customerName DESC;";
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

        public void addData(string customerName)
        {
            string query = "INSERT INTO customers (customerName) values (@customerName)";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@customerName", customerName);
                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Customer Added");
            }
            catch
            {
                MessageBox.Show("Unable to add");
            }
            finally
            {
                connection.Close();
            }
        }

        public int getCount()
        {
            string query = "SELECT  COUNT(*) FROM customers";
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

        public void fillComboBox(ComboBox itemComboBox)     //fills up the combo box with values within the database
        {
            itemComboBox.Items.Clear();

            string query = "SELECT * FROM customers";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;

            try
            {
                connection.Open();

                reader = command.ExecuteReader();

                while (reader.Read())
                    itemComboBox.Items.Add(reader.GetString("customerName"));


                connection.Close();
            }
            catch
            {
                MessageBox.Show("Unable to read items database");
            }
            finally
            {
                connection.Close();
            }
        }

        public static CustomerManager instance
        {
            get { return theInstance; }
        }

    }
}
