using DITest.DTO.Models;
using DITest.Repository.Context;
using DITtest.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITtest.Service.Services
{
   public class SalesOrderItemService : ISalesOrderItemService
    {
        private readonly DITestContext context;

        public SalesOrderItemService(DITestContext context)
        {
            this.context = context;
        }

        public SaleOrderItemDTO Save(SaleOrderItemDTO SaleOrderItemDTO)
        {
            context.Set<SaleOrderItemDTO>().AddOrUpdate(SaleOrderItemDTO);
            context.SaveChanges();
            return SaleOrderItemDTO;
        }

        public IEnumerable<SaleOrderItemDTO> GetBySaleOrderId(int saleOrderId)
        {
            return context.SaleOrderItem.Where(x => x.SaleOrderId == saleOrderId);
        }
    }
}
