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
    public partial class addDR : Form
    {
        private static addDR theInstance = new addDR();

        private addDR()
        {
            InitializeComponent();
        }

        private void addDR_Load(object sender, EventArgs e)
        {
            SupplierPOManager.instance.fillComboBox(supplierPOIdCBox);
            supplierPOIdCBox.SelectedIndex = 0;
        }

        private void addDRBtn_Click(object sender, EventArgs e)
        {       
            if (SupplierOrderItemsManager.instance.getCount() > 0)
            {
                if (!DeliveryReceiptsManager.instance.pkExists(deliveryReceiptNumberTxtBox.Text))
                {
                    addDRItems.instance.setAddType(true);
                    addDRItems.instance.setDeliveryReceiptNumber(deliveryReceiptNumberTxtBox.Text);
                    addDRItems.instance.setSupplierPONumber(supplierPOIdCBox.SelectedItem.ToString());
                    addDRItems.instance.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Delivery receipt number already exists", "ERROR");
                }             
            }
            else
            {
                MessageBox.Show("No items ordered from any supplier PO to add to delivery receipts");
            }
        }

        public void addNewDR()
        {
            DeliveryReceiptsManager.instance.addData(deliveryReceiptNumberTxtBox.Text,
                                                     supplierPOIdCBox.SelectedItem.ToString(),
                                                     dateIssuedCBox.Value.Date.ToShortDateString());
        }

        public static addDR instance
        {
            get { return theInstance; }
        }

    }
}
