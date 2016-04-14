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
    class DeliveryItemsManager
    {
        private static DeliveryItemsManager theInstance = new DeliveryItemsManager();

        private DeliveryItemsManager() { }

        public void viewAll(String deliveryReceiptNumber , DataGridView dataGridView)      //Displays all delivery receipts, the DR's related supplier PO and the delivered items
        {
            string query = "SELECT	 A.deliveryItemID           AS 'Delivery Item ID'," +
                                    "A.supplierOrderID          AS 'Supplier Order ID'," +
                                    "A.deliveryReceiptNumber    AS 'Delivery Receipt Number'," +
                                    "B.description              AS 'Delivered Item',"  +    
                                    "A.deliveredQuantity		AS 'Delivered Quantity' " +
                            "FROM 	delivered_items A, items B " +
                            "WHERE 	A.deliveryReceiptNumber = '" + deliveryReceiptNumber + "' " +
                            "AND    A.itemNumber = B.itemNumber " +
                            "ORDER BY A.deliveryReceiptNumber DESC;";

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

                dataGridView.Columns["Delivery Item ID"].Visible = false;
                dataGridView.Columns["Supplier Order ID"].Visible = false;
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

        public void addData(int itemNumber, string deliveryReceiptNumber, int supplierOrderID, int deliveredQuantity)
        {
            string query = "INSERT INTO delivered_items (itemNumber, deliveryReceiptNumber, supplierOrderID, deliveredQuantity, approvedQuantity, rejectedQuantity) values (@itemNumber, @deliveryReceiptNumber, @supplierOrderID, @deliveredQuantity, @approvedQuantity, @rejectedQuantity)";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@itemNumber", itemNumber);
                command.Parameters.AddWithValue("@deliveryReceiptNumber", deliveryReceiptNumber);
                command.Parameters.AddWithValue("@supplierOrderID", supplierOrderID);
                command.Parameters.AddWithValue("@deliveredQuantity", deliveredQuantity);
                command.Parameters.AddWithValue("@approvedQuantity", 0);
                command.Parameters.AddWithValue("@rejectedQuantity", 0);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message +"\nUnable to add item", "ERROR");
            }
            finally
            {
                connection.Close();
            }
        }

        #region Godo Inspection Result Functions
        public int getApprovedQuantity(int deliveryItemID)
        {
            string query = "SELECT approvedQuantity FROM delivered_items WHERE deliveryItemID = " + deliveryItemID.ToString() + "";
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
            string query = "SELECT rejectedQuantity FROM delivered_items WHERE deliveryItemID = " + deliveryItemID.ToString() + "";
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

        public void updateData(int deliveryItemID, int approvedQuantity, int rejectedQuantity)
        {
            string query = "UPDATE delivered_items SET approvedQuantity = @approvedQuantity, rejectedQuantity = @rejectedQuantity WHERE deliveryItemID = " + deliveryItemID.ToString() + "";

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


        public int getTotalApprovedQuantity(int supplierOrderID)
        {
            string query = "SELECT  SUM(approvedQuantity) FROM delivered_items A " +
                           "WHERE A.supplierOrderID = " + supplierOrderID.ToString() + "";
            int value = 0;
            string textValue;
            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                textValue = command.ExecuteScalar().ToString();

                connection.Close();

                if (int.TryParse(textValue, out value))
                {
                    return value;
                }
                else
                {
                    return 0;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return value;

        }
        #endregion

        public bool isItemExists(int itemNumber, string deliveryReceiptNumber)
        {
            string query = "SELECT  COUNT(itemNumber) FROM delivered_items A WHERE A.itemNumber = " + itemNumber + " AND A.deliveryReceiptNumber = '" + deliveryReceiptNumber + "'";
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

        public void fillComboBox(ComboBox deliveredItemsComboBox, string deliveryReceiptNumber)
        {
            deliveredItemsComboBox.Items.Clear();

            string query = "SELECT B.description FROM delivered_items A, items B WHERE A.deliveryReceiptNumber = '" + deliveryReceiptNumber + "' AND A.itemNumber = B.itemNumber";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader;

            try
            {
                connection.Open();

                reader = command.ExecuteReader();

                while (reader.Read())
                    deliveredItemsComboBox.Items.Add(reader.GetString("description"));


                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\nUnable to read supplier database", "ERROR");
            }
            finally
            {
                connection.Close();
            }
        }

        public int itemOrderedID(int itemNumber, string deliveryReceiptNumber)     //gets the itemID given an itemNumber and a supplierPONumber
        {
            string query = "SELECT A.deliveryItemID FROM delivered_items A " +
                           "WHERE A.deliveryReceiptNumber = '" + deliveryReceiptNumber + "' AND A.itemNumber = " + itemNumber.ToString() + " ";
            int id = 0;

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                id = Convert.ToInt32(command.ExecuteScalar().ToString());
                connection.Close();
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nUnable to read ordered items database", "ERROR");
            }
            finally
            {
                connection.Close();
            }
            return id;
        }

        public int getOrderedItemID(string itemDescription, string deliveryReceiptNumber)
        {
            string query = "SELECT  B.itemNumber FROM delivered_items A, items B " +
                           "WHERE A.itemNumber = B.itemNumber AND B.description = '" + itemDescription.ToString() + "' AND A.deliveryReceiptNumber = '" + deliveryReceiptNumber + "'";
            
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
                MessageBox.Show("Unable to get ID", "ERROR");
            }
            finally
            {
                connection.Close();
            }

            return value;
        }

        public int getTotalDeliveredQuantity(int supplierOrderID)
        {
            string query = "SELECT SUM(quantity) FROM delivered_items WHERE supplierOrderID = " + supplierOrderID.ToString() + " ";
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
                MessageBox.Show("Unable to retrieve count data");
            }
            finally
            {
                connection.Close();
            }

            return value;
        }

        public static DeliveryItemsManager instance
        {
            get { return theInstance; }
        }
    }
}
