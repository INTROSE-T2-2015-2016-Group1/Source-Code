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
    class GodoInspectionManager
    {
        private static GodoInspectionManager theInstance = new GodoInspectionManager();

        private GodoInspectionManager(){}

        public int getApprovedQuantity(int deliveryItemID)
        {
            string query = "SELECT  approvedQuantity FROM godo_inspection_results WHERE deliveryItemID = "+ deliveryItemID.ToString() +"";
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
                MessageBox.Show("Unable to get count data", "ERROR");
            }
            finally
            {
                connection.Close();
            }

            return value;

        }

        public int getRejectedQuantity(int deliveryItemID)
        {
            string query = "SELECT  rejectedQuantity FROM godo_inspection_results WHERE deliveryItemID = " + deliveryItemID.ToString() + "";
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
                MessageBox.Show("Unable to get count data", "ERROR");
            }
            finally
            {
                connection.Close();
            }

            return value;

        }

        public void addData(int deliveryItemID)
        {
            string query = "INSERT INTO godo_inspection_results (deliveryItemID, approvedQuantity, rejectedQuantity) values (@deliveryItemID, @approvedQuantity, @rejectedQuantity)";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@deliveryItemID", deliveryItemID);
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

        public void updateData(int deliveryItemID, int approvedQuantity, int rejectedQuantity)
        {
            string query = "UPDATE godo_inspection_results SET approvedQuantity = @approvedQuantity, rejectedQuantity = @rejectedQuantity WHERE deliveryItemID = " + deliveryItemID.ToString() + "";

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

        public bool isExists(int deliverItemID)
        {
            string query = "SELECT  COUNT(*) FROM godo_inspection_results A WHERE A.deliveryItemID = " + deliverItemID.ToString() + "";
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

        public static GodoInspectionManager instance
        {
            get { return theInstance; }
        }

    }
}
