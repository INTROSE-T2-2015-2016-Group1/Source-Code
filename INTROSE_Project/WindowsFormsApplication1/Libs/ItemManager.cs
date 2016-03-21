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
    class ItemManager
    {
        private static ItemManager theInstance = new ItemManager();

        private ItemManager() {}

        public void viewAll(DataGridView dataGridView)      //Displays all the items listed and their respective manufacturer (suppliers)
        {
            string query = "SELECT  itemNumber      AS 'Item Number'," +
                                    "supplierName   AS 'Supplier Name'," +
                                    "description    AS 'Description' " +
                                    "FROM items " +
                                    "ORDER BY itemNumber ASC;";
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

        public void addData(string supplierName, string description)
        {
            string query = "INSERT INTO items (supplierName, description) values (@supplierName, @description)";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@supplierName", supplierName);
                command.Parameters.AddWithValue("@description", description);
                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Item Added");
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

        public void fillComboBox(ComboBox itemComboBox)     //fills up the combo box with values within the database
        {
            itemComboBox.Items.Clear();

            string query = "SELECT DISTINCT(description) FROM items";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;

            try
            {
                connection.Open();

                reader = command.ExecuteReader();

                while (reader.Read())
                    itemComboBox.Items.Add(reader.GetString("description"));


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

        public void fillRelatedSuppliers(ComboBox supplierComboBox, String description)     //fills up the combo box with the suppliers that match the description
        {
            supplierComboBox.Items.Clear();

            string query = "SELECT * FROM items A WHERE A.description = '"+ description +"'";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
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
                MessageBox.Show("Unable to read items database");
            }
            finally
            {
                connection.Close();
            }
        }

        public int getItemNumber(String description, String supplierName)
        {
            string query = "SELECT  itemNumber FROM items A " +
                           "WHERE A.description = '"+ description +"' AND A.supplierName = '"+ supplierName +"' ";

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
                MessageBox.Show("Data passed was invalid");
            }
            finally
            {
                connection.Close();
            }

            return value;
        }

        public static ItemManager instance
        {
            get { return theInstance; }
        }

    }

}

