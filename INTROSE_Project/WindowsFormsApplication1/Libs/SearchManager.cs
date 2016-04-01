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
    class SearchManager
    {
        private static SearchManager theInstance = new SearchManager();

        private SearchManager() 
        {
        }

        public void searchForm(DataGridView dataGridView, String formType, String input)
        {
            string query =  "";
            formType = formType.ToLower();

            if(formType == "customer_inspection_results")
                query = "SELECT * FROM customer_inspection_results " +
                        " WHERE invoiceItemID LIKE '" + input +
                        "' OR approvedQuantity LIKE '" + input +
                        "' OR rejectedQuantity LIKE '" + input + "'";
            else if(formType == "customer_order_items")
                query = "SELECT * FROM customer_order_items " +
                        " WHERE customerOrderID LIKE '" + input +
                        "' OR customerPONumber LIKE '" + input +
                        "' OR itemNumber LIKE '" + input +
                        "' OR quantity LIKE '" + input +
                        "' OR currency LIKE '" + input +
                        "' OR itemDescription LIKE '" + input +
                        "' OR pricePerUnit LIKE '" + input +
                        "' OR totalPrice LIKE '" + input +
                        "' OR isFinished LIKE '" + input + "'";

            Console.WriteLine(query);

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["jutsconn"].ConnectionString);
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

        public static SearchManager instance
        {
            get { return theInstance; }
        }
    }
}
