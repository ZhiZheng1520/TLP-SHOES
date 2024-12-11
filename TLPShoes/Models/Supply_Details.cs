using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TLPShoes.Models
{
	public class Supply_Details
	{
        [Key]
        public string sdu { get; set; }  // Primary Key for Supply Details

        [Required]
        public string sku { get; set; }  // Foreign Key to associate with SupplyForm

        [ForeignKey("sku")]  // Establishes Foreign Key relationship
        public Supply_Form Supply_Form { get; set; }  // Navigation property

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be a positive value.")]
        public int quantity { get; set; }  // Quantity of the item in stock

        [Required]
        [Range(7, 14, ErrorMessage = "Size must be between 7 and 14.")]
        [StringLength(10)]  // Adjust size length if needed
        public int size { get; set; }  // Size of the item (e.g., Small, Medium, Large)
    }
}
