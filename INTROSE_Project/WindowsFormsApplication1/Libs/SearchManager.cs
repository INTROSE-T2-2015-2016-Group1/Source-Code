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

        public void searchForm(DataGridView dataGridView, String formType, String keyType, String input)
        {
            string query =  "";
            formType = formType.ToLower();
            keyType = keyType.ToLower();
            input = input.ToLower();

            if(formType == "items")
            {
                query = "SELECT * FROM items"+
                        " WHERE itemNumber LIKE '"+input+
                        "' OR supplierName LIKE '"+input+
                        "' OR description LIKE '" + input + "'";
                if(keyType == "item number")
                    query = "SELECT * FROM items"+
                            " WHERE itemNumber LIKE '"+input+"'";
                else if(keyType == "supplier name")
                    query = "SELECT * FROM items'"+
                            " WHERE  supplierName LIKE '" + input + "'";
            }
            else if(formType == "customers")
            {
                query = "SELECT * FROM customers"+
                        " WHERE customerName LIKE '" + input + "'";
            }
            else if(formType == "customer purchase order")
            {
                query = "SELECT * FROM customer_po"+
                        " WHERE customerPONumber LIKE '"+input+
                        "' OR customerName LIKE '"+input+
                        "' OR dateIssued LIKE '"+input+
                        "' OR expectedDeliveryDate LIKE '"+input+
                        "' OR isFinished LIKE '" + input + "'";
                if(keyType == "customper po number")
                    query = "SELECT * FROM customer_po"+
                            " WHERE customerPONumber LIKE '" + input + "'";
                else if(keyType == "customer name")
                    query = "SELECT * FROM customer_po"+
                            " WHERE customerName LIKE '" + input + "'";
                else if(keyType == "date issued")
                    query = "SELECT * FROM customer_po"+
                            " WHERE dateIssued LIKE '" + input + "'";
                else if(keyType == "expected delivery date")
                    query = "SELECT * FROM customer_po"+
                            " WHERE expectedDeliveryDate LIKE '" + input + "'";
            }
            else if(formType == "customer order items")
            {
                query = "SELECT * FROM customer_order_items"+
                        " WHERE customerOrderID LIKE '"+input+
                        "' OR customerPONumber LIKE '"+input+
                        "' OR itemDescription LIKE '"+input+
                        "' OR quantity LIKE '"+input+
                        "' OR currency LIKE '"+input+
                        "' OR pricePerUnit LIKE '"+input+
                        "' OR totalPrice LIKE '"+input+
                        "' OR isFinished LIKE '" + input + "'";
                if(keyType == "customer order id")
                    query = "SELECT * FROM customer_order_items"+
                            " WHERE customerOrderID LIKE '" + input + "'";
                else if(keyType == "customer po number")
                    query = "SELECT * FROM customer_order_items"+
                            " WHERE customerPONumber LIKE '" + input + "'";
                else if(keyType == "price per unit")
                    query = "SELECT * FROM customer_order_items"+
                            " WHERE pricePerUnit LIKE '" + input + "'";
            }
            else if(formType == "suppliers")
            {
                query = "SELECT * FROM suppliers"+
                        " WHERE supplierName LIKE '" + input + "'";

            }
            else if(formType == "supplier purchase order")
            {
                query = "SELECT * FROM supplier_po"+
                        " WHERE supplierPONumber LIKE '" + input +
                        "' OR customerPONumber LIKE '"+input+
                        "' OR supplierName LIKE '"+input+
                        "' OR dateIssued LIKE '"+input+
                        "' OR expectedDeliveryDate LIKE '"+input+
                        "' OR isFinished LIKE '" + input + "'";
                if(keyType == "supplier po number")
                    query = "SELECT * FROM supplier_po"+
                        " WHERE supplierPONumber LIKE '" + input + "'";
                else if(keyType == "customer po number")query = "SELECT * FROM supplier_po"+
                        " WHERE customerPONumber LIKE '" + input + "'";
                else if(keyType == "supplier name")
                    query = "SELECT * FROM supplier_po"+
                        " WHERE supplierName LIKE '" + input + "'";
                else if(keyType == "date issued")
                    query = "SELECT * FROM supplier_po"+
                        " WHERE dateIssued LIKE '" + input + "'";
                else if(keyType == "expected delivery date")
                    query = "SELECT * FROM supplier_po"+
                        " WHERE expectedDeliveryDate LIKE '" + input + "'";
            }
            else if(formType == "supplier order items")
            {
                query = "SELECT * FROM supplier_order_items"+
                        " WHERE supplierOrderID LIKE '" + input +
                        "' OR supplierPONumber LIKE '"+input+
                        "' OR itemNumber LIKE '"+input+
                        "' OR quantity LIKE '"+input+
                        "' OR currency LIKE '"+input+
                        "' OR pricePerunit LIKE '"+input+
                        "' OR totalPrice LIKE '"+input+
                        "' OR isFinished LIKE '" + input + "'";
                if(keyType == "supplier order id")
                    query = "SELECT * FROM supplier_order_items"+
                        " WHERE supplierOrderID LIKE '" + input + "'";
                else if(keyType == "supplier po number")
                    query = "SELECT * FROM supplier_order_items"+
                        " WHERE supplierPONumber LIKE '" + input + "'";
                else if(keyType == "item number")
                    query = "SELECT * FROM supplier_order_items"+
                        " WHERE itemNumber LIKE '" + input + "'";
                else if(keyType == "quantity")
                    query = "SELECT * FROM supplier_order_items"+
                        " WHERE quantity LIKE '" + input + "'";
                else if(keyType == "price per unit")
                    query = "SELECT * FROM supplier_order_items"+
                        " WHERE pricePerunit LIKE '" + input + "'";
                else if(keyType == "total price")
                    query = "SELECT * FROM supplier_order_items"+
                        " WHERE totalPrice LIKE '" + input + "'";
            }
            else if(formType == "delivery receipts")
            {
                query = "SELECT * FROM delivery_receipts"+
                        " WHERE deliveryReceiptNumber LIKE '" + input +
                        "' OR supplierPONumber LIKE '"+input+
                        "' OR dateReceived LIKE '" + input + "'";
                if(keyType == "delivery receipt number")
                    query = "SELECT * FROM delivery_receipts"+
                        " WHERE deliveryReceiptNumber LIKE '" + input + "'";
                else if(keyType == "supplier po number")
                    query = "SELECT * FROM delivery_receipts"+
                        " WHERE supplierPONumber LIKE '" + input + "'";
                else if(keyType == "date recieved")
                    query = "SELECT * FROM delivery_receipts"+
                        " WHERE dateReceived LIKE '" + input + "'";
            }
            else if(formType == "delivery items")
            {
                query = "SELECT * FROM delivered_items"+
                        " WHERE deliveryItemID LIKE '" + input +
                        "' OR deliveryReceiptNumber LIKE '"+input+
                        "' OR supplierOrderID LIKE '"+input+
                        "' OR deliveredQuantity LIKE '"+input+
                        "' OR itemNumber LIKE '"+input+
                        "' OR approvedQuantity LIKE '"+input+
                        "' OR rejectedQuantity LIKE '" + input + "'";
                if(keyType == "delivery item id")
                    query = "SELECT * FROM delivered_items"+
                        " WHERE deliveryItemID LIKE '" + input + "'";
                else if(keyType == "delivery receipt number")
                    query = "SELECT * FROM delivered_items"+
                        " WHERE deliveryReceiptNumber LIKE '" + input + "'";
                else if(keyType == "supplier order id")
                    query = "SELECT * FROM delivered_items"+
                        " WHERE supplierOrderID LIKE '" + input + "'";
                else if(keyType == "delivered quantity")
                    query = "SELECT * FROM delivered_items"+
                        " WHERE deliveredQuantity LIKE '" + input + "'";
                else if(keyType == "item number")
                    query = "SELECT * FROM delivered_items"+
                        " WHERE itemNumber LIKE '" + input + "'";
                else if(keyType == "approved quantity")
                    query = "SELECT * FROM delivered_items"+
                        " WHERE approvedQuantity LIKE '" + input + "'";
                else if(keyType == "rejected quantity")
                    query = "SELECT * FROM delivered_items"+
                        " WHERE rejectedQuantity LIKE '" + input + "'";
            }
            else if(formType == "invoices")
            {
                query = "SELECT * FROM invoices"+
                        " WHERE invoiceNumber LIKE '" + input +
                        "' OR deliveryReceiptNumber LIKE '"+input+
                        "' OR dateReceived LIKE '"+input+
                        "' OR invoiceTotalPrice LIKE '" + input + "'";
                if(keyType == "invoice number")
                    query = "SELECT * FROM invoices"+
                        " WHERE invoiceNumber LIKE '" + input + "'";
                else if(keyType == "delivery receipt number")
                    query = "SELECT * FROM invoices"+
                        " WHERE OR deliveryReceiptNumber LIKE '" + input + "'";
                else if(keyType == "date recieved")
                    query = "SELECT * FROM invoices"+
                        " WHERE dateReceived LIKE '" + input + "'";
                else if(keyType == "total price")
                    query = "SELECT * FROM invoices"+
                        " WHERE invoiceTotalPrice LIKE '" + input + "'";
            }
            else if(formType == "invoice items")
            {
                query = "SELECT * FROM invoice_items"+
                        " WHERE invoiceItemID LIKE '" + input +
                        "' OR deliveryItemID LIKE '"+input+
                        "' OR invoiceNumber LIKE '"+input+
                        "' OR customerOrderID LIKE '"+input+
                        "' OR deliveredQuantity LIKE '"+input+
                        "' OR itemNumber LIKE '"+input+
                        "' OR itemPrice LIKE '"+input+
                        "' OR approvedQuantity  LIKE '"+input+
                        "' OR rejectedQuantity LIKE '" + input + "'";
                if (keyType == "invoice item id")
                    query = "SELECT * FROM invoice_items" +
                        " WHERE invoiceItemID LIKE '" + input + "'";
                else if (keyType == "delivery item id")
                    query = "SELECT * FROM invoice_items" +
                        " WHERE deliveryItemID LIKE '" + input + "'";
                else if (keyType == "invoice number")
                    query = "SELECT * FROM invoice_items" +
                        " WHERE invoiceNumber LIKE '" + input + "'";
                else if (keyType == "customer order id")
                    query = "SELECT * FROM invoice_items" +
                        " WHERE customerOrderID LIKE '" + input + "'";
            }
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

        public String AllOr(String type)
        {
            String output = "";

            if (type == "all columns")
                output = "' OR";
            else
                output = " WHERE";
            return output;
        }

        public static SearchManager instance
        {
            get { return theInstance; }
        }
    }
}
