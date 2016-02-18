using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace Purchase_Order_Maintenance_Application
{
    class Queries
    {
        public Queries()
        {

        }
        public Boolean checkConnection()    //This function checks whether there is a connection to the mySQL database
        {
            try
            {
                string conString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
                MySqlConnection connection = new MySqlConnection(conString);
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = new MySqlCommand("SELECT * FROM employee", connection);
                MySqlCommandBuilder cb = new MySqlCommandBuilder(sda);
                connection.Open();
                connection.Close();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }

        }
    }
}
