select customer_inspection_results.*
from invoices,  customer_inspection_results
where invoices.invoiceNumber = customer_inspection_results.invoiceNumber;