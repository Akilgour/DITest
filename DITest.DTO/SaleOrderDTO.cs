using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITest.DTO
{
    public class SaleOrderDTO
    {
        public int SaleOrderId { get; set; }
        public string FullName { get; set; }
        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }

    }
}
