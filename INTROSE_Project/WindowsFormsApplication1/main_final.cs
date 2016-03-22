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

        }

        private void editBtn_Click(object sender, EventArgs e)
        {

        }
        #endregion     

    }
}
