using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITest.DTO.Models
{
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
