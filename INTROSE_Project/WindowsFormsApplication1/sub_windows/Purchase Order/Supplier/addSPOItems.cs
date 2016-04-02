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

namespace introse_project.sub_windows.Purchase_Order.Supplier
{
    public partial class addSPOItems : Form
    {
        private static addSPOItems theInstance = new addSPOItems();

        Boolean addType = false; //false means add item ONLY, true means add item with new PO
        String supplierPONumber;
        String supplierName;
        String customerPONumber;

        private addSPOItems()
        {
            InitializeComponent();
        }

        private void addSPOItems_Load(object sender, EventArgs e)
        {
            CustomerOrderItemsManagercs.instance.getOrderItems(itemDescCBox, this.customerPONumber, this.supplierName);
            itemDescCBox.SelectedIndex = 0;          
        }

        public void setPONumber(String supplierPONumber,  String customerPONumber)
        {
            this.supplierPONumber = supplierPONumber;
            this.customerPONumber = customerPONumber;
        }

        public void setSupplierName(String supplierName)
        {
            this.supplierName = supplierName;
        }

        public void setAddType(Boolean addType)
        {
            this.addType = addType;
        }

        #region Key Press Event Handlers
        private void itemQtyTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pricePerUnitTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) //checks if it's only one decimal place
            {
                e.Handled = true;
            }
        }

        private void totalPriceTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) //checks if it's only one decimal place
            {
                e.Handled = true;
            }
        }
        #endregion

        private void addCPOItemsBtn_Click(object sender, EventArgs e)
        {
            if (addType)
            {
                addSPO.instance.addNewSPO();
            }

            int itemNumber = ItemManager.instance.getItemNumber(itemDescCBox.SelectedItem.ToString(), this.supplierName);

            if (SupplierPOManager.instance.pkExists(this.supplierPONumber) && !SupplierOrderItemsManager.instance.isItemExists(itemNumber))
            {
                SupplierOrderItemsManager.instance.addData(this.supplierPONumber,
                                                           itemNumber,
                                                           Convert.ToInt32(itemQtyTxtBox.Text),
                                                           currencyTxtBox.Text,
                                                           double.Parse(pricePerUnitTxtBox.Text),
                                                           double.Parse(totalPriceTxtBox.Text));
            }
            else
            {
                MessageBox.Show("The item/PO you're trying to add already exists!", "ERROR");
            }
            this.Close();
        }

        public static addSPOItems instance
        {
            get { return theInstance; }
        }
       
    }
}
