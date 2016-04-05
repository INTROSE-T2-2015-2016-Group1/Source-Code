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

        Boolean addType = false; //false means add item ONLY, true means add item with new PO
        String customerPONumber;

        private addCPOItem()
        {
            InitializeComponent();
        }

        public void setPONumber(String customerPONumber)
        {
            this.customerPONumber = customerPONumber;
        }

        public void setAddType(Boolean addType)
        {
            this.addType = addType;
        }

        private void addCPOItem_Load(object sender, EventArgs e)
        {
            ItemManager.instance.fillComboBox(itemDescCBox);
            itemDescCBox.SelectedIndex = 0;
        }

        #region Keypress Event Handlers
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
                addCPO.instance.addNewCPO();
            }

            if (CustomerPOManager.instance.pkExists(this.customerPONumber) && !CustomerOrderItemsManagercs.instance.isItemExists(itemDescCBox.SelectedItem.ToString(),                                                                                                                                customerPONumber))
            {
                CustomerOrderItemsManagercs.instance.addData(this.customerPONumber,
                                                         itemDescCBox.SelectedItem.ToString(),
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

        public static addCPOItem instance
        {
            get { return theInstance; }
        }
      
    }
}
