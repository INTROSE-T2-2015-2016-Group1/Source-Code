﻿using System;
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

        public void addData(string supplierName)
        {
            string query = "INSERT INTO suppliers (supplierName) values (@supplierName)";

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();

                command.Parameters.AddWithValue("@supplierName", supplierName);
                command.ExecuteNonQuery();

                connection.Close();
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

        public static SupplierManager instance
        {
            get { return theInstance; }
        }

    }

}
