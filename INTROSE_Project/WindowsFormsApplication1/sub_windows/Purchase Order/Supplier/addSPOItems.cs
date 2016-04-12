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
        #region Variables
        private static addSPOItems theInstance = new addSPOItems();

        private Boolean addType = false; //false means add item ONLY, true means add item with new PO
        private String supplierPONumber;
        private String supplierName;
        private String customerPONumber;

        private int quantity;
        private double pricePerUnit;
        private double totalPrice;
        #endregion

        private addSPOItems()
        {
            InitializeComponent();
        }

        #region Event Handlers
        private void addSPOItems_Load(object sender, EventArgs e)
        {
            CustomerOrderItemsManagercs.instance.getOrderItems(itemDescCBox, this.customerPONumber, this.supplierName);
            if (itemDescCBox.Items.Count > 0)
            {
                itemDescCBox.SelectedIndex = 0;
                currencyCBox.SelectedIndex = 0;
            }
            else
            {
                this.Close();
                MessageBox.Show("Unable to add a new item to supplier PO: All orders from the related customer PO's are finished", "ERROR");               
            }            
        }

        private void itemQtyTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(itemQtyTxtBox.Text, out quantity) && double.TryParse(pricePerUnitTxtBox.Text, out pricePerUnit))
            {
                totalPriceLabel.Text = (quantity * pricePerUnit).ToString();
            }
            else
            {
                totalPriceLabel.Text = "";
            }
        }

        private void pricePerUnitTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(itemQtyTxtBox.Text, out quantity) && double.TryParse(pricePerUnitTxtBox.Text, out pricePerUnit))
            {
                totalPriceLabel.Text = (quantity * pricePerUnit).ToString();
            }
            else
            {
                totalPriceLabel.Text = "";
            }
        }
        #endregion

        #region Setters
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
        #endregion

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

        #region Button Click Events
        private void addCPOItemsBtn_Click(object sender, EventArgs e)
        {
            int itemNumber = ItemManager.instance.getItemNumber(itemDescCBox.SelectedItem.ToString(), this.supplierName);

            if (((!SupplierPOManager.instance.pkExists(this.supplierPONumber) && addType) || (SupplierPOManager.instance.pkExists(this.supplierPONumber) && !addType))
                && !SupplierOrderItemsManager.instance.isItemExists(itemNumber, this.supplierPONumber) 
                && double.TryParse(totalPriceLabel.Text, out totalPrice)) //checks if total price is valid
            {
                if (addType)
                {
                    addSPO.instance.addNewSPO();
                }

                SupplierOrderItemsManager.instance.addData(this.supplierPONumber,
                                                           itemNumber,
                                                           Convert.ToInt32(itemQtyTxtBox.Text),
                                                           currencyCBox.SelectedItem.ToString(),
                                                           double.Parse(pricePerUnitTxtBox.Text),
                                                           totalPrice);

                SupplierPOManager.instance.setPONotFinished(this.supplierPONumber);

                pricePerUnitTxtBox.Text = "";
                itemQtyTxtBox.Text = "";
                totalPriceLabel.Text = "";

                this.Close();
            }
            else
            {
                MessageBox.Show("The item/PO you are trying to add already exists or the entered values are missing/incorrect", "ERROR");
            }
        }
        #endregion

        public static addSPOItems instance
        {
            get { return theInstance; }
        }
     
    }
}
