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

            if (formType == "customer_inspection_results")
            {
                query = "SELECT * FROM customer_inspection_results";

                if (keyType == "invoiceitemid" || keyType == "all")
                    query = query + " WHERE invoiceItemID LIKE '%" + input + "%'";
                if (keyType == "approvedquantity" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " approvedQuantity LIKE '%" + input + "%'";
                }
                if (keyType == "rejectedquantity" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " rejectedQuantity LIKE '%" + input + "%'";
                }
                query = query + ";";
            }
            else if (formType == "customer_order_items")
            {
                query = "SELECT * FROM customer_order_items";

                if (keyType == "customerorderID" || keyType == "all")
                    query = query + " WHERE customerOrderID LIKE '%" + input + "%'";
                if (keyType == "customerponumber" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " customerPONumber LIKE '%" + input + "%'";
                }
                if (keyType == "itemnumber" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " itemNumber LIKE '%" + input + "%'";
                }
                if (keyType == "quantity" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " quantity LIKE '%" + input + "%'";
                }
                if (keyType == "currency" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " currency LIKE '%" + input + "%'";
                }
                if (keyType == "priceperunit" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " pricePerUnit LIKE '%" + input + "%'";
                }
                if (keyType == "totalprice" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " totalPrice LIKE '%" + input + "%'";
                }
                if (keyType == "isfinished" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " isFinished LIKE '%" + input + "%'";
                }
                query = query + ";";
            }
            else if (formType == "customer_po")
            {
                query = "SELECT * FROM customer_po";
                if (keyType == "customerponumber" || keyType == "all")
                    query = query + " WHERE customerPONumber LIKE '%" + input + "%'";
                if (keyType == "customername" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " customerName LIKE '%" + input + "%'";
                }
                if (keyType == "dateissued" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " dateIssued LIKE '%" + input + "%'";
                }
                if (keyType == "expecteddeliverydate" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " expectedDeliveryDate LIKE '%" + input + "%'";
                }
                if (formType == "isfinished" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " isFinished LIKE '%" + input + "%'";
                }
                query = query + ";";
            }
            else if (formType == "customers")
                query = "SELECT * FROM customers" +
                        " WHERE customerName LIKE '%" + input + "%'";
            else if (formType == "delivered_items")
            {
                query = "SELECT * FROM delivered_items";
                if (keyType == "deliveryitemid" || keyType == "all")
                    query = query + " WHERE deliveryItemID LIKE '%" + input + "%'";
                if (keyType == "deliveryreceiptnumber" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " deliveryReceiptNumber LIKE '%" + input + "%'";
                }
                if (keyType == "supplierorderid" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " supplierOrderID LIKE '%" + input + "%'";
                }
                if (keyType == "deliveredquantity" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " deliveredQuantity LIKE '%" + input + "%'";
                }
                query = query + ";";
            }   
            else if (formType == "delivery_receipts")
            {
                query = "SELECT * FROM delivery_receipts";
                if (keyType == "deliveryreceiptnumber" || keyType == "all")
                    query = query + " WHERE deliveryReceiptNumber LIKE '%" + input + "%'";
                if (keyType == "supplierponumber" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " supplierPONumber LIKE '%" + input + "%'";
                }
                if (keyType == "datereceived" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " dateReceived LIKE '%" + input + "%'";
                }
                query = query + ";";
            }
            else if (formType == "godo_inspection_results")
            {
                query = "SELECT * FROM godo_inspection_results";
                if (keyType == "deliveryitemid" || keyType == "all")
                    query = query + " WHERE deliveryItemID LIKE '%" + input + "%'";
                if (keyType == "approvedquantity" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " approvedQuantity LIKE '%" + input + "%'";
                }
                if (keyType == "rejectedquantity" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " rejectedQuantity LIKE '%" + input + "%'";
                }
            }
            else if (formType == "invoice_items")
            {
                query = "SELECT * FROM invoice_items";
                if (keyType == "invoiceitemid" || keyType == "all")
                    query = query + " WHERE invoiceItemID LIKE '%" + input + "%'";
                if (keyType == "deliveryitemid" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " deliveryItemID LIKE '%" + input + "%'";
                }
                if (keyType == "invoicenumber" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " invoiceNumber LIKE '%" + input + "%'";
                }
                if (keyType == "customerorderid" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " customerOrderID LIKE '%" + input + "%'";
                }
                if (keyType == "deliveredquantity" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " deliveredquantity LIKE '%" + input + "%'";
                }
                query = query + ";";
            }
            else if (formType == "invoices")
            {
                query = "SELECT * FROM invoices";
                if (keyType == "invoicenumber" || keyType == "all")
                    query = query + " WHERE invoiceNumber LIKE '%" + input + "%'";
                if (keyType == "deliveredreceiptnumber" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " deliveryReceiptNumber LIKE '%" + input + "%'";
                }
                if (keyType == "customerponumber" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " customerPONumber LIKE '%" + input + "%'";
                }
                if (keyType == "datereceived" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " dateReceived LIKE '%" + input + "%'";
                }
                if (keyType == "invoicetotalprice" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " invoiceTotalPrice LIKE '%" + input + "%'";
                }
                query = query + ";";
            }
            else if (formType == "items")
            {
                query = "SELECT * FROM items ";
                if (keyType == "itemnumber" || keyType == "all")
                    query = query + " WHERE itemNumber LIKE '%" + input + "%'";
                if (keyType == "suppliername" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " supplierName LIKE '%" + input + "%'";
                }
                if (keyType == "description" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " description LIKE '%" + input + "%'";
                }
                query = query + ";";
            }
            else if (formType == "supplier_order_items")
            {
                query = "SELECT * FROM supplier_order_items ";
                if (keyType == "supplierorderid" || keyType == "all")
                    query = query + " WHERE supplierOrderID LIKE '%" + input + "%'";
                if (keyType == "supplierponumber" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " supplierPONumber LIKE '%" + input + "%'";
                }
                if (keyType == "itemnumber" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " itemNumber LIKE '%" + input + "%'";
                }
                if (keyType == "quantity" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " quantity LIKE '%" + input + "%'";
                }
                if (keyType == "currency" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " currency LIKE '%" + input + "%'";
                }
                if (keyType == "priceperunit" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " pricePerUnit LIKE '%" + input + "%'";
                }
                if (keyType == "totalprice" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " totalPrice LIKE '%" + input + "%'";
                }
                if (keyType == "isfinished" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " isFinished LIKE '%" + input + "%'";
                }
                query = query + ";";
            }
            else if (formType == "supplier_po")
            {
                query = "SELECT * FROM supplier_po";
                if (keyType == "supplierponumber" || keyType == "all")
                    query = query + " WHERE supplierPONumber LIKE '%" + input + "%'";
                if (keyType == "customerponumber" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " customerPONumber LIKE '%" + input + "%'";
                }
                if (keyType == "suppliername" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " supplierName LIKE '%" + input + "%'";
                }
                if (keyType == "dateissued" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " dateIssued LIKE '%" + input + "%'";
                }
                if (keyType == "expecteddeliverydate" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " expectedDeliveryDate LIKE '%" + input + "%'";
                }
                if (keyType == "isfinished" || keyType == "all")
                {
                    query = query + AllOr(keyType);
                    query = query + " isFinished LIKE '%" + input + "%'";
                }
                query = query + ";";
            }
            else if (formType == "suppliers")
                query = "SELECT * FROM suppliers " +
                        "WHERE supplierName LIKE '%" + input + "%'";
            else
                MessageBox.Show("unknown form type\ndid not search");

            Console.WriteLine(query);

            MySqlConnection connection = new MySqlConnection(ConfigurationManager.ConnectionStrings["roiConn"].ConnectionString);
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

            if (type == "all")
                output = " OR";
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
