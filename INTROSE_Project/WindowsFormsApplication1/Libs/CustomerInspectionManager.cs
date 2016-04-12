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
    class CustomerInspectionManager
    {
        private static CustomerInspectionManager theInstance = new CustomerInspectionManager();

        private CustomerInspectionManager() {}

        public bool isExists(int invoiceItemID)
        {
            string query = "SELECT  COUNT(*) FROM customer_inspection_results A WHERE A.invoiceItemID = " + invoiceItemID.ToString() + "";
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
                MessageBox.Show("Unable to retrieve data due to connection problems", "ERROR");
            }
            finally
            {
                connection.Close();
            }

            return false;
        }

        public void addData(int invoiceItemID)
        {
            string query = "INSERT INTO customer_inspection_results (invoiceItemID, approvedQuantity, rejectedQuantity) values (@deliveryItemID, @approvedQuantity, @rejectedQuantity)";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@invoiceItemID", invoiceItemID);
                command.Parameters.AddWithValue("@approvedQuantity", 0);
                command.Parameters.AddWithValue("@rejectedQuantity", 0);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch
            {
                MessageBox.Show("Unable to update inspection results", "ERROR");
            }
            finally
            {
                connection.Close();
            }
        }

        public void updateData(int invoiceItemID, int approvedQuantity, int rejectedQuantity)
        {
            string query = "UPDATE customer_inspection_results SET approvedQuantity = @approvedQuantity, rejectedQuantity = @rejectedQuantity WHERE deliveryItemID = " + invoiceItemID.ToString() + "";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@approvedQuantity", approvedQuantity);
                command.Parameters.AddWithValue("@rejectedQuantity", rejectedQuantity);
                command.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("Inspection Resut updated!");
            }
            catch
            {
                MessageBox.Show("Unable to add inspection results", "ERROR");
            }
            finally
            {
                connection.Close();
            }
        }

        public static CustomerInspectionManager instance
        {
            get { return theInstance; }
        }
    }
}
