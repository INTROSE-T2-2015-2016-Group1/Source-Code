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
    class SupplierPOManager
    {
        public void viewAll(DataGridView dataGridView)          //Creates a table for all supplier purchase orders and customer purchase order, supplier orders and items
        {
            string query = "SELECT	 A.supplierPONumber		    AS 'Supplier PO Number'," +
		                            "D.customerPONumber		    AS 'Customer PO Number'," +
		                            "A.supplierName			    AS 'Supplier Name'," +
		                            "A.dateIssued			    AS 'Date Issued'," +
                                    "A.expectedDeliveryDate 	AS 'Expected Delivery Date'," +
                                    "B.itemNumber 			    AS 'Item Number'," +
                                    "C.description 			    AS 'Item Description'," +
                                    "B.quantity 				AS 'Item Quantity'," +
                                    "B.currency 				AS 'Currency'," +
                                    "B.pricePerUnit			    AS 'Price Per Unit'," +
                                    "B.totalPrice			    AS 'Total Price'," +
                                    "B.isFinished			    AS 'Status' " +
                            "FROM 	supplier_po A " +
			                    "JOIN supplier_order_items B " +
				                    "ON B.supplierPONumber = A.supplierPONumber " +
			                    "JOIN items C " +
				                    "ON C.itemNumber = B.itemNumber " +
			                    "JOIN customer_po D " +
				                    "ON D.customerPONumber = A.customerPONumber " +
                            "ORDER BY A.supplierPONumber DESC;";     
                                                                                                                                                              
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
