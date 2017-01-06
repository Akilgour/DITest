using DITest.DTO.Models;
using DITest.Repository.Context;
using System.Data.Entity.Migrations;

namespace DITest.Repository.Migrations.SeedData
{
    public static class SaleOrder
    {
        public static void Seed(DITestContext context)
        {
            context.SaleOrder.AddOrUpdate(
               p => p.SaleOrderId,
              new SaleOrderDTO { SaleOrderId = 1, FullName = "Mr A", AddressLineOne = "1 A Road", AddressLineTwo = "A Town" },
              new SaleOrderDTO { SaleOrderId = 2, FullName = "Mr B", AddressLineOne = "2 B Road", AddressLineTwo = "B Town" },
              new SaleOrderDTO { SaleOrderId = 3, FullName = "Mr C", AddressLineOne = "3 C Road", AddressLineTwo = "C Town" },
              new SaleOrderDTO { SaleOrderId = 4, FullName = "Mr D", AddressLineOne = "4 D Road", AddressLineTwo = "D Town" },
              new SaleOrderDTO { SaleOrderId = 5, FullName = "Mr E", AddressLineOne = "5 E Road", AddressLineTwo = "E Town" }
            );
        }
    }
}