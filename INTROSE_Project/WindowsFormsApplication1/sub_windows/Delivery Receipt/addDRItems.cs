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
        private static addDRItems theInstance = new addDRItems();
        private string deliveryReceiptNumber;
        private string supplierPONumber;
        private bool addType;

        private addDRItems()
        {
            InitializeComponent();
        }

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

        private void quantityReceivedTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void addDRItems_Load(object sender, EventArgs e)
        {
            SupplierOrderItemsManager.instance.getOrderItems(supplierOrderedItemCBox, supplierPONumber);
            supplierOrderedItemCBox.SelectedIndex = 0;
        }

        private void addDRBtn_Click(object sender, EventArgs e)
        {
            if (addType)
            {
                addDR.instance.addNewDR();
            }

            string supplierName = SupplierPOManager.instance.getSupplierName(this.supplierPONumber);
            int itemNumber = ItemManager.instance.getItemNumber(supplierOrderedItemCBox.SelectedItem.ToString(), supplierName);

            if (!DeliveryItemsManager.instance.isItemExists(itemNumber, this.deliveryReceiptNumber))
            {
                int supplierOrderID = SupplierOrderItemsManager.instance.itemOrderedID(itemNumber, this.supplierPONumber);
                DeliveryItemsManager.instance.addData(itemNumber, this.deliveryReceiptNumber,
                                                      supplierOrderID,
                                                      Convert.ToInt32(quantityReceivedTxtBox.Text));
            }
            else
            {
                MessageBox.Show("The item you're trying to add already exists!", "ERROR");
            }
                      
            this.Close();
        }

        public static addDRItems instance
        {
            get { return theInstance; }
        }
     
    }
}
