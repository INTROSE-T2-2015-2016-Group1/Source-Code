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
    public partial class viewDRItems : Form
    {
        private static viewDRItems theInstance = new viewDRItems();
        private string deliveryReceiptNumber;
        
        private viewDRItems()
        {
            InitializeComponent();
        }

        private void viewDRItems_Load(object sender, EventArgs e)
        {
            DeliveryItemsManager.instance.viewAll(deliveryReceiptNumber, DR_ItemsGridView);
        }

        public void setDeliveryReceiptNumber(string deliveryReceiptNumber)
        {
            this.deliveryReceiptNumber = deliveryReceiptNumber;
        }

        public static viewDRItems instance
        {
            get { return theInstance; }
        }       
    }
}
