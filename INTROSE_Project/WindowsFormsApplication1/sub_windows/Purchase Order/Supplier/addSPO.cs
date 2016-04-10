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
    public partial class addSPO : Form
    {

        #region Variables
        private static addSPO theInstance = new addSPO();
        #endregion

        private addSPO()
        {
            InitializeComponent();
        }

        #region Event Handlers
        private void addSPO_Load(object sender, EventArgs e)
        {
            CustomerPOManager.instance.fillComboBox(customerPONumberCBox);
            customerPONumberCBox.SelectedIndex = 0;
        }

        private void customerPOIdCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerOrderItemsManagercs.instance.getPossibleSuppliers(supplierNameCBox, customerPONumberCBox.Text);
            supplierNameCBox.SelectedIndex = 0;
        }
        #endregion

        #region Button Click Events
        private void addSPOBtn_Click(object sender, EventArgs e)
        {
            if (!SupplierPOManager.instance.pkExists(this.sPONumberTxtBox.Text) && !String.IsNullOrWhiteSpace(sPONumberTxtBox.Text))
            {
                if (dateIssuedCBox.Value <= dateExpectedCBox.Value)
                {
                    addSPOItems.instance.setAddType(true);
                    addSPOItems.instance.setSupplierName(supplierNameCBox.Text);
                    addSPOItems.instance.setPONumber(sPONumberTxtBox.Text, customerPONumberCBox.SelectedItem.ToString());
                    addSPOItems.instance.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Date issued cannot be after the expected date", "ERROR");
                } 
            }
            else
            {
                MessageBox.Show("Supplier purchase order number already exists or entered the PO number is invalid/missing", "ERROR");
            }
        }
        #endregion

        public void addNewSPO()
        {
            SupplierPOManager.instance.addData(sPONumberTxtBox.Text, customerPONumberCBox.GetItemText(customerPONumberCBox.SelectedItem).Replace(" ", string.Empty), supplierNameCBox.SelectedItem.ToString(), dateIssuedCBox.Value.Date.ToShortDateString(), dateExpectedCBox.Value.Date.ToShortDateString());
            sPONumberTxtBox.Text = "";
            dateExpectedCBox.Value = DateTime.Now;
            dateIssuedCBox.Value = DateTime.Now;
        }

        public static addSPO instance
        {
            get { return theInstance; }
        }

    }
}
