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

        }
    }
}
