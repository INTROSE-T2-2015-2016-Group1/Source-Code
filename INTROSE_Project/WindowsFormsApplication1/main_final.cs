using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using introse_project.sub_windows.delivery;
using introse_project.sub_windows.Delivery_Monitoring_Sheet;
using introse_project.sub_windows.Delivery_Receipt;
using introse_project.sub_windows.Purchase_Order;
using introse_project.sub_windows.Quotation_Form;
using introse_project.sub_windows.Sales_Invoice;

namespace introse_project
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage24_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            addDelivery add = new addDelivery();
            add.ShowDialog(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateDelivery update = new updateDelivery();
            update.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            addDelivery add = new addDelivery();
            add.ShowDialog(); 
        }
        private void button15_Click(object sender, EventArgs e)
        {
            addQF add = new addQF();
            add.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            updateQF update = new updateQF();
            update.ShowDialog();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            addPO add = new addPO();
            add.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            updatePO update = new updatePO();
            update.ShowDialog();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            addPO add = new addPO();
            add.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            updatePO update = new updatePO();
            update.ShowDialog();
        }
        private void button16_Click(object sender, EventArgs e)
        {
            addDMS add = new addDMS();
            add.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            updateDMS update = new updateDMS();
            update.ShowDialog();

        }
        private void button17_Click(object sender, EventArgs e)
        {
            addSI add = new addSI();
            add.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            updateSI update = new updateSI();
            update.ShowDialog();
        }
        private void button18_Click_1(object sender, EventArgs e)
        {
            addDR add = new addDR();
            add.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            updateDR update = new updateDR();
            update.ShowDialog();
        }

        private void tabPage14_Click(object sender, EventArgs e)
        {

        }

        private void mainTab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        
    }
}
