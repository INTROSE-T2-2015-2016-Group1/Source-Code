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

namespace introse_project.sub_windows.Delivery_Receipt
{
    public partial class addDRItems : Form
    {
        #region Variables
        private static addDRItems theInstance = new addDRItems();

        private string deliveryReceiptNumber;
        private string supplierPONumber;
        private bool addType;
        int quantityReceived;
        #endregion

        private addDRItems()
        {
            InitializeComponent();
        }

        #region Setters
        public void setDeliveryReceiptNumber(string deliveryReceiptNumber)
        {
            this.deliveryReceiptNumber = deliveryReceiptNumber;
        }

        public void setSupplierPONumber(string supplierPONumber)
        {
            this.supplierPONumber = supplierPONumber;
        }

        public void setAddType(bool addType)
        {
            this.addType = addType;
        }
        #endregion

        #region Keypress Event Handlers
        private void quantityReceivedTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Event Handlers
        private void addDRItems_Load(object sender, EventArgs e)
        {
            SupplierOrderItemsManager.instance.getOrderItems(supplierOrderedItemCBox, supplierPONumber);
            if (supplierOrderedItemCBox.Items.Count > 0)
            {
                supplierOrderedItemCBox.SelectedIndex = 0;
            }
            else
            {
                this.Close();
                MessageBox.Show("All ordered items for the selected PO is finished. Cannot add any more deliveries.", "ERROR");
            }
            
        }
        #endregion

        #region Button Click Events
        private void addDRBtn_Click(object sender, EventArgs e)
        {
            string supplierName = SupplierPOManager.instance.getSupplierName(this.supplierPONumber);
            int itemNumber = ItemManager.instance.getItemNumber(supplierOrderedItemCBox.SelectedItem.ToString(), supplierName);
            int supplierOrderID = SupplierOrderItemsManager.instance.itemOrderedID(itemNumber, this.supplierPONumber);

            if (((!DeliveryReceiptsManager.instance.pkExists(this.deliveryReceiptNumber) && addType) || (DeliveryReceiptsManager.instance.pkExists(this.deliveryReceiptNumber) && !addType))
                && int.TryParse(quantityReceivedTxtBox.Text, out quantityReceived))
            {
                if (SupplierOrderItemsManager.instance.getQuantityOrdered(supplierOrderID) >= quantityReceived + DeliveryItemsManager.instance.getTotalApprovedQuantity(supplierOrderID))
                {
                    if (addType)
                    {
                        addDR.instance.addNewDR();
                    }

                    DeliveryItemsManager.instance.addData(itemNumber, this.deliveryReceiptNumber,
                                                          supplierOrderID,
                                                          quantityReceived);

                    quantityReceivedTxtBox.Text = "";

                    this.Close();
                }
                else
                {
                    MessageBox.Show("The delivered item quantity cannot be larger than the ordered item quantity", "ERROR");
                }                  
            }
            else
            {
                MessageBox.Show("The delivered item you're trying to add is not valid or the delivery receipt already exists!", "ERROR");
            }                  
            
        }
        #endregion

        public static addDRItems instance
        {
            get { return theInstance; }
        }
     
    }
}
