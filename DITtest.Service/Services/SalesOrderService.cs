using DITest.DTO;
using DITest.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITest.Service.Services
{
    public class SalesOrderService : ISalesOrderService
    {
        public IEnumerable<SaleOrderDTO> GetAllSaleOrder()
        {
            var list = new List<SaleOrderDTO>();
            list.Add(new SaleOrderDTO() { SaleOrderId = 1, FullName = "x1", AddressLineOne = "A", AddressLineTwo = "B" });
            list.Add(new SaleOrderDTO() { SaleOrderId = 2, FullName = "y1", AddressLineOne = "C", AddressLineTwo = "D" });
            list.Add(new SaleOrderDTO() { SaleOrderId = 3, FullName = "z1", AddressLineOne = "D", AddressLineTwo = "E" });

            return list;

        }
    }
}
