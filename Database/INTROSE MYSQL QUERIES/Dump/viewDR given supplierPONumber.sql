select delivery_receipts.*
from delivery_receipts,  supplier_po
where delivery_receipts.supplierPONumber = supplier_po.supplierPONumber;