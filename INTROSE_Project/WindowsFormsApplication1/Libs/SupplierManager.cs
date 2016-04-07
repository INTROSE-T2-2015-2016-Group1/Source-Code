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
    class SupplierManager
    {
        private static SupplierManager theInstance = new SupplierManager();
        private SupplierManager(){}

        public void viewAll(DataGridView dataGridView)      //Displays all the listed suppliers
        {
            string query =  "SELECT supplierName AS 'Supplier Name' " +
                            "FROM  suppliers " + 
                            "ORDER BY supplierName DESC;";
            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["roiConn"].ConnectionString);
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

        public void addData(string supplierName)
        {
            string query = "INSERT INTO suppliers (supplierName) values (@supplierName)";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["jutsconn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@supplierName", supplierName);
                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Supplier Added");
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
            string query = "SELECT  COUNT(*) FROM suppliers";
            int value = 0;
            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["jutsconn"].ConnectionString);
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

        public void fillComboBox(ComboBox supplierComboBox)     //fills up the combo box with values within the database
        {
            supplierComboBox.Items.Clear();
            
            string query = "SELECT * FROM suppliers";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["jutsconn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;

            try
            {
                connection.Open();

                reader = command.ExecuteReader();

                while (reader.Read())
                    supplierComboBox.Items.Add(reader.GetString("supplierName"));


                connection.Close();
            }
            catch
            {
                MessageBox.Show("Unable to read supplier database");
            }
            finally
            {
                connection.Close();
            }
        }

        public static SupplierManager instance
        {
            get { return theInstance; }
        }

    }

}
