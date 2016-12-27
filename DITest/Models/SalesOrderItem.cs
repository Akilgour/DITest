﻿using DITest.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DITest.Models
{
    public class SalesOrderItem
    {
        public int SaleOrderItemId { get; set; }
        public int SaleOrderId { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Cost DisplayName")]
        public int Cost { get; set; }
        //[RequiredIfOtherFieldIsHasVale("Cost")]
        [DisplayName("Quantity DisplayName")]
        [foo(20, "Bar", "Baz", ErrorMessage = "The combined minimum length of the Foo, Bar and Baz properties should be longer than 20")]
        public int Quantity { get; set; }
        [DisplayName("Bar DisplayName")]
        public string Bar { get; set; }
        [DisplayName("Baz DisplayName")]
        public string Baz { get; set; }
    }
}