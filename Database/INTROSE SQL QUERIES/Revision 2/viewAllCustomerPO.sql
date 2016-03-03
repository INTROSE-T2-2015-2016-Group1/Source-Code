SELECT A.customerPONumber, A.customerName, A.dateIssued, A.expectedDeliveryDate, B.itemNumber, C.description, B.quantity, B.currency, B.pricePerUnit, B.totalPrice, B.isFinished
FROM customer_po A, customer_order_items B, items C
WHERE A.customerPONumber = B.customerPONumber AND B.itemNumber = C.itemNumber
ORDER BY B.customerOrderID desc;