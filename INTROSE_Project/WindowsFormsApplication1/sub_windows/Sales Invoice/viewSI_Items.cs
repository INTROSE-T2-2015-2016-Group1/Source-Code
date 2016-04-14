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
    public partial class viewSI_Items : Form
    {
        #region Variables
        private static viewSI_Items theInstance = new viewSI_Items();
        private string invoiceNumber;
        private string deliveryReceiptNumber;
        #endregion

        private viewSI_Items()
        {
            InitializeComponent();
        }

        #region Event Handlers
        private void viewSI_Items_Load(object sender, EventArgs e)
        {
            InvoicesItemsManager.instance.viewAll(invoiceNumber, SI_ItemsGridView);
        }
        #endregion

        #region Setters
        public void setInvoiceNumber(string invoiceNumber)
        {
            this.invoiceNumber = invoiceNumber;
        }

        public void setDeliveryReceiptNumber(string deliveryReceiptNumber)
        {
            this.deliveryReceiptNumber = deliveryReceiptNumber;
        }
        #endregion

        #region Button Click Events
        private void addSI_ItemsBtn_Click_1(object sender, EventArgs e)
        {
            addSI_Items.instance.setAddType(false);
            addSI_Items.instance.setInvoiceNumber(this.invoiceNumber);
            addSI_Items.instance.setDeliveryReceiptNumber(this.deliveryReceiptNumber);
            addSI_Items.instance.ShowDialog();
            InvoicesItemsManager.instance.viewAll(invoiceNumber, SI_ItemsGridView);
        }
        
        private void customerInspectionResultsBtn_Click(object sender, EventArgs e)
        {
            customerInspect_SI.instance.setInvoiceItemID(Convert.ToInt32(SI_ItemsGridView.Rows[SI_ItemsGridView.CurrentCell.RowIndex].Cells["Invoice Item ID"].Value.ToString()));
            customerInspect_SI.instance.setCustomerOrderID(Convert.ToInt32(SI_ItemsGridView.Rows[SI_ItemsGridView.CurrentCell.RowIndex].Cells["Customer Order ID"].Value.ToString()));          
            customerInspect_SI.instance.ShowDialog();

            string customerPONumber = SupplierPOManager.instance.getCustomerPONumber(DeliveryReceiptsManager.instance.getSupplierPONumber(this.deliveryReceiptNumber));
            
            if (CustomerOrderItemsManagercs.instance.isOrdersDone(customerPONumber))
            {
                CustomerPOManager.instance.setPOFinished(customerPONumber);
            }
        }
        #endregion

        public static viewSI_Items instance
        {
            get { return theInstance; }
        }

    }
}
