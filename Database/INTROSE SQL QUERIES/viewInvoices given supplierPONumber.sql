select invoices.*
from customer_po, invoices
where customer_po.customerPONumber = invoices.customerPONumber;