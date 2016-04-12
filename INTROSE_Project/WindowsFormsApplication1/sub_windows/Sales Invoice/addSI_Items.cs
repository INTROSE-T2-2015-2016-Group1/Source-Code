﻿    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using introse_project.Libs;

namespace introse_project.sub_windows.Sales_Invoice
{
    public partial class addSI_Items : Form
    {
        #region Variables
        private static addSI_Items theInstance = new addSI_Items();
        
        private string invoiceNumber;
        private string deliveryReceiptNumber;
        private string customerPONumber;
        private bool addType = false;
        #endregion

        private addSI_Items()
        {
            InitializeComponent();
        }

        #region Setters
        public void setInvoiceNumber(string invoiceNumber)
        {
            this.invoiceNumber = invoiceNumber;
        }

        public void setDeliveryReceiptNumber(string deliveryReceiptNumber)
        {
            this.deliveryReceiptNumber = deliveryReceiptNumber;
        }

        public void setAddType(bool addType)
        {
            this.addType = addType;
        }

        public void setCustomerPONumber(string customerPONumber)
        {
            this.customerPONumber = customerPONumber;
        }
        #endregion

        #region Event Handlers
        private void addSI_Items_Load(object sender, EventArgs e)
        {
            DeliveryItemsManager.instance.fillComboBox(deliveryItemCBox, this.deliveryReceiptNumber);
            deliveryItemCBox.SelectedIndex = 0;
        }
        #endregion

        #region Keypress Event Handlers
        private void deliveredQtyTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Button Click Events
        private void addSI_ItemsBtn_Click(object sender, EventArgs e)
        {
            

            string customerPONumber = SupplierPOManager.instance.getCustomerPONumber(DeliveryReceiptsManager.instance.getSupplierPONumber(this.deliveryReceiptNumber));
            int itemNumber = DeliveryItemsManager.instance.getOrderedItemID(deliveryItemCBox.SelectedItem.ToString(), this.deliveryReceiptNumber);
            int customerOrderID = CustomerOrderItemsManagercs.instance.getOrderID(customerPONumber, deliveryItemCBox.SelectedItem.ToString());
            int deliveryItemID = DeliveryItemsManager.instance.itemOrderedID(itemNumber, deliveryReceiptNumber);
            int deliveredQuantity = Convert.ToInt32(deliveredQtyTxtBox.Text);
            double itemPrice = CustomerOrderItemsManagercs.instance.getItemPricePerUnit(customerOrderID) * deliveredQuantity;

            if ((!InvoicesItemsManager.instance.isItemExists(itemNumber, invoiceNumber) && addType) || (InvoicesItemsManager.instance.isItemExists(itemNumber, invoiceNumber) && !addType))
            {
                if (addType)
                {
                    addSI.instance.addNewSI();
                }

                InvoicesItemsManager.instance.addData(this.invoiceNumber, deliveryItemID, customerOrderID, itemNumber, itemPrice, deliveredQuantity);
            }
            else
            {
                MessageBox.Show("The item you're trying to add already exists!", "ERROR");
            }
                       
            this.Close();
        }
        #endregion

        public static addSI_Items instance
        {
            get { return theInstance; }
        }

        
    
    }
}
