using System.ComponentModel.DataAnnotations;

namespace TLPShoes.Models
{
	public class Discount_Logic
	{
		[Key]
		[Display(Name = "Discount Logic ID")]
		public string dlu { get; set; }  // Primary Key for Discount Logic

		[Range(1, int.MaxValue, ErrorMessage = "Quantity must be a positive value.")]
		[Display(Name = "Item Quantity")]
		public int quantity { get; set; }  // Quantity of items for the discount

		[Range(0, 100, ErrorMessage = "Percentage must be between 0 and 100.")]
		[Display(Name = "Discount Percentage")]
		public decimal percentage { get; set; }  // Discount percentage (e.g., 10, 20, etc.)
	}
}