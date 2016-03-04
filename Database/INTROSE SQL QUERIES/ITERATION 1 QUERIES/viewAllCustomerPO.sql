SELECT	A.customerPONumber		AS 'Customer PO Number',
		A.customerName			AS 'Customer Name',
		A.dateIssued			AS 'Date Issued',
        A.expectedDeliveryDate 	AS 'Expected Delivery Date',
        B.itemNumber 			AS 'Item Number',
        C.description 			AS 'Item Description',
        B.quantity 				AS 'Item Quantity',
        B.currency 				AS 'Currency',
        B.pricePerUnit			AS 'Price Per Unit',
        B.totalPrice			AS 'Total Price',
        B.isFinished			AS 'Status'
FROM 	customer_po A 
			JOIN customer_order_items B
				ON B.customerPONumber = A.customerPONumber
			JOIN items C 
				ON C.itemNumber = B.itemNumber
ORDER BY A.customerPONumber DESC;                                                                                                                                                                     