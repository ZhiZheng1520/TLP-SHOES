using System.ComponentModel.DataAnnotations;

namespace TLPShoes.Models
{
	public class Discount_Logic
	{
		[Key]
		public string dlu { get; set; }  // Primary Key for Discount Logic

		[Range(1, int.MaxValue, ErrorMessage = "Quantity must be a positive value.")]
		public int quantity { get; set; }  // Quantity of items for the discount

		[Range(0, 100, ErrorMessage = "Percentage must be between 0 and 100.")]
		public decimal percentage { get; set; }  // Discount percentage (e.g., 10, 20, etc.)
	}
}