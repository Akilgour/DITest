using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DITest.Models
{
    public class SalesOrder
    {
        public int SaleOrderId { get; set; }
        public string FullName { get; set; }
        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }
        public string FullAddress { get; set; }
    }
}