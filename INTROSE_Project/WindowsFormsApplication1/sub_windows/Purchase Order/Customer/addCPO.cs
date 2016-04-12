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
using introse_project.sub_windows.Purchase_Order.Customer;

namespace introse_project.sub_windows.Purchase_Order
{
    public partial class addCPO : Form
    {
        #region Variables
        private static addCPO theInstance = new addCPO();
        #endregion

        private addCPO()
        {
            InitializeComponent();
        }

        #region Event Handlers
        private void addCPO_Load(object sender, EventArgs e)
        {
            CustomerManager.instance.fillComboBox(customerNameCBox);
            customerNameCBox.SelectedIndex = 0;
        }
        #endregion

        #region Button Click Events
        private void addCPOBtn_Click(object sender, EventArgs e)
        {
            if (!CustomerPOManager.instance.pkExists(cPONumberTxtBox.Text) && !String.IsNullOrWhiteSpace(cPONumberTxtBox.Text))
            {
                if (dateIssuedCBox.Value.Date <= dateExpectedCBox.Value.Date)
                {
                    addCPOItem.instance.setAddType(true);
                    addCPOItem.instance.setPONumber(cPONumberTxtBox.Text);
                    addCPOItem.instance.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Date issued cannot be after the expected date", "ERROR");
                }                  
            }
            else
            {
                MessageBox.Show("Customer purchase order number already exists or entered the PO number is invalid/missing", "ERROR");
            }           
        }
        #endregion

        public void addNewCPO() //adds a new CPO and resets all input values
        {
            CustomerPOManager.instance.addData(cPONumberTxtBox.Text, customerNameCBox.SelectedItem.ToString(), dateIssuedCBox.Value.Date.ToShortDateString(), dateExpectedCBox.Value.Date.ToShortDateString());
            cPONumberTxtBox.Text = "";
            dateIssuedCBox.Value = DateTime.Now;
            dateExpectedCBox.Value = DateTime.Now;
        }

        public static addCPO instance
        {
            get { return theInstance; }
        }
      
    }
}
