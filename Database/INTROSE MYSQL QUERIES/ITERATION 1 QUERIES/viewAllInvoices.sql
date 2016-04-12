SELECT	A.invoiceNumber						AS 'Invoice Number',
		A.deliveryReceiptNumber 			AS 'Delivery Receipt Number',
        A.customerPONumber					AS 'Customer PO Number',
        A.invoiceTotalPrice					AS 'Total Invoice Price',
        E.itemNumber						AS 'Item Number',
        G.description						AS 'Item Description',
        E.pricePerUnit						AS 'Price Per Unit',
        E.pricePerUnit*B.deliveredQuantity	AS 'Total Item Price',
        A.dateReceived						AS 'Date Received'
FROM invoices A
	JOIN invoice_items B
		ON B.invoiceNumber = A.invoiceNumber
	JOIN delivered_items C
		ON C.deliveryItemID = B.deliveryItemID
	JOIN customer_po D
		ON D.customerPONumber = A.customerPONumber
	JOIN customer_order_items E
		ON E.customerOrderID = B.customerOrderID
	JOIN customer_inspection_results F
		ON F.invoiceItemID = B.invoiceItemID
	JOIN items G
		ON G.itemNumber = E.itemNumber
ORDER BY A.invoiceNumber DESC;