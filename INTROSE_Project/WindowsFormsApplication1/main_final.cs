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

using introse_project.sub_windows.Item_Management;
using introse_project.sub_windows.Purchase_Order.Customer;
using introse_project.sub_windows.Purchase_Order.Supplier;
using introse_project.sub_windows.Delivery_Receipt;
using introse_project.sub_windows.Sales_Invoice;
using introse_project.sub_windows.Purchase_Order;

namespace introse_project
{
    public partial class main : Form
    {
        #region Intializing Functions
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            ItemManager.instance.viewAll(imGridView);
        }
        #endregion

        #region Event Handlers
        private void mainTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (mainTab.SelectedTab.Text)
            {
                case "Item Management":         ItemManager.instance.viewAll(imGridView);               break;
                case "Company List":            CustomerManager.instance.viewAll(clGridView);           break;
                case "Supplier List":           SupplierManager.instance.viewAll(slGridView);           break;
                case "Customer Purchase Order": CustomerPOManager.instance.viewAll(cPOGridView);        break;
                case "Supplier Purchase Order": SupplierPOManager.instance.viewAll(sPOGridView);        break;
                case "Sales Invoice":           InvoicesManager.instance.viewAll(siGridView);           break;
                case "Delivery Receipt":        DeliveryReceiptsManager.instance.viewAll(drGridView);   break;
                case "Search":                  formTypeCBox.SelectedIndex = 0;
                                                keywordTypeCBox.SelectedIndex = 0;                      break;
            }
        }
        #endregion

        #region Item List
        private void imUpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void imAddBtn_Click(object sender, EventArgs e)
        {
            if (SupplierManager.instance.getCount() > 0)
            {
                addIM.instance.ShowDialog();
                ItemManager.instance.viewAll(imGridView);
            }
            else
                MessageBox.Show("No supplier's available for input");           
        }
        #endregion

        #region Company List
        private void clAddBtn_Click(object sender, EventArgs e)
        {
            CustomerManager.instance.addData(clTxtBox.Text);
            CustomerManager.instance.viewAll(clGridView);
        }
        #endregion

        #region Supplier List
        private void slAddBtn_Click(object sender, EventArgs e)
        {
            SupplierManager.instance.addData(slTxtBox.Text);
            SupplierManager.instance.viewAll(slGridView);
        }
        #endregion

        #region Customer PO
        private void cPOUpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void cPOAddBtn_Click(object sender, EventArgs e)
        {
            if (CustomerManager.instance.getCount() > 0)
            {
                addCPO.instance.ShowDialog();
                CustomerPOManager.instance.viewAll(cPOGridView);    
            }
            else
            {
                MessageBox.Show("No customers to add a purchase order to");
            }
        }

        private void cPOViewItemsBtn_Click(object sender, EventArgs e)
        {
            if (CustomerPOManager.instance.getCount() > 0)
            {
                viewCPOItems.instance.setPONUmber(cPOGridView.Rows[cPOGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
                viewCPOItems.instance.ShowDialog();
                CustomerPOManager.instance.viewAll(cPOGridView);
            }
            else
            {
                MessageBox.Show("No customer purchase order to view");
            }           
        }
        #endregion

        #region Supplier PO
        private void sPOUpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void sPOAddBtn_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Sales Invoice
        private void siUpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void siAddBtn_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Delivery Receipt
        private void drUpdate_Click(object sender, EventArgs e)
        {

        }

        private void drAddBtn_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Search
        private void searchBtn_Click(object sender, EventArgs e)
        {
            string capturedKeyword = keywordTxtBox.Text;
            string capturedKeyType;
            if (keywordTypeCBox.Text == "")
                capturedKeyType = "All Columns";
            else
                capturedKeyType = keywordTypeCBox.Text;
            string capturedFormType = formTypeCBox.Text;

            SearchManager.instance.searchForm(searchGridView, capturedFormType, capturedKeyType, capturedKeyword);
            //MessageBox.Show(capturedFormType + " " + capturedKeyword);
        }

        //Roi Emmanuel Vivo: added this function to update keyword type ComboBox in Search Tab
        private void formTypeCBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            keywordTypeCBox.Items.Clear();
            string form = (string)formTypeCBox.SelectedItem;

            keywordTypeCBox.Items.Add("All Columns");

            switch(form)
            {
                case "customer_inspection_results":
                    keywordTypeCBox.Items.Add("invoiceItemID");
                    keywordTypeCBox.Items.Add("approvedQuantity");
                    keywordTypeCBox.Items.Add("rejectedQuantity");
                    break;
                case "customer_order_items":
                    keywordTypeCBox.Items.Add("customerOrderID");
                    keywordTypeCBox.Items.Add("customerPONumber");
                    keywordTypeCBox.Items.Add("itemNumber");
                    keywordTypeCBox.Items.Add("quantity");
                    keywordTypeCBox.Items.Add("currency");
                    keywordTypeCBox.Items.Add("pricePerUnit");
                    keywordTypeCBox.Items.Add("totalPrice");
                    keywordTypeCBox.Items.Add("isFinished");
                    break;
                case "customer_po":
                    keywordTypeCBox.Items.Add("customerPONumber");
                    keywordTypeCBox.Items.Add("customerName");
                    keywordTypeCBox.Items.Add("dateIssued");
                    keywordTypeCBox.Items.Add("expectedDeliveryDate");
                    keywordTypeCBox.Items.Add("isFinished");
                    break;
                case "customers":
                    keywordTypeCBox.Items.Add("customerName");
                    break;
                case "delivered_items":
                    keywordTypeCBox.Items.Add("deliveryItemID");
                    keywordTypeCBox.Items.Add("deliveryReceiptNumber");
                    keywordTypeCBox.Items.Add("supplierOrderID");
                    keywordTypeCBox.Items.Add("deliveredQuantity");
                    break;
                case "delivery_receipts":
                    keywordTypeCBox.Items.Add("deliveryReceiptNumber");
                    keywordTypeCBox.Items.Add("supplierPONumber");
                    keywordTypeCBox.Items.Add("dateReceived");
                    break;
                case "godo_inspection_results":
                    keywordTypeCBox.Items.Add("deliveryItemID");
                    keywordTypeCBox.Items.Add("approvedQuantity");
                    keywordTypeCBox.Items.Add("rejectedQuantity");
                    break;
                case "invoice_items":
                    keywordTypeCBox.Items.Add("invoiceItemID");
                    keywordTypeCBox.Items.Add("deliveryItemID");
                    keywordTypeCBox.Items.Add("invoiceNumber");
                    keywordTypeCBox.Items.Add("customerOrderID");
                    keywordTypeCBox.Items.Add("deliveredQuantity");
                    break;
                case "invoices":
                    keywordTypeCBox.Items.Add("invoiceNumber");
                    keywordTypeCBox.Items.Add("deliveredReceiptNumber");
                    keywordTypeCBox.Items.Add("customerPONumber");
                    keywordTypeCBox.Items.Add("dateReceived");
                    keywordTypeCBox.Items.Add("invoiceTotalPrice");
                    break;
                case "items":
                    keywordTypeCBox.Items.Add("itemNumber");
                    keywordTypeCBox.Items.Add("supplierName");
                    keywordTypeCBox.Items.Add("description");
                    break;
                case "supplier_order_items":
                    keywordTypeCBox.Items.Add("supplierOrderID");
                    keywordTypeCBox.Items.Add("supplierPONumber");
                    keywordTypeCBox.Items.Add("itemNumber");
                    keywordTypeCBox.Items.Add("quantity");
                    keywordTypeCBox.Items.Add("currency");
                    keywordTypeCBox.Items.Add("pricePerUnit");
                    keywordTypeCBox.Items.Add("totalPrice");
                    keywordTypeCBox.Items.Add("isFinished");
                    break;
                case "supplier_po":
                    keywordTypeCBox.Items.Add("supplierPONumber");
                    keywordTypeCBox.Items.Add("customerPONumber");
                    keywordTypeCBox.Items.Add("supplierName");
                    keywordTypeCBox.Items.Add("dateIssued");
                    keywordTypeCBox.Items.Add("expectedDeliveryDate");
                    keywordTypeCBox.Items.Add("isFinished");
                    break;
                case "suppliers":
                    keywordTypeCBox.Items.Add("supplierName");
                    break;
            }

            keywordTypeCBox.SelectedIndex = 0;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {

        }
        #endregion     

        private void searchGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
