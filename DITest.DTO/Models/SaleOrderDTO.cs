using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DITest.DTO.Models
{
    [Table("SaleOrder")]
    public class SaleOrderDTO
    {
        [Key]
        public int SaleOrderId { get; set; }

        public string FullName { get; set; }
        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }

        public virtual ICollection<SaleOrderItemDTO> SaleOrderItem { get; set; }
    }
}