SELECT	A.deliveryReceiptNumber		AS 'Delivery Receipt Number',
		D.supplierPONumber			AS 'Supplier PO Number',
		D.itemNumber				AS 'Item Number',
        E.description				AS 'Item Description',
        A.dateReceived				AS 'Date Received',
		B.deliveredQuantity			AS 'Delivered Quantity',
        C.approvedQuantity			AS 'Approved Quantity', 
        C.rejectedQuantity			AS 'Rejected Quantity'
FROM 	delivery_receipts A
			JOIN delivered_items B
				ON B.deliveryReceiptNumber = A.deliveryReceiptNumber
			JOIN godo_inspection_results C
				ON C.deliveryItemID = B.deliveryItemID
			JOIN supplier_order_items D
				ON D.supplierOrderID = B.supplierOrderID
			JOIN items E
				ON D.itemNumber = E.itemNumber
ORDER BY A.deliveryReceiptNumber DESC;