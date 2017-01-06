using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

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
        //  [foo( "Bar", "Baz")]
        public int Quantity { get; set; }

        [DisplayName("Bar DisplayName")]
        public string Bar { get; set; }

        [DisplayName("Baz DisplayName")]
        public string Baz { get; set; }
    }
}