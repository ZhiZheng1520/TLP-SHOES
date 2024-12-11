using System.ComponentModel.DataAnnotations;
using TLPShoes.Models;
using System;
using System.Collections.Generic;

namespace TLPShoes.Models
{
	public class Supply_Form
	{
        [Key]
        public string sku { get; set; }  // Primary Key for the item

        // Need to Change to FK when Merged
        [Required]
        public string username { get; set; }  // Foreign Key to associate with a User/Customer

        [Required]
        [StringLength(100)]
        public string item_name { get; set; }  // Name of the item

        [Range(0, double.MaxValue, ErrorMessage = "Price must be a positive value.")]
        public decimal price { get; set; }  // Price of the item

        [Required]
        [StringLength(50)]
        public string category { get; set; }  // Category of the item (e.g., Electronics, Clothing)

        [StringLength(255)]  // Optional: Adjust the length as needed
        public string image_path { get; set; }  // Path to the image associated with the item

        [Required]
        public DateTime date_created { get; set; }  // Date when the item was created

        [Required]
        [StringLength(20)]
        public string approval_status { get; set; }  // Approval status of the item (e.g., Pending, Approved)

        // Navigation property for related Supply_Details
        public ICollection<Supply_Details> Supply_Details { get; set; }  // One-to-Many relationship
    }
}
