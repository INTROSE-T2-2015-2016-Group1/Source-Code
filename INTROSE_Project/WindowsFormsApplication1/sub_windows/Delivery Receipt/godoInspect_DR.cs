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
    public partial class godoInspect_DR : Form
    {
        #region Variables
        private static godoInspect_DR theInstance = new godoInspect_DR();
        private int deliveryItemID;
        private int supplierOrderID;
        #endregion

        private godoInspect_DR()
        {
            InitializeComponent();
        }

        #region Event Handlers
        private void godoInspect_DR_Load(object sender, EventArgs e)
        {
            approvedQtyTxtBox_U.Text = DeliveryItemsManager.instance.getApprovedQuantity(this.deliveryItemID).ToString();
            rejectedQtyTxtBox_U.Text = DeliveryItemsManager.instance.getRejectedQuantity(this.deliveryItemID).ToString();
        }
        #endregion

        #region Setters
        public void setDeliveryItemID(int deliveryItemID)
        {
            this.deliveryItemID = deliveryItemID;
        }

        public void setSupplierOrderID(int supplierOrderID)
        {
            this.supplierOrderID = supplierOrderID;
        }
        #endregion

        #region Key Press Event Handlers
        private void approvedQtyTxtBox_U_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void rejectedQtyTxtBox_U_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Button Click Events
        private void updateDR_GIRBtn_Click(object sender, EventArgs e)
        {
            DeliveryItemsManager.instance.updateData(this.deliveryItemID, Convert.ToInt32(approvedQtyTxtBox_U.Text), Convert.ToInt32(rejectedQtyTxtBox_U.Text));
            SupplierOrderItemsManager.instance.updateFinished(this.supplierOrderID);        
        }
        #endregion

        public static godoInspect_DR instance
        {
            get { return theInstance; }
        }         
        
    }
}
