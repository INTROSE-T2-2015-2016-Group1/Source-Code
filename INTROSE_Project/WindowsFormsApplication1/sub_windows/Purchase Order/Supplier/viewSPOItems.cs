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

namespace introse_project.sub_windows.Purchase_Order.Supplier
{
    public partial class viewSPOItems : Form
    {
        private static viewSPOItems theInstance = new viewSPOItems();

        private string  supplierPONumber;
        private string supplierName;

        private viewSPOItems()
        {
            InitializeComponent();
        }

        private void viewSPOItems_Load(object sender, EventArgs e)
        {
            SupplierOrderItemsManager.instance.viewAll(this.supplierPONumber, cPOItemsGridView);
        }

        public void setPONumber(string supplierPONumber)
        {
            this.supplierPONumber = supplierPONumber;
        }

        public void setSupplierName(string supplierName)
        {
            this.supplierName = supplierName;
        }

        private void addSPOItemsBtn_Click(object sender, EventArgs e)
        {
            addSPOItems.instance.setAddType(false);
            addSPOItems.instance.setPONumber(this.supplierPONumber, "");
            addSPOItems.instance.setSupplierName(this.supplierName);
            addSPOItems.instance.ShowDialog();
            this.Close();
            SupplierOrderItemsManager.instance.viewAll(this.supplierPONumber, cPOItemsGridView);
        }

        public static viewSPOItems instance
        {
            get { return theInstance; }
        }      
    
    }
}
