select invoices.*
from delivery_receipts,  invoices
where delivery_receipts.deliveryReceiptNumber = invoices.deliveryReceiptNumber;