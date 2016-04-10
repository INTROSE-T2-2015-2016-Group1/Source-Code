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

        private Boolean addType = false;    //false means add item ONLY, true means add item with new PO
        private String customerPONumber;    //current  cPO being processed

        private int quantity;
        private double pricePerUnit;
        private double totalPrice;
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

        private void itemQtyTxtBox_TextChanged(object sender, EventArgs e) //sets the total price if both quantity and price per unit is valid
        {
            if (int.TryParse(itemQtyTxtBox.Text, out quantity)  && double.TryParse(pricePerUnitTxtBox.Text, out pricePerUnit) )
            {
                totalPriceLabel.Text = (quantity * pricePerUnit).ToString();
            }
        }

        private void pricePerUnitTxtBox_TextChanged(object sender, EventArgs e) //sets the total price if both quantity and price per unit is valid
        {
            if (int.TryParse(itemQtyTxtBox.Text, out quantity) && double.TryParse(pricePerUnitTxtBox.Text, out pricePerUnit))
            {
                totalPriceLabel.Text = (quantity * pricePerUnit).ToString();
            }
        }
        #endregion

        #region Keypress Event Handlers
        private void itemQtyTxtBox_KeyPress(object sender, KeyPressEventArgs e) //checks if the value is a valid int value
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pricePerUnitTxtBox_KeyPress(object sender, KeyPressEventArgs e) //checks if the value is a valid double value
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

            if (((!CustomerPOManager.instance.pkExists(this.customerPONumber) && addType) || (CustomerPOManager.instance.pkExists(this.customerPONumber) && !addType))
                && !CustomerOrderItemsManagercs.instance.isItemExists(itemDescCBox.SelectedItem.ToString(), customerPONumber)
                && double.TryParse(totalPriceLabel.Text, out totalPrice)) //checks if total price is valid
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
                                                         totalPrice);

                CustomerPOManager.instance.setPONotFinished(this.customerPONumber);

                itemQtyTxtBox.Text = "";
                pricePerUnitTxtBox.Text = "";
                totalPriceLabel.Text = "";

                this.Close();
            }
            else
            {
                MessageBox.Show("The item/PO you are trying to add already exists or the entered values are missing/incorrect", "ERROR");
            }
            
        }
        #endregion

        public static addCPOItem instance
        {
            get { return theInstance; }
        }       
      
    }
}
