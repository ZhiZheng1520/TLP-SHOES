using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TLPShoes.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int order_id { get; set; } // Primary Key

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string username { get; set; } // Foreign Key to User

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string item_name { get; set; } // Name of the item ordered

        [Required]
        public int quantity { get; set; } // Quantity of the item ordered

		[Required]
		public int size { get; set; } // Quantity of the item ordered

		[Required]
		[Column(TypeName = "decimal(10, 2)")]
		public decimal unit_price { get; set; } // Total price for the order

		[Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal total_price { get; set; } // Total price for the order

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string payment_method { get; set; } // Payment method (e.g., Credit Card, PayPal)
    }
}

