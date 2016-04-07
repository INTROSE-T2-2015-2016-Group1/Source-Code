SELECT	A.supplierPONumber		AS 'Supplier PO Number',
		D.customerPONumber		AS 'Customer PO Number',
		A.supplierName			AS 'Supplier Name',
		A.dateIssued			AS 'Date Issued',
        A.expectedDeliveryDate 	AS 'Expected Delivery Date',
        B.itemNumber 			AS 'Item Number',
        C.description 			AS 'Item Description',
        B.quantity 				AS 'Item Quantity',
        B.currency 				AS 'Currency',
        B.pricePerUnit			AS 'Price Per Unit',
        B.totalPrice			AS 'Total Price',
        B.isFinished			AS 'Status'
FROM 	supplier_po A
			JOIN supplier_order_items B
				ON B.supplierPONumber = A.supplierPONumber
			JOIN items C 
				ON C.itemNumber = B.itemNumber
			JOIN customer_po D
				ON D.customerPONumber = A.customerPONumber
ORDER BY A.supplierPONumber DESC;                                                                                                                                                                     