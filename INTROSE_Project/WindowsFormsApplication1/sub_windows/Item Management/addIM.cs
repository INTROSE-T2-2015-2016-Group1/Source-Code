using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;
using introse_project.Libs;

namespace introse_project.sub_windows.Item_Management
{
    public partial class addIM : Form
    {
        public addIM()
        {
            InitializeComponent();
            fillComboBox();
            supplierComboBox.SelectedIndex = 0;
        }

        private void fillComboBox()     //fills up the combo box with values within the database
        {
            string query = "SELECT * FROM suppliers";

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
                MessageBox.Show("Unable to read supplier database");
            }
            finally
            {
                connection.Close();
            }
        }

        private void itemAddBtn_Click(object sender, EventArgs e)
        {
            ItemManager.instance.addData(supplierComboBox.SelectedItem.ToString(), descTxtBox.Text);
            this.Close();
        }
    }
}
