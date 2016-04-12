using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using introse_project.Libs;

namespace introse_project.sub_windows.Purchase_Order.Customer
{
    public partial class viewCPOItems : Form
    {
        private static viewCPOItems theInstance = new viewCPOItems();

        private string customerPONumber;    

        private viewCPOItems()
        {
            InitializeComponent();         
        }

        private void viewCPOItems_Load(object sender, EventArgs e)
        {
            CustomerOrderItemsManagercs.instance.viewAll(customerPONumber, cpoItemsGridView);
        }

        public void setPONUmber(string customerPONumber)
        {
            this.customerPONumber = customerPONumber;
        }

        private void addCPOItemsBtn_Click(object sender, EventArgs e)
        {
            if(ItemManager.instance.getCount() > 0)
            {
                addCPOItem.instance.setAddType(false);
                addCPOItem.instance.setPONumber(this.customerPONumber);
                addCPOItem.instance.ShowDialog();
                CustomerOrderItemsManagercs.instance.viewAll(customerPONumber, cpoItemsGridView);
            }
            else
            {
                MessageBox.Show("No items in item list to add to purchase order", "ERROR");
            }        
        }

        public static viewCPOItems instance
        {
            get { return theInstance; }
        }    

    }
}
