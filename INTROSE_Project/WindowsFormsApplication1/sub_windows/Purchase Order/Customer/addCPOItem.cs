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
        #region Variables
        private static addCPOItem theInstance = new addCPOItem();
        Boolean addType = false;    //false means add item ONLY, true means add item with new PO
        String customerPONumber;
        int quantity;
        double pricePerUnit;
        bool valid = false;         //checks if everything is valid for adding
        #endregion

        private addCPOItem()
        {
            InitializeComponent();
        }

        #region Setters
        public void setPONumber(String customerPONumber)
        {
            this.customerPONumber = customerPONumber;
        }

        public void setAddType(Boolean addType)
        {
            this.addType = addType;
        }
        #endregion

        #region Event Handlers
        private void addCPOItem_Load(object sender, EventArgs e)
        {
            ItemManager.instance.fillComboBox(itemDescCBox);
            itemDescCBox.SelectedIndex = 0;
            currencyCBox.SelectedIndex = 0;
        }

        private void itemQtyTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(itemQtyTxtBox.Text, out quantity)  && double.TryParse(pricePerUnitTxtBox.Text, out pricePerUnit) )
            {
                totalPriceLabel.Text = (quantity * pricePerUnit).ToString();
                valid = true;
            }
            else
            {
                valid = false;
            }
        }

        private void pricePerUnitTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(itemQtyTxtBox.Text, out quantity) && double.TryParse(pricePerUnitTxtBox.Text, out pricePerUnit))
            {
                totalPriceLabel.Text = (quantity * pricePerUnit).ToString();
                valid = true;
            }
            else
            {
                valid = false;
            }
        }
        #endregion

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

        #region Button Click Events
        private void addCPOItemsBtn_Click(object sender, EventArgs e)
        {

            if (!CustomerPOManager.instance.pkExists(this.customerPONumber)
                && !CustomerOrderItemsManagercs.instance.isItemExists(itemDescCBox.SelectedItem.ToString(), customerPONumber)
                && this.valid)
            {              
                if (addType)
                {
                    addCPO.instance.addNewCPO();
                }

            
                CustomerOrderItemsManagercs.instance.addData(this.customerPONumber,
                                                         itemDescCBox.SelectedItem.ToString(),
                                                         Convert.ToInt32(itemQtyTxtBox.Text),
                                                         currencyCBox.SelectedItem.ToString(),
                                                         double.Parse(pricePerUnitTxtBox.Text),
                                                         double.Parse(totalPriceLabel.Text));
                
                itemQtyTxtBox.Text = "";
                pricePerUnitTxtBox.Text = "";
                totalPriceLabel.Text = "";

                this.Close();
            }
            else
            {
                MessageBox.Show("The item you are trying to add already exists or the entered values are missing/incorrect", "ERROR");
            }
            
        }
        #endregion

        public static addCPOItem instance
        {
            get { return theInstance; }
        }       
      
    }
}
