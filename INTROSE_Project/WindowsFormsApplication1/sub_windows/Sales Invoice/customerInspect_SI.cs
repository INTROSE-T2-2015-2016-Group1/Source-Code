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

namespace introse_project.sub_windows.Sales_Invoice
{
    public partial class customerInspect_SI : Form
    {
        private static customerInspect_SI theInstance = new customerInspect_SI();
        private int customerOrderID;
        private int invoiceItemID;

        private customerInspect_SI()
        {
            InitializeComponent();
        }

        private void customerInspect_SI_Load(object sender, EventArgs e)
        {
            approvedQtyTxtBox_U.Text = InvoicesItemsManager.instance.getApprovedQuantity(this.customerOrderID).ToString();
            rejectedQtyTxtBox_U.Text = InvoicesItemsManager.instance.getRejectedQuantity(this.customerOrderID).ToString();
        } 


        public void setCustomerOrderID(int customerOrderID)
        {
            this.customerOrderID = customerOrderID;
        }

        public void setInvoiceItemID(int invoiceItemID)
        {
            this.invoiceItemID = invoiceItemID;
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

        private void updateSI_CIRBtn_Click(object sender, EventArgs e)
        {
            InvoicesItemsManager.instance.updateData(this.invoiceItemID,Convert.ToInt32(approvedQtyTxtBox_U.Text), Convert.ToInt32(rejectedQtyTxtBox_U.Text));
            CustomerOrderItemsManagercs.instance.updateFinished(this.customerOrderID);
        }
      
        public static customerInspect_SI instance
        {
            get { return theInstance; }
        }  
  
    }
}
