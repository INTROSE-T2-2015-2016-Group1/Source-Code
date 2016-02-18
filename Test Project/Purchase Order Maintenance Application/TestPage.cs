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

namespace Purchase_Order_Maintenance_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click_1(object sender, EventArgs e)
        {
            Queries Q = new Queries();

            if (Q.checkConnection())
                MessageBox.Show("Connected");
            else
                MessageBox.Show("Error Connecting");
        }
    }
}
