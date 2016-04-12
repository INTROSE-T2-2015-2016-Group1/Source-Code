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
using introse_project.sub_windows.Purchase_Order.Customer;

namespace introse_project.sub_windows.Purchase_Order
{
    public partial class addCPO : Form
    {
        private static addCPO theInstance = new addCPO();

        private addCPO()
        {
            InitializeComponent();
        }

        private void addCPO_Load(object sender, EventArgs e)
        {
            CustomerManager.instance.fillComboBox(customerNameCBox);
            customerNameCBox.SelectedIndex = 0;
        }

        private void addCPOBtn_Click(object sender, EventArgs e)
        {
            if (ItemManager.instance.getCount() > 0)
            {
                if (!CustomerPOManager.instance.pkExists(cPONumberTxtBox.Text))
                {
                    addCPOItem.instance.setAddType(true);
                    addCPOItem.instance.setPONumber(cPONumberTxtBox.Text);
                    addCPOItem.instance.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Customer purchase order number already exists");
                } 
            }
            else
            {
                MessageBox.Show("No items in item list to add to purchase order");
            }
        }

        public void addNewCPO()
        {
            CustomerPOManager.instance.addData(cPONumberTxtBox.Text, customerNameCBox.SelectedItem.ToString(), dateIssuedCBox.Value.Date.ToShortDateString(), dateExpectedCBox.Value.Date.ToShortDateString());
        }

        public static addCPO instance
        {
            get { return theInstance; }
        }
      
    }
}
