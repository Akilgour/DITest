using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DITest.Models
{
    public class SalesOrderItem
    {
        public int SaleOrderItemId { get; set; }
        public int SaleOrderId { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int Quantity { get; set; }
    }
}