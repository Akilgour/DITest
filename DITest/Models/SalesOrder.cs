using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DITest.Models
{
    public class SalesOrder
    {
        public int SaleOrderId { get; set; }
        public string FullName { get; set; }
        [DisplayName("Line One")]
        [Required(ErrorMessage = "Line One is required")]
        public string AddressLineOne { get; set; }
        [DisplayName("Line Two")]
        [Required(ErrorMessage = "Line Two is required")]
        [StringLength(10, ErrorMessage = "Line Two cannot be longer than 10 characters.")]
        public string AddressLineTwo { get; set; }
        [DisplayName("Full Address")]
        public string FullAddress { get; set; }

       public List<SalesOrderItem> SaleOrderItem { get; set; }

    }
}