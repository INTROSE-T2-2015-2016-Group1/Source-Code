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
        #region Variables
        private static addSI theInstance = new addSI();
        #endregion

        private addSI()
        {
            InitializeComponent();
        }

        #region Event Handlers
        private void addSI_Load(object sender, EventArgs e)
        {
            DeliveryReceiptsManager.instance.fillComboBox(deliveryReceiptIDCBox);
            deliveryReceiptIDCBox.SelectedIndex = 0;
        }

        private void deliveryReceiptIDCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            customerPONumberTxtBox.Text = SupplierPOManager.instance.getCustomerPONumber(DeliveryReceiptsManager.instance.getSupplierPONumber(deliveryReceiptIDCBox.SelectedItem.ToString()));
        }
        #endregion

        #region Button Click Events
        private void addSIBtn_Click(object sender, EventArgs e)
        {
            if (DeliveryReceiptsManager.instance.getCount() > 0)
            {
                if (!InvoicesManager.instance.pkExists(invoiceNumberTxtBox.Text) && !String.IsNullOrWhiteSpace(invoiceNumberTxtBox.Text))
                {
                    if (DateTime.ParseExact(DeliveryReceiptsManager.instance.getDateReceived(deliveryReceiptIDCBox.SelectedItem.ToString()), "M/d/yyyy", System.Globalization.CultureInfo.InvariantCulture).Date <= dateIssuedCBox.Value.Date)
                    {
                        addSI_Items.instance.setAddType(true);
                        addSI_Items.instance.setInvoiceNumber(invoiceNumberTxtBox.Text);
                        addSI_Items.instance.setDeliveryReceiptNumber(deliveryReceiptIDCBox.SelectedItem.ToString());
                        addSI_Items.instance.ShowDialog();

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Date received cannot be before date received", "ERROR");
                    }
                }
                else
                {
                    MessageBox.Show("Invoice number already exists or entered delivery receipt number is invalid/missing", "ERROR");
                }
            }
            else
            {
                MessageBox.Show("There are no delivered items from any delivery receipts in order to add a new invoice", "ERROR");
            }                            
        }
        #endregion

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
