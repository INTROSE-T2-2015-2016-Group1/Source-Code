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

        private static addSPO theInstance = new addSPO();

        private addSPO()
        {
            InitializeComponent();
        }

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

        private void addSPOBtn_Click(object sender, EventArgs e)
        {
            if (CustomerOrderItemsManagercs.instance.getOrderCount(customerPONumberCBox.Text) > 0)
            {
                if (!SupplierPOManager.instance.pkExists(this.sPONumberTxtBox.Text))
                {
                    addSPOItems.instance.setAddType(true);
                    addSPOItems.instance.setSupplierName(supplierNameCBox.Text);
                    addSPOItems.instance.setPONumber(sPONumberTxtBox.Text, customerPONumberCBox.SelectedItem.ToString());
                    addSPOItems.instance.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Supplier purchase order number already exists");
                }
            }
            else
            {
                MessageBox.Show("No items ordered for the selected purchase order");
            }
        }

        public void addNewSPO()
        {
            SupplierPOManager.instance.addData(sPONumberTxtBox.Text, customerPONumberCBox.GetItemText(customerPONumberCBox.SelectedItem).Replace(" ", string.Empty), supplierNameCBox.SelectedItem.ToString(), dateIssuedCBox.Value.Date.ToShortDateString(), dateExpectedCBox.Value.Date.ToShortDateString());
        }

        public static addSPO instance
        {
            get { return theInstance; }
        }

    }
}
