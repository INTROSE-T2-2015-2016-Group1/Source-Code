SELECT A.*, D.itemNumber, E.description, B.deliveredQuantity, C.approvedQuantity, C.rejectedQuantity
FROM delivery_receipts A, delivered_items B, godo_inspection_results C, supplier_order_items D, items E
WHERE A.deliveryReceiptNumber = B.deliveryReceiptNumber AND B.deliveryItemID = C.deliveryItemID AND B.supplierOrderID = D.supplierOrderID AND D.itemNumber = E.itemNumber;