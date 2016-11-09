using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITest.DTO.Models
{
    public class SaleOrderItemDTO
    {
        [Key]
        public int SaleOrderItemId { get; set; }
        public int SaleOrderId { get; set; }
        public string Name { get; set; }
        public string Cost { get; set; }
        public string Quantity { get; set; }
    }
}
