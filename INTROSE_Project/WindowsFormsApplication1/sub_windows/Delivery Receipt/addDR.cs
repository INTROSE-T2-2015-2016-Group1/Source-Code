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
        #region Variables
        private static addDR theInstance = new addDR();
        #endregion

        private addDR()
        {
            InitializeComponent();
        }

        #region Event Handlers
        private void addDR_Load(object sender, EventArgs e)
        {
            SupplierPOManager.instance.fillComboBox(supplierPOIdCBox);
            if (supplierPOIdCBox.Items.Count > 0)
            {
                supplierPOIdCBox.SelectedIndex = 0;
            }
            else
            {
                this.Close();
                MessageBox.Show("All current supplier PO's are finished and cannot have more items delivered");
            }
            
        }
        #endregion

        #region Button Click Events
        private void addDRBtn_Click(object sender, EventArgs e)
        {       
            if (SupplierOrderItemsManager.instance.getCount() > 0)
            {
                if (!String.IsNullOrWhiteSpace(deliveryReceiptNumberTxtBox.Text) && !DeliveryReceiptsManager.instance.pkExists(deliveryReceiptNumberTxtBox.Text))
                {
                    if (DateTime.ParseExact(SupplierPOManager.instance.getDateIssued(supplierPOIdCBox.SelectedItem.ToString()), "M/d/yyyy", System.Globalization.CultureInfo.InvariantCulture).Date <= dateReceivedCBox.Value.Date)
                    {
                        addDRItems.instance.setAddType(true);
                        addDRItems.instance.setDeliveryReceiptNumber(deliveryReceiptNumberTxtBox.Text);
                        addDRItems.instance.setSupplierPONumber(supplierPOIdCBox.SelectedItem.ToString());
                        addDRItems.instance.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Date received cannot be before date issued", "ERROR");
                    }
                        
                }
                else
                {
                    MessageBox.Show("Delivery receipt number already exists or entered delivery receipt number is invalid/missing", "ERROR");
                }             
            }
            else
            {
                MessageBox.Show("No items ordered from any supplier PO to add to delivery receipts", "ERROR");
            }
        }
        #endregion

        public void addNewDR()
        {
            DeliveryReceiptsManager.instance.addData(deliveryReceiptNumberTxtBox.Text,
                                                     supplierPOIdCBox.SelectedItem.ToString(),
                                                     dateReceivedCBox.Value.Date.ToShortDateString());
            
            deliveryReceiptNumberTxtBox.Text = "";
            dateReceivedCBox.Value = DateTime.Now;
        }

        public static addDR instance
        {
            get { return theInstance; }
        }

    }
}
