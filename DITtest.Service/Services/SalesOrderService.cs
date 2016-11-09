using DITest.DTO.Models;
using DITest.Repository.Context;
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
            using (var db = new DITestContext())
            {
                return db.SaleOrder.OrderBy(x => x.FullName).ToList();
            }
        }
    }
}
