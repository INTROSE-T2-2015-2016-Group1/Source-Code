CREATE TABLE `c_po_list` (
  `c_po_number` varchar(10) NOT NULL,
  `c_po_date` varchar(20) NOT NULL,
  `c_company` varchar(20) NOT NULL,
  `part_number` varchar(10) NOT NULL,
  `c_quantity` int(10) NOT NULL,
  `c_price` int(10) NOT NULL,
  `c_price_per_unit` int(10) NOT NULL,
  `c_delivery_date` int(10) NOT NULL,
  PRIMARY KEY (`c_po_number`)
) 