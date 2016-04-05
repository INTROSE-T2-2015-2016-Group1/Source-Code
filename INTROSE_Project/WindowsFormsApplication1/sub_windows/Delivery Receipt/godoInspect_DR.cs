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
        private static godoInspect_DR theInstance = new godoInspect_DR();
        private int deliveryItemID;
        private int supplierOrderID;

        private godoInspect_DR()
        {
            InitializeComponent();
        }

        private void godoInspect_DR_Load(object sender, EventArgs e)
        {
            if (!GodoInspectionManager.instance.isExists(this.deliveryItemID))
            {
                GodoInspectionManager.instance.addData(this.deliveryItemID);
            }
            approvedQtyTxtBox_U.Text = GodoInspectionManager.instance.getApprovedQuantity(this.deliveryItemID).ToString();
            rejectedQtyTxtBox_U.Text = GodoInspectionManager.instance.getRejectedQuantity(this.deliveryItemID).ToString();
        }

        public void setDeliveryItemID(int deliveryItemID)
        {
            this.deliveryItemID = deliveryItemID;
        }

        public void setSupplierOrderID(int supplierOrderID)
        {
            this.supplierOrderID = supplierOrderID;
        }

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

        private void updateDR_GIRBtn_Click(object sender, EventArgs e)
        {
            GodoInspectionManager.instance.updateData(this.deliveryItemID, Convert.ToInt32(approvedQtyTxtBox_U.Text), Convert.ToInt32(rejectedQtyTxtBox_U.Text));
            SupplierOrderItemsManager.instance.updateFinished(this.supplierOrderID);
        }   

        public static godoInspect_DR instance
        {
            get { return theInstance; }
        }         
        
    }
}
