using DITest.DTO.Models;
using DITest.Repository.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITest.Repository.Migrations.SeedData
{

    public static class SaleOrderItem
    {
        public static void Seed(DITestContext context)
        {
            context.SaleOrderItem.AddOrUpdate(
               p => p.SaleOrderId,
              new SaleOrderItemDTO { SaleOrderItemId = 1, SaleOrderId = 1, Name = "Item 1", Cost = 1, Quantity = 6 },
              new SaleOrderItemDTO { SaleOrderItemId = 2, SaleOrderId = 1, Name = "Item 2", Cost = 2, Quantity = 7 },
              new SaleOrderItemDTO { SaleOrderItemId = 3, SaleOrderId = 1, Name = "Item 3", Cost = 3, Quantity = 8 },
              new SaleOrderItemDTO { SaleOrderItemId = 4, SaleOrderId = 1, Name = "Item 4", Cost = 4, Quantity = 9 },
              new SaleOrderItemDTO { SaleOrderItemId = 5, SaleOrderId = 1, Name = "Item 5", Cost = 5, Quantity = 10 }
            );
        }
    }
}
