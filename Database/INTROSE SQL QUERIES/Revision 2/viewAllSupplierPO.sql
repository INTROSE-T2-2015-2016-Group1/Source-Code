SELECT B.supplierOrderID, A.supplierPONumber, A.customerPONumber, A.supplierName, A.dateIssued, A.expectedDeliveryDate,B.itemNumber, C.description, B.quantity, B.currency, B.pricePerUnit, B.totalPrice, B.isFinished
FROM supplier_po A, supplier_order_items B, items C
WHERE A.supplierPONumber = B.supplierPONumber AND B.itemNumber = C.itemNumber
ORDER BY B.supplierOrderID desc;