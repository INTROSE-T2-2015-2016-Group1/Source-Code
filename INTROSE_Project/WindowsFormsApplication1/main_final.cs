﻿using System;
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
                case "Search":                  formTypeCBox.SelectedIndex = 0;                         break;
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
            {
                MessageBox.Show("There are no supplier's in the supplier list in order create a new item", "ERROR"); 
            }                      
        }
        #endregion

        #region Company List
        private void clAddBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(clTxtBox.Text))
            {
                if (!CustomerManager.instance.pkExists(clTxtBox.Text))
                {
                    CustomerManager.instance.addData(clTxtBox.Text);
                    CustomerManager.instance.viewAll(clGridView);
                }
                else
                {
                    MessageBox.Show("Entered company already exists", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("You have not entered a company to be added", "ERROR");
            }           
        }
        #endregion

        #region Supplier List
        private void slAddBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(slTxtBox.Text))
            {
                if (!SupplierManager.instance.pkExists(slTxtBox.Text))
                {
                    SupplierManager.instance.addData(slTxtBox.Text);
                    SupplierManager.instance.viewAll(slGridView);
                }
                else
                {
                    MessageBox.Show("Entered company already exists", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("You have not entered a supplier to be added", "ERROR");
            }               
        }
        #endregion

        #region Customer PO
        private void cPOUpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void cPOAddBtn_Click(object sender, EventArgs e)
        {
            if (ItemManager.instance.getCount() > 0)
            {
                if (CustomerManager.instance.getCount() > 0)
                {
                    addCPO.instance.ShowDialog();
                    CustomerPOManager.instance.viewAll(cPOGridView);
                }
                else
                {
                    MessageBox.Show("There are no customers in the customer list in order to add a new customer PO", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("There are no items in the items list in order to add new customer purchase order", "ERROR");
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
                MessageBox.Show("No customer purchase order to view", "ERROR");
            }           
        }
        #endregion

        #region Supplier PO
        private void sPOUpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void sPOAddBtn_Click(object sender, EventArgs e)
        {
            if (CustomerOrderItemsManagercs.instance.getCount() > 0)
            {
                addSPO.instance.ShowDialog();
                SupplierPOManager.instance.viewAll(sPOGridView);
            }
            else
            {
                MessageBox.Show("There are no ordered items from any customer PO in order to add a new supplier PO", "ERROR");
            }           
        }

        private void sPOViewItemsBtn_Click(object sender, EventArgs e)
        {
            if (SupplierPOManager.instance.getCount() > 0)
            {
                viewSPOItems.instance.setPONumber(sPOGridView.Rows[sPOGridView.CurrentCell.RowIndex].Cells[0].Value.ToString(), sPOGridView.Rows[sPOGridView.CurrentCell.RowIndex].Cells[1].Value.ToString());
                viewSPOItems.instance.setSupplierName(sPOGridView.Rows[sPOGridView.CurrentCell.RowIndex].Cells[2].Value.ToString());
                viewSPOItems.instance.ShowDialog();
                SupplierPOManager.instance.viewAll(sPOGridView);
            }
            else
            {
                MessageBox.Show("There are no supplier purchase order's to view", "ERROR");
            }
        }
        #endregion

        #region Sales Invoice
        private void siUpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void siAddBtn_Click(object sender, EventArgs e)
        {
            if (DeliveryReceiptsManager.instance.getCount() > 0)
            {
                addSI.instance.ShowDialog();
                InvoicesManager.instance.viewAll(siGridView);
            }
            else
            {
                MessageBox.Show("There are no delivered items from any delivery receipts in order to add a new invoice", "ERROR");
            }
        }

        private void viewSI_ItemsBtn_Click(object sender, EventArgs e)
        {
            if (InvoicesManager.instance.getCount() > 0)
            {
                viewSI_Items.instance.setInvoiceNumber(siGridView.Rows[siGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
                viewSI_Items.instance.setDeliveryReceiptNumber(siGridView.Rows[siGridView.CurrentCell.RowIndex].Cells[1].Value.ToString());
                viewSI_Items.instance.ShowDialog();
                InvoicesManager.instance.viewAll(siGridView);
            }
            else
            {
                MessageBox.Show("There are no invoices to view", "ERROR");
            }
        }
        #endregion

        #region Delivery Receipt
        private void drUpdate_Click(object sender, EventArgs e)
        {

        }

        private void drAddBtn_Click(object sender, EventArgs e)
        {
            if (SupplierOrderItemsManager.instance.getCount() > 0)
            {
                addDR.instance.ShowDialog();
                DeliveryReceiptsManager.instance.viewAll(drGridView);
            }
            else
            {
                MessageBox.Show("There are no ordered items from any supplier PO in order to add a new delivery receipt", "ERROR");
            }
        }

        private void viewDRItemsBtn_Click(object sender, EventArgs e)
        {
            if (DeliveryReceiptsManager.instance.getCount() > 0)
            {
                viewDRItems.instance.setDeliveryReceiptNumber(drGridView.Rows[drGridView.CurrentCell.RowIndex].Cells[0].Value.ToString());
                viewDRItems.instance.setSupplierPONumber(drGridView.Rows[drGridView.CurrentCell.RowIndex].Cells[1].Value.ToString());
                viewDRItems.instance.ShowDialog();
                DeliveryReceiptsManager.instance.viewAll(drGridView);
            }
            else
            {
                MessageBox.Show("There are no delivery receipt to view", "ERROR");
            }
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

            switch (form)
            {
                case "items":
                keywordTypeCBox.Items.Add("default");
                keywordTypeCBox.Items.Add("item number");
                keywordTypeCBox.Items.Add("supplier name");
                keywordTypeCBox.Items.Add("description");
                break;
                case "customers":
                keywordTypeCBox.Items.Add("default");
                break;
                case "customer purchase order":
                keywordTypeCBox.Items.Add("default");
                keywordTypeCBox.Items.Add("customper po number");
                keywordTypeCBox.Items.Add("customer name");
                keywordTypeCBox.Items.Add("date issued");
                keywordTypeCBox.Items.Add("expected delivery date");
                break;
                case "customer order items":
                keywordTypeCBox.Items.Add("default");
                keywordTypeCBox.Items.Add("customer order id");
                keywordTypeCBox.Items.Add("customer po number");
                keywordTypeCBox.Items.Add("price per unit");
                break;
                case "suppliers":
                keywordTypeCBox.Items.Add("default");
                break;
                case "supplier purchase order":
                keywordTypeCBox.Items.Add("default");
                keywordTypeCBox.Items.Add("supplier po number");
                keywordTypeCBox.Items.Add("customer po number");
                keywordTypeCBox.Items.Add("supplier name");
                keywordTypeCBox.Items.Add("date issued");
                keywordTypeCBox.Items.Add("expected delivery date");
                break;
                case "supplier order items":
                keywordTypeCBox.Items.Add("default");
                keywordTypeCBox.Items.Add("supplier order id");
                keywordTypeCBox.Items.Add("supplier po number");
                keywordTypeCBox.Items.Add("item number");
                keywordTypeCBox.Items.Add("quantity");
                keywordTypeCBox.Items.Add("price per unit");
                keywordTypeCBox.Items.Add("total price");
                break;
                case "delivered receipts":
                keywordTypeCBox.Items.Add("default");
                keywordTypeCBox.Items.Add("delivery receipt number");
                keywordTypeCBox.Items.Add("supplier po number");
                keywordTypeCBox.Items.Add("date recieved");
                break;
                case "delivery items":
                keywordTypeCBox.Items.Add("default");
                keywordTypeCBox.Items.Add("delivery item id");
                keywordTypeCBox.Items.Add("delivery receipt number");
                keywordTypeCBox.Items.Add("supplier order id");
                keywordTypeCBox.Items.Add("delivered quantity");
                keywordTypeCBox.Items.Add("item number");
                keywordTypeCBox.Items.Add("approved quantity");
                keywordTypeCBox.Items.Add("rejected quantity");
                break;
                case "invoices":
                keywordTypeCBox.Items.Add("default");
                keywordTypeCBox.Items.Add("invoice number");
                keywordTypeCBox.Items.Add("delivery receipt number");
                keywordTypeCBox.Items.Add("date recieved");
                keywordTypeCBox.Items.Add("total price");
                break;
                case "invoice items":
                keywordTypeCBox.Items.Add("default");
                keywordTypeCBox.Items.Add("invoice item id");
                keywordTypeCBox.Items.Add("delivery item id");
                keywordTypeCBox.Items.Add("invoice number");
                keywordTypeCBox.Items.Add("customer order id");
                break;
            }

            keywordTypeCBox.SelectedIndex = 0;
        }

        private void editBtn_Click(object sender, EventArgs e)
        {

        }
        #endregion           

    }
}
