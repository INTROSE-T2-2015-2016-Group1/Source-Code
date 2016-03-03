CREATE TABLE `s_po_list` (
  `s_po_number` varchar(10) NOT NULL,
  `c_po_number` varchar(10) NOT NULL,
  `s_po_date` varchar(20) NOT NULL,
  `s_company` varchar(20) NOT NULL,
  `part_number` varchar(10) NOT NULL,
  `s_quantity` int(10) NOT NULL,
  `s_price` int(10) NOT NULL,
  `s_price_per_unit` int(10) NOT NULL,
  `s_delivery_date` int(10) NOT NULL,
  PRIMARY KEY (`s_po_number`)
) 