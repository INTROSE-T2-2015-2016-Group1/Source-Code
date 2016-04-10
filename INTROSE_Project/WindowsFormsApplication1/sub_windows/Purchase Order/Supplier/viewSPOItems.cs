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
        #region Variables
        private static viewSPOItems theInstance = new viewSPOItems();

        private string supplierPONumber;
        private string customerPONumber;
        private string supplierName;
        #endregion

        private viewSPOItems()
        {
            InitializeComponent();
        }

        #region Event Handlers
        private void viewSPOItems_Load(object sender, EventArgs e)
        {
            SupplierOrderItemsManager.instance.viewAll(this.supplierPONumber, cPOItemsGridView);
        }
        #endregion

        #region Setters
        public void setPONumber(string supplierPONumber, string customerPONumber)
        {
            this.supplierPONumber = supplierPONumber;
            this.customerPONumber = customerPONumber;
        }

        public void setSupplierName(string supplierName)
        {
            this.supplierName = supplierName;
        }
        #endregion

        #region Button Click Events
        private void addSPOItemsBtn_Click(object sender, EventArgs e)
        {
            if (CustomerOrderItemsManagercs.instance.getCount() > 0)
            {
                addSPOItems.instance.setAddType(false);
                addSPOItems.instance.setPONumber(this.supplierPONumber, this.customerPONumber);
                addSPOItems.instance.setSupplierName(this.supplierName);
                addSPOItems.instance.ShowDialog();
                SupplierOrderItemsManager.instance.viewAll(this.supplierPONumber, cPOItemsGridView);
            }
            else
            {
                MessageBox.Show("There are no ordered items from any customer PO to add a new item to a supplier PO", "ERROR");
            }
                
        }
        #endregion

        public static viewSPOItems instance
        {
            get { return theInstance; }
        }      
    
    }
}
