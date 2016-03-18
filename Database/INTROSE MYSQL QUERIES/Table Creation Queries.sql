CREATE TABLE items (
  itemNumber int NOT NULL AUTO_INCREMENT,
  supplierName varchar(40) NOT NULL,
  description varchar(40) NOT NULL,
  PRIMARY KEY (itemNumber)
);

CREATE TABLE customers (
  customerName varchar(40) NOT NULL,
  PRIMARY KEY (customerName)
);

CREATE TABLE customer_po (
  customerPONumber varchar(40) NOT NULL,
  customerName varchar(40) NOT NULL,
  dateIssued varchar(10) NOT NULL,
  expectedDeliveryDate varchar(10) NOT NULL,
  isFinished boolean NOT NULL,
  PRIMARY KEY (customerPONumber),
  FOREIGN KEY (customerName) REFERENCES customers(customerName)
);

CREATE TABLE customer_order_items (
  customerOrderID int NOT NULL AUTO_INCREMENT,
  customerPONumber varchar(40) NOT NULL,
  itemNumber int NOT NULL,
  quantity int NOT NULL,
  currency varchar(5) NOT NULL,
  pricePerUnit float NOT NULL,
  totalPrice float NOT NULL,
  isFinished boolean NOT NULL,
  PRIMARY KEY (customerOrderID),
  FOREIGN KEY (customerPONumber) REFERENCES customer_po(customerPONumber),
  FOREIGN KEY (itemNumber) REFERENCES items(itemNumber)
);

CREATE TABLE suppliers (
  supplierName varchar(40) NOT NULL,
  PRIMARY KEY (supplierName)
);

CREATE TABLE supplier_po (
  supplierPONumber varchar(40) NOT NULL,
  customerPONumber varchar(40) NOT NULL,
  supplierName varchar(40) NOT NULL,
  dateIssued varchar(10) NOT NULL,
  expectedDeliveryDate varchar(10) NOT NULL,
  isFinished boolean NOT NULL,
  PRIMARY KEY (supplierPONumber),
  FOREIGN KEY (customerPONumber) REFERENCES customer_po(customerPONumber),
  FOREIGN KEY (supplierName) REFERENCES suppliers(supplierName)
);

CREATE TABLE supplier_order_items (
  supplierOrderID int NOT NULL AUTO_INCREMENT,
  supplierPONumber varchar(40) NOT NULL,
  itemNumber int NOT NULL,
  quantity int NOT NULL,
  currency varchar(5) NOT NULL,
  pricePerunit float NOT NULL,
  totalPrice float NOT NULL,
  isFinished boolean NOT NULL,
  PRIMARY KEY (supplierOrderID),
  FOREIGN KEY (supplierPONumber) REFERENCES supplier_po(supplierPONumber),
  FOREIGN KEY (itemNumber) REFERENCES items(itemNumber)
);

CREATE TABLE delivery_receipts (
  deliveryReceiptNumber varchar(40) NOT NULL,
  supplierPONumber varchar(40) NOT NULL,
  dateReceived varchar(10) NOT NULL,
  PRIMARY KEY (deliveryReceiptNumber),
  FOREIGN KEY (supplierPONumber) REFERENCES supplier_po(supplierPONumber)
);

CREATE TABLE delivered_items (
  deliveryItemID int NOT NULL AUTO_INCREMENT,
  deliveryReceiptNumber varchar(40) NOT NULL,
  supplierOrderID int NOT NULL,
  deliveredQuantity int NOT NULL,
  PRIMARY KEY (deliveryItemID),
  FOREIGN KEY (deliveryReceiptNumber) REFERENCES delivery_receipts(deliveryReceiptNumber),
  FOREIGN KEY (supplierOrderID) REFERENCES supplier_order_items(supplierOrderID)
);

CREATE TABLE godo_inspection_results (
  deliveryItemID int NOT NULL,
  approvedQuantity int NOT NULL,
  rejectedQuantity int NOT NULL,
  FOREIGN KEY (deliveryItemID) REFERENCES delivered_items(deliveryItemID)
);

CREATE TABLE invoices (
  invoiceNumber varchar(40) NOT NULL,
  deliveryReceiptNumber varchar(40) NOT NULL,
  customerPONumber varchar(40) NOT NULL,
  dateReceived varchar(10) NOT NULL,
  invoiceTotalPrice float NOT NULL,
  PRIMARY KEY (invoiceNumber),
  FOREIGN KEY (deliveryReceiptNumber) REFERENCES delivery_receipts(deliveryReceiptNumber),
  FOREIGN KEY (customerPONumber) REFERENCES customer_po(customerPONumber)
);

CREATE TABLE invoice_items (
  invoiceItemID int NOT NULL AUTO_INCREMENT,
  deliveryItemID int NOT NULL,
  invoiceNumber varchar(40) NOT NULL,
  customerOrderID int NOT NULL,
  deliveredQuantity int NOT NULL,
  PRIMARY KEY (invoiceItemID),
  FOREIGN KEY (deliveryItemID) REFERENCES delivered_items(deliveryItemID),
  FOREIGN KEY (invoiceNumber) REFERENCES invoices(invoiceNumber),
  FOREIGN KEY (customerOrderID) REFERENCES customer_order_items(customerOrderID)
);

CREATE TABLE customer_inspection_results (
  invoiceItemID int NOT NULL,
  approvedQuantity int NOT NULL,
  rejectedQuantity int NOT NULL,
  FOREIGN KEY (invoiceItemID) REFERENCES invoice_items(invoiceItemID)
);