using TLPShoes.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using TLPShoes.Areas.Identity.Data;

namespace TLPShoes.Data
{
    public class TLPShoesContext : IdentityDbContext<TLPShoesUser>
    {
        public TLPShoesContext(DbContextOptions<TLPShoesContext> options)
            : base(options)
        {
        }

        public DbSet<Supply_Form> Supply_Form { get; set; }
        public DbSet<Notification> Notification { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Users table data
            var hasher = new PasswordHasher<TLPShoesUser>();

            modelBuilder.Entity<TLPShoesUser>().HasData(
                // Manager 1
                new TLPShoesUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "alex_manager",
                    NormalizedUserName = "ALEX_MANAGER",
                    Email = "alex.manager@example.com",
                    NormalizedEmail = "ALEX.MANAGER@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Manager123!"),
                    Company = "TechSolutions Inc.",
                    Role = "Manager"
                },
                // Manager 2
                new TLPShoesUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "sarah_manager",
                    NormalizedUserName = "SARAH_MANAGER",
                    Email = "sarah.manager@example.com",
                    NormalizedEmail = "SARAH.MANAGER@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Manager123!"),
                    Company = "Innovative Tech Ltd.",
                    Role = "Manager"
                },
                // Manager 3
                new TLPShoesUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "john_manager",
                    NormalizedUserName = "JOHN_MANAGER",
                    Email = "john.manager@example.com",
                    NormalizedEmail = "JOHN.MANAGER@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Manager123!"),
                    Company = "Digital Strategies Co.",
                    Role = "Manager"
                },
                // Manager 4
                new TLPShoesUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "emma_manager",
                    NormalizedUserName = "EMMA_MANAGER",
                    Email = "emma.manager@example.com",
                    NormalizedEmail = "EMMA.MANAGER@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Manager123!"),
                    Company = "NextGen Solutions",
                    Role = "Manager"
                },
                // Manager 5
                new TLPShoesUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "david_manager",
                    NormalizedUserName = "DAVID_MANAGER",
                    Email = "david.manager@example.com",
                    NormalizedEmail = "DAVID.MANAGER@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Manager123!"),
                    Company = "Global Innovations",
                    Role = "Manager"
                },

                // Customer 1
                new TLPShoesUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "jane_customer",
                    NormalizedUserName = "JANE_CUSTOMER",
                    Email = "jane.customer@example.com",
                    NormalizedEmail = "JANE.CUSTOMER@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Customer123!"),
                    Company = "Self",
                    Role = "Customer"
                },
                // Customer 2
                new TLPShoesUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "mark_customer",
                    NormalizedUserName = "MARK_CUSTOMER",
                    Email = "mark.customer@example.com",
                    NormalizedEmail = "MARK.CUSTOMER@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Customer123!"),
                    Company = "Self",
                    Role = "Customer"
                },
                // Customer 3
                new TLPShoesUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "lucy_customer",
                    NormalizedUserName = "LUCY_CUSTOMER",
                    Email = "lucy.customer@example.com",
                    NormalizedEmail = "LUCY.CUSTOMER@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Customer123!"),
                    Company = "Self",
                    Role = "Customer"
                },
                // Customer 4
                new TLPShoesUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "peter_customer",
                    NormalizedUserName = "PETER_CUSTOMER",
                    Email = "peter.customer@example.com",
                    NormalizedEmail = "PETER.CUSTOMER@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Customer123!"),
                    Company = "Self",
                    Role = "Customer"
                },
                // Customer 5
                new TLPShoesUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "anna_customer",
                    NormalizedUserName = "ANNA_CUSTOMER",
                    Email = "anna.customer@example.com",
                    NormalizedEmail = "ANNA.CUSTOMER@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Customer123!"),
                    Company = "Self",
                    Role = "Customer"
                },

                // Supplier 1
                new TLPShoesUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "adidas_supplier",
                    NormalizedUserName = "ADIDAS_SUPPLIER",
                    Email = "adidas.supplier@example.com",
                    NormalizedEmail = "ADIDAS.SUPPLIER@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Supplier123!"),
                    Company = "Adidas",
                    Role = "Supplier"
                },
                // Supplier 2
                new TLPShoesUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "nike_supplier",
                    NormalizedUserName = "NIKE_SUPPLIER",
                    Email = "nike.supplier@example.com",
                    NormalizedEmail = "NIKE.SUPPLIER@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Supplier123!"),
                    Company = "Nike",
                    Role = "Supplier"
                },
                // Supplier 3
                new TLPShoesUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "puma_supplier",
                    NormalizedUserName = "PUMA_SUPPLIER",
                    Email = "puma.supplier@example.com",
                    NormalizedEmail = "PUMA.SUPPLIER@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Supplier123!"),
                    Company = "Puma",
                    Role = "Supplier"
                },
                // Supplier 4
                new TLPShoesUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "underarmour_supplier",
                    NormalizedUserName = "UNDERARMOUR_SUPPLIER",
                    Email = "underarmour.supplier@example.com",
                    NormalizedEmail = "UNDERARMOUR.SUPPLIER@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Supplier123!"),
                    Company = "Under Armour",
                    Role = "Supplier"
                },
                // Supplier 5
                new TLPShoesUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "newbalance_supplier",
                    NormalizedUserName = "NEWBALANCE_SUPPLIER",
                    Email = "newbalance.supplier@example.com",
                    NormalizedEmail = "NEWBALANCE.SUPPLIER@EXAMPLE.COM",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Supplier123!"),
                    Company = "New Balance",
                    Role = "Supplier"
                }
             );

            // Seed data for Notification
            modelBuilder.Entity<Notification>().HasData(
                new Notification
                {
                    notification_id = "NID-001",  // Primary Key for Notification in the format NID-001
                    sender_username = "001",  // Foreign Key to the Users table (Sender)
                    receiver_username = "002",  // Foreign Key to the Users table (Receiver)
                    message = "SK-001 - Your subsmision has been declide. As quantity not enough, it has to be 100",  // Example message
                    status = "Unread",  // Status of the notification
                    date_created = DateTime.Parse("2024-12-10 15:42:34")  // Date when the notification was created
                },
                new Notification
                {
                    notification_id = "NID-002",  // Primary Key for Notification in the format NID-001
                    sender_username = "001",  // Foreign Key to the Users table (Sender)
                    receiver_username = "002",  // Foreign Key to the Users table (Receiver)
                    message = "SK-002 - Your subsmision has been approved.",  // Example message
                    status = "Unread",  // Status of the notification
                    date_created = DateTime.Parse("2024-12-10 15:42:34")  // Date when the notification was created
                },
                new Notification
                {
                    notification_id = "NID-003",  // Primary Key for Notification in the format NID-002
                    sender_username = "003",  // Foreign Key to the Users table (Sender)
                    receiver_username = "004",  // Foreign Key to the Users table (Receiver)
                    message = "SK-002 - Your subsmision has been approved.",  // Example message
                    status = "Unread",  // Status of the notification
                    date_created = DateTime.Parse("2024-12-11 09:30:00")  // Date when the notification was created
                },
                new Notification
                {
                    notification_id = "NID-004",  // Primary Key for Notification in the format NID-003
                    sender_username = "005",  // Foreign Key to the Users table (Sender)
                    receiver_username = "001",  // Foreign Key to the Users table (Receiver)
                    message = "SK-003 - Your subsmision has been declined.",  // Example message
                    status = "Read",  // Status of the notification
                    date_created = DateTime.Parse("2024-12-12 10:15:20")  // Date when the notification was created
                }
            );

			// Add Seed data here
			modelBuilder.Entity<Supply_Form>().HasData(
				new Supply_Form
				{
					sku = "SK-001",
					username = "001",
					item_name = "Ultraboost",
					price = 200,
					category = "sport",
					gender = "female",
					quantity = 100,
					size = 7,
					image_path = "~/assets/images/item-6.jpg",
					date_created = DateTime.Parse("2024-12-10 15:42:34"),
					approval_status = "declined"
				},
				new Supply_Form
				{
					sku = "SK-002",
					username = "002",
					item_name = "Jordan",
					price = 300,
					category = "dress",
					gender = "female",
					quantity = 100,
					size = 7,
					image_path = "~/assets/images/item-7.jpg",
					date_created = DateTime.Parse("2024-12-11 10:25:47"),
					approval_status = "approved"
				},
				new Supply_Form
				{
					sku = "SK-003",
					username = "003",
					item_name = "Nike Scandal",
					price = 800,
					category = "casual",
					gender = "female",
					quantity = 100,
					size = 7,
					image_path = "~/assets/images/item-8.jpg",
					date_created = DateTime.Parse("2024-12-12 08:13:22"),
					approval_status = "pending"
				},
				new Supply_Form
				{
					sku = "SK-004",
					username = "004",
					item_name = "adidas",
					price = 75,
					category = "casual",
					gender = "female",
					quantity = 100,
					size = 7,
					image_path = "~/assets/images/item-14.jpg",
					date_created = DateTime.Parse("2024-12-13 18:50:05"),
					approval_status = "approved"
				},
				new Supply_Form
				{
					sku = "SK-005",
					username = "005",
					item_name = "T-shirt",
					price = 25.00m,
					category = "dress",
					gender = "female",
					quantity = 100,
					size = 7,
					image_path = "~/assets/images/item-13.jpg",
					date_created = DateTime.Parse("2024-12-14 20:34:59"),
					approval_status = "pending"
				}
			);

			// Seed data for Discount_Logic
			modelBuilder.Entity<Discount_Logic>().HasData(
                new Discount_Logic
                {
                    dlu = "DL-001", // You can adjust this to match your unique primary key strategy
                    quantity = 100,
                    percentage = 10
                },
                new Discount_Logic
                {
                    dlu = "DL-002", // You can adjust this to match your unique primary key strategy
                    quantity = 1000,
                    percentage = 30
                },
                new Discount_Logic
                {
                    dlu = "DL-003", // You can adjust this to match your unique primary key strategy
                    quantity = 10000,
                    percentage = 50
                }
            );
        }
    }
}
