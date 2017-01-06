using DITest.DTO.Models;
using DITest.Repository.Context;
using DITest.Service.Services.Interfaces;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DITest.Service.Services
{
    public class SalesOrderService : ISalesOrderService
    {
        private readonly DITestContext context;

        public SalesOrderService(DITestContext context)
        {
            this.context = context;
        }

        public IEnumerable<SaleOrderDTO> GetAllSaleOrder()
        {
            return context.SaleOrder.OrderBy(x => x.FullName).ToList();
        }

        public SaleOrderDTO GetSaleOrderById(int saleOrderId)
        {
            return context.SaleOrder.Single(x => x.SaleOrderId == saleOrderId);
        }

        public SaleOrderDTO Save(SaleOrderDTO saleOrderDTO)
        {
            context.Set<SaleOrderDTO>().AddOrUpdate(saleOrderDTO);
            context.SaveChanges();
            return saleOrderDTO;
        }

        public void Delete(int saleOrderId)
        {
            context.Set<SaleOrderDTO>().Remove(context.SaleOrder.Single(x => x.SaleOrderId == saleOrderId));
            context.SaveChanges();
        }
    }
}