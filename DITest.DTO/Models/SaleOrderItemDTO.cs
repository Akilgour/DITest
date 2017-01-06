using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DITest.DTO.Models
{
    [Table("SaleOrderItem")]
    public class SaleOrderItemDTO
    {
        [Key]
        public int SaleOrderItemId { get; set; }

        public int SaleOrderId { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int Quantity { get; set; }
    }
}