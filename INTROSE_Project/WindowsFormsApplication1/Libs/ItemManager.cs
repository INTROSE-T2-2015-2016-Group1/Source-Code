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

        public static ItemManager instance
        {
        get { return theInstance; }
        }

    }

}

