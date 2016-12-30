﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITest.DTO.Models
{
    [Table("LargeObject")]
    public class LargeObjectDTO
    {
        [Key]
        public int LargeObjectId { get; set; }
        public string PropertyOne { get; set; }
        public string PropertyTwo { get; set; }
        public string PropertyThree { get; set; }
        public string PropertyFour { get; set; }
        public string PropertyFive { get; set; }
        public string PropertySix { get; set; }
        public string PropertySeven { get; set; }
        public int PropertyEight { get; set; }
        public bool PropertyNine { get; set; }
        public Guid PropertyTen { get; set; }
    }
}
