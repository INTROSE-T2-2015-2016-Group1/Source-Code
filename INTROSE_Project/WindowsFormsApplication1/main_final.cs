using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using introse_project.sub_windows.Delivery_Receipt;
using introse_project.sub_windows.Purchase_Order;

using introse_project.sub_windows.Sales_Invoice;
using introse_project.Libs;
using introse_project.sub_windows.Item_Management;

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
            addIM formAdd = new addIM();
            formAdd.ShowDialog();
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
