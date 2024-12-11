using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TLPShoes.Models
{
	public class Notification
	{
		[Key]
		public string notification_id { get; set; }  // Primary Key for Notification

		// Need to change to FK after this
		[Required]
		public string sender_username { get; set; }  // Foreign Key to the Users table (Sender)

		// Need to change to FK after this
		[Required]
		public string receiver_username { get; set; }  // Foreign Key to the Users table (Receiver)

		[Required]
		[StringLength(500, ErrorMessage = "Message cannot exceed 500 characters.")]
		public string message { get; set; }  // Message content of the notification

		[Required]
		[StringLength(20, ErrorMessage = "Status cannot exceed 20 characters.")]
		public string status { get; set; }  // Status of the notification (e.g., "Read", "Unread")

		[Required]
		public DateTime date_created { get; set; }  // The date when the notification was created

	}
}
