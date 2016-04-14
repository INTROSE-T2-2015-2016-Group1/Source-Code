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
    public partial class viewDRItems : Form
    {
        private static viewDRItems theInstance = new viewDRItems();
        private string deliveryReceiptNumber;
        private string supplierPONumber;
        
        private viewDRItems()
        {
            InitializeComponent();
        }

        private void viewDRItems_Load(object sender, EventArgs e)
        {
            DeliveryItemsManager.instance.viewAll(deliveryReceiptNumber, DR_ItemsGridView);
        }

        public void setDeliveryReceiptNumber(string deliveryReceiptNumber)
        {
            this.deliveryReceiptNumber = deliveryReceiptNumber;
        }

        public void setSupplierPONumber(string supplierPONumber)
        {
            this.supplierPONumber = supplierPONumber;
        }

        private void addDRItemsBtn_Click(object sender, EventArgs e)
        {
            addDRItems.instance.setAddType(false);
            addDRItems.instance.setDeliveryReceiptNumber(this.deliveryReceiptNumber);
            addDRItems.instance.setSupplierPONumber(this.supplierPONumber);           
            addDRItems.instance.ShowDialog();
            DeliveryItemsManager.instance.viewAll(deliveryReceiptNumber, DR_ItemsGridView);
        }

        private void godoInspectionResultsBtn_Click(object sender, EventArgs e)
        {
            godoInspect_DR.instance.setDeliveryItemID(Convert.ToInt32(DR_ItemsGridView.Rows[DR_ItemsGridView.CurrentCell.RowIndex].Cells["Delivery Item ID"].Value.ToString()));
            godoInspect_DR.instance.setSupplierOrderID(Convert.ToInt32(DR_ItemsGridView.Rows[DR_ItemsGridView.CurrentCell.RowIndex].Cells["Supplier Order ID"].Value.ToString()));
            godoInspect_DR.instance.setDeliveryReciptNumber(this.deliveryReceiptNumber);
            godoInspect_DR.instance.ShowDialog();
            if (SupplierOrderItemsManager.instance.isOrdersDone(this.supplierPONumber))
            {
                SupplierPOManager.instance.setPOFinished(this.supplierPONumber);
            }
        }    

        public static viewDRItems instance
        {
            get { return theInstance; }
        }
       
    }
}
