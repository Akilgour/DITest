using DITest.DTO.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITest.Repository.Context
{
    public class DITestContext : DbContext
    {
        public DbSet<SaleOrderDTO> SaleOrder { get; set; }
        public DbSet<SaleOrderItemDTO> SaleOrderItem { get; set; }
    }
}