using DITest.DTO.Models;
using System.Data.Entity;

namespace DITest.Repository.Context
{
    public class DITestContext : DbContext
    {
        public DbSet<SaleOrderDTO> SaleOrder { get; set; }
        public DbSet<SaleOrderItemDTO> SaleOrderItem { get; set; }
        public DbSet<LargeObjectDTO> LargeObject { get; set; }
    }
}