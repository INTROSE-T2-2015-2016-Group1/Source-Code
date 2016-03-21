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
    public partial class addCPOItem : Form
    {
        private static addCPOItem theInstance = new addCPOItem();

        String customerPONumber;

        private addCPOItem()
        {
            InitializeComponent();
        }

        public void setPONumber(String customerPONumber)
        {
            this.customerPONumber = customerPONumber;
        }

        private void addCPOItem_Load(object sender, EventArgs e)
        {
            ItemManager.instance.fillComboBox(itemDescCBox);
            itemDescCBox.SelectedIndex = 0;
        }

        private void itemDescCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ItemManager.instance.fillRelatedSuppliers(itemSupplierCBox, itemDescCBox.SelectedItem.ToString());
            itemSupplierCBox.SelectedIndex = 0;
        }

        private void addCPOItemsBtn_Click(object sender, EventArgs e)
        {
            CustomerOrderItemsManagercs.instance.addData(this.customerPONumber, 
                                                         ItemManager.instance.getItemNumber(itemDescCBox.SelectedItem.ToString() ,itemSupplierCBox.SelectedItem.ToString()), 
                                                         Convert.ToInt32(itemQtyTxtBox.Text), 
                                                         currencyTxtBox.Text, 
                                                         double.Parse(pricePerUnitTxtBox.Text),
                                                         double.Parse(totalPriceTxtBox.Text));
            this.Close();
        }

        public static addCPOItem instance
        {
            get { return theInstance; }
        }
      
    }
}
