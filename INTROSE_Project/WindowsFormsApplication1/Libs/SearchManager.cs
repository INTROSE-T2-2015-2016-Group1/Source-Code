using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace introse_project.Libs
{
    class SearchManager
    {
        private static SearchManager theInstance = new SearchManager();

        private SearchManager()
        {
        }

        public void searchForm(DataGridView dataGridView, String formType, String input)
        {
            string query = "";
            formType = formType.ToLower();

            if (formType == "items")
                query = "SELECT * FROM items " +
                        "WHERE itemNumber LIKE '"+input+"' " +
                        "OR supplierName LIKE '"+input+"' " +
                        "OR description  LIKE '"+input+"' ";
            else if (formType == "customer")
                query = "SELECT * FROM customers " +
                        "WHERE customerName LIKE '"+input+"' ";
            else if (formType == "customer purchase order")
                query = "SELECT * FROM customer_po " +
                        "WHERE customerPONumber LIKE '"+input+"' " +
                        "OR customerName LIKE'"+input+"' " +
                        "OR  dateIssued LIKE '"+input+"' " +
                        "OR  expectedDeliveryDate LIKE '"+input+"' " +
                        "OR  isFinished LIKE '"+input+"' ";
            else if (formType == "customer order items")
                query = "SELECT * FROM customer_order_items " +
                        "WHERE customerOrderID LIKE '"+input+"' " +
                        "OR customerPONumber LIKE '"+input+"' " +
                        "OR itemDescription LIKE '"+input+"' " +
                        "OR quantity LIKE '"+input+"' " +
                        "OR currency LIKE '"+input+"' " +
                        "OR pricePerUnit LIKE '"+input+"' " +
                        "OR totalPrice LIKE '"+input+"' " +
                        "OR isFinished LIKE '"+input+"' ";
            else if (formType == "supplier")
                query = "SELECT * FROM suppliers " +
                        "WHERE supplierName LIKE '"+input+"' ";
            else if (formType == "supplier purchase order")
                query = "SELECT * FROM supplier_po " +
                        "WHERE supplierPONumber LIKE '"+input+"' " +
                        "OR customerPONumber LIKE '"+input+"' " +
                        "OR supplierName LIKE '"+input+"' " +
                        "OR dateIssued LIKE '"+input+"' " +
                        "OR expectedDeliveryDate LIKE '"+input+"' " +
                        "OR isFinished LIKE '"+input+"' ";
            else if (formType == "supplier order items")
                query = "SELECT * FROM supplier_order_items " +
                        "WHERE supplierOrderID LIKE '"+input+"' " +
                        "OR supplierPONumber LIKE '"+input+"' " +
                        "OR itemNumber LIKE '"+input+"' " +
                        "OR quantity LIKE '"+input+"' " +
                        "OR currency LIKE '"+input+"' " +
                        "OR pricePerunit LIKE '"+input+"' " +
                        "OR totalPrice LIKE '"+input+"' " +
                        "OR isFinished LIKE '"+input+"' ";
            else if (formType == "delivery receipts")
                query = "SELECT * FROM delivery_receipts "+
                        "WHERE deliveryReceiptNumber LIKE '"+input+"' " +
                        "OR supplierPONumber LIKE '"+input+"' " +
                        "OR dateReceived LIKE '"+input+"' ";
            else if (formType == "delivery items")
                query = "SELECT * FROM delivered_items "+
                        "WHERE deliveryItemID LIKE '"+input+"' " +
                        "OR deliveryReceiptNumber LIKE '"+input+"' " +
                        "OR supplierOrderID LIKE '"+input+"' " +
                        "OR deliveredQuantity LIKE '"+input+"' ";
            else if (formType == "godo inspection results")
                query = "SELECT * FROM godo_inspection_results "+
                        "WHERE deliveryItemID LIKE '"+input+"' " +
                        "OR approvedQuantity LIKE '"+input+"' " +
                        "OR rejectedQuantity LIKE '"+input+"' ";
            else if (formType == "invoices")
                query = "SELECT * FROM invoices "+
                        "WHERE invoiceNumber LIKE '"+input+"' " +
                        "OR deliveryReceiptNumber LIKE '"+input+"' " +
                        "OR customerPONumber LIKE '"+input+"' " +
                        "OR dateReceived LIKE '"+input+"' " +
                        "OR invoiceTotalPrice  LIKE '"+input+"' ";
            else if (formType == "invoice items")
                query = "SELECT * FROM invoice_items "+
                        "WHERE invoiceItemID LIKE '"+input+"' " +
                        "OR deliveryItemID LIKE '"+input+"' " +
                        "OR invoiceNumber LIKE '"+input+"' " +
                        "OR customerOrderID LIKE '"+input+"' " +
                        "OR deliveredQuantity LIKE '"+input+"' ";
            else if (formType == "customer inspection results")
                query = "SELECT * FROM customer_inspection_results " +
                        "WHERE invoiceItemID LIKE '" + input + "' " +
                        "OR approvedQuantity LIKE '" + input + "' " +
                        "OR rejectedQuantity LIKE '" + input + "' ";
            else
                MessageBox.Show("unknown form type\ndid not search");

            Console.WriteLine(query);

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["poConn"].ConnectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            try
            {
                MySqlDataAdapter data = new MySqlDataAdapter();
                data.SelectCommand = command;

                connection.Open();

                DataTable table = new DataTable();
                data.Fill(table);

                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = table;

                dataGridView.DataSource = bindingSource;
                data.Update(table);

                connection.Close();

            }
            catch
            {
                MessageBox.Show("Error: Unable to show table due to connection problems");
            }
            finally
            {
                connection.Close();
            }

        }

        public static SearchManager instance
        {
            get { return theInstance; }
        }
    }
}
