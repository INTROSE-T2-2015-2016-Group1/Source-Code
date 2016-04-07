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

namespace introse_project.sub_windows.Sales_Invoice
{
    public partial class addSI : Form
    {
        private static addSI theInstance = new addSI();       

        private addSI()
        {
            InitializeComponent();
        }

        private void addSI_Load(object sender, EventArgs e)
        {
            DeliveryReceiptsManager.instance.fillComboBox(deliveryReceiptIDCBox);
            deliveryReceiptIDCBox.SelectedIndex = 0;
        }

        private void deliveryReceiptIDCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            customerPONumberTxtBox.Text = SupplierPOManager.instance.getCustomerPONumber(DeliveryReceiptsManager.instance.getSupplierPONumber(deliveryReceiptIDCBox.SelectedItem.ToString()));
        }

        private void addSIBtn_Click(object sender, EventArgs e)
        {
            addSI_Items.instance.setAddType(true);
            addSI_Items.instance.setInvoiceNumber(invoiceNumberTxtBox.Text);
            addSI_Items.instance.setDeliveryReceiptNumber(deliveryReceiptIDCBox.SelectedItem.ToString());
            addSI_Items.instance.ShowDialog();
        }

        public void addNewSI()
        {
            InvoicesManager.instance.addData(invoiceNumberTxtBox.Text, deliveryReceiptIDCBox.SelectedItem.ToString(), dateIssuedCBox.Value.Date.ToShortDateString(), 0);
        }

        public static addSI instance
        {
            get { return theInstance; }
        }

    }
}
