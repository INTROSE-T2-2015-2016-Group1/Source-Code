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
        public void viewAll(DataGridView dataGridView)          //Displays all customer purchase orders and the PO's ordered items
        {

            string query = "SELECT	 A.customerPONumber		    AS 'Customer PO Number'," +
                                    "A.customerName			    AS 'Customer Name'," +
                                    "A.dateIssued			    AS 'Date Issued'," +
                                    "A.expectedDeliveryDate 	AS 'Expected Delivery Date'," +
                                    "B.itemNumber 			    AS 'Item Number'," +
                                    "C.description 			    AS 'Item Description'," +
                                    "B.quantity 				AS 'Item Quantity'," +
                                    "B.currency 				AS 'Currency'," +
                                    "B.pricePerUnit			    AS 'Price Per Unit'," +
                                    "B.totalPrice			    AS 'Total Price'," +
                                    "B.isFinished			    AS 'Status' " +
                            "FROM 	customer_po A " +
                                "JOIN customer_order_items B " +
                                    "ON B.customerPONumber = A.customerPONumber " +
                                "JOIN items C " +
                                    "ON C.itemNumber = B.itemNumber " +
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

        }

    }
}
