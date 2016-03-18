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
        public main()
        {
            InitializeComponent();
        }
        private void main_Load(object sender, EventArgs e)
        {

        }
        private void mainTab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Item Management
        private void imViewBtn_Click(object sender, EventArgs e)
        {
            ItemManager imManager = new ItemManager();

            imManager.viewAll(imGridView);
        }
        private void imUpdateBtn_Click(object sender, EventArgs e)
        {

        }
        private void imAddBtn_Click(object sender, EventArgs e)
        {
            addIM formAdd = new addIM();
            formAdd.ShowDialog();
        }
        //Company List
        private void clViewBtn_Click(object sender, EventArgs e)
        {
            CustomerManager clManager = new CustomerManager();
            clManager.viewAll(clGridView);
        }
        private void clAddBtn_Click(object sender, EventArgs e)
        {

        }
        //Supplier List
        private void slViewBtn_Click(object sender, EventArgs e)
        {
            SupplierManager slManager = new SupplierManager();

            slManager.viewAll(slGridView);
        }

        private void slAddBtn_Click(object sender, EventArgs e)
        {

        }  

        //Customer PO
        private void cPOViewBtn_Click(object sender, EventArgs e)
        {
            CustomerPOManager cPOManager = new CustomerPOManager();

            cPOManager.viewAll(cPOGridView);
        }

        private void cPOUpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void cPOAddBtn_Click(object sender, EventArgs e)
        {

        }

        //Supplier PO
        private void sPOViewBtn_Click(object sender, EventArgs e)
        {
            SupplierPOManager sPOManager = new SupplierPOManager();

            sPOManager.viewAll(sPOGridView);
        }

        private void sPOUpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void sPOAddBtn_Click(object sender, EventArgs e)
        {

        }

        //Sales Invoice
        private void siViewBtn_Click(object sender, EventArgs e)
        {
            InvoicesManager siPOManager = new InvoicesManager();

            siPOManager.viewAll(siGridView);
        }

        private void siUpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void siAddBtn_Click(object sender, EventArgs e)
        {

        }

        //Delivery Receipts
        private void drViewBtn_Click(object sender, EventArgs e)
        {
            DeliveryReceiptsManager drManager = new DeliveryReceiptsManager();

            drManager.viewAll(drGridView);
        }

        private void drUpdate_Click(object sender, EventArgs e)
        {

        }

        private void drAddBtn_Click(object sender, EventArgs e)
        {

        }

        //Search
        private void searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void editBtn_Click(object sender, EventArgs e)
        {

        }      

    }
}
