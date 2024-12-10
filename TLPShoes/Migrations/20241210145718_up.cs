using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TLPShoes.Migrations
{
    /// <inheritdoc />
    public partial class up : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Company", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Role", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2340819b-3085-4926-ad09-b2e8c646edab", 0, "New Balance", "d3e55862-1149-4c1c-b223-c0c5ca148c53", "newbalance.supplier@example.com", true, false, null, "NEWBALANCE.SUPPLIER@EXAMPLE.COM", "NEWBALANCE_SUPPLIER", "AQAAAAIAAYagAAAAEF56ccwXwh/pZBnAF638NBqe1Jeh/5hmEZITyczDMsw7ts6krVBsOSDTBQS+p3E3/w==", null, false, "Supplier", "0d0f0922-96f7-4918-99d3-4bb83dfd0053", false, "newbalance_supplier" },
                    { "298864af-f916-4270-b67b-23caecc42236", 0, "Self", "e452e11d-67b1-44ea-9c43-1690ed5de578", "peter.customer@example.com", true, false, null, "PETER.CUSTOMER@EXAMPLE.COM", "PETER_CUSTOMER", "AQAAAAIAAYagAAAAEN0KsF/kHzawxSVao6LXZV0JSOsUoJb5aj2ENIfZrXWT2C4mlqLhzgUCpvvdXvC26Q==", null, false, "Customer", "2ee187c0-d854-4e6e-966a-c5562305489f", false, "peter_customer" },
                    { "3a153572-91ef-4f15-b2cb-f30afdc61b30", 0, "Puma", "feed10a8-7e46-430a-8f61-c15a3c9d7e4f", "puma.supplier@example.com", true, false, null, "PUMA.SUPPLIER@EXAMPLE.COM", "PUMA_SUPPLIER", "AQAAAAIAAYagAAAAEIIQWiic0tdFBclt9Ae6cxRQrbpbtpOMavsiUSwwQiAVTcnhOYoXFboLuQpvF+bHrQ==", null, false, "Supplier", "49bc8a95-5651-401d-964b-54a1c38da391", false, "puma_supplier" },
                    { "40d361e1-1ec5-4f3c-8c7e-2c4eb4eef7b1", 0, "Innovative Tech Ltd.", "f5fb2a4c-60f2-4706-99d5-11adeb4eaf93", "sarah.manager@example.com", true, false, null, "SARAH.MANAGER@EXAMPLE.COM", "SARAH_MANAGER", "AQAAAAIAAYagAAAAEBe6ZfqEG058FYXetT6TbNcrzOsK4fXmMnZvzU0vBEEIKCmqbhE6G9SUYzIVa1TW+Q==", null, false, "Manager", "e4f0a402-d497-4f1a-8468-62c4e6293477", false, "sarah_manager" },
                    { "7b6130ca-dfe4-4189-8c19-7f42dba79543", 0, "Self", "a4a17e12-c654-44d4-87be-f0e3e252c74e", "mark.customer@example.com", true, false, null, "MARK.CUSTOMER@EXAMPLE.COM", "MARK_CUSTOMER", "AQAAAAIAAYagAAAAEGn3ebtj1RndcG27wzCG7yTqjmncLxJhXx4bLa4pDT7ihEWo3/sCLLjKX+VA3z5BQQ==", null, false, "Customer", "058db463-674c-49c3-9bc9-c07e69830321", false, "mark_customer" },
                    { "a00ad888-c09c-42b1-a602-f5e46ab93aa7", 0, "Digital Strategies Co.", "4968081c-5054-4ddd-a1ca-e35ca1e14b18", "john.manager@example.com", true, false, null, "JOHN.MANAGER@EXAMPLE.COM", "JOHN_MANAGER", "AQAAAAIAAYagAAAAEKmQPrGOcppESXN1X7oeIBoDIyEvsb2nJNcKhhjDBD9j/j4l3WGWqzWHMcckCqU72g==", null, false, "Manager", "d2397c4a-4e6f-4905-83cb-9a8729f90951", false, "john_manager" },
                    { "b3cd0ad6-242b-46a8-8976-f5ded35084f7", 0, "TechSolutions Inc.", "bc31b2d1-9465-4b52-a11d-b90f4cc3fc10", "alex.manager@example.com", true, false, null, "ALEX.MANAGER@EXAMPLE.COM", "ALEX_MANAGER", "AQAAAAIAAYagAAAAEAOnuDeFEGwlkWH8ERPgY60YafLA6iZPbj4pdyf99fJ3nQNLf/hgh/lho5I7mUO0oA==", null, false, "Manager", "ac867b98-5f05-4ac7-b0fc-4b7af7f24399", false, "alex_manager" },
                    { "b9daa899-0aa8-47b7-bb51-fb1a17f9022b", 0, "Nike", "64f48c84-cb31-4c07-881a-38438e484602", "nike.supplier@example.com", true, false, null, "NIKE.SUPPLIER@EXAMPLE.COM", "NIKE_SUPPLIER", "AQAAAAIAAYagAAAAEKlPCNxSJGLucV0buDiYuJRY/n5rECVzqh3s/NXJJc9solxroNPV/eAwLu9UVoqDmQ==", null, false, "Supplier", "7d384fd0-340b-4f4a-a7b5-8f29521248cf", false, "nike_supplier" },
                    { "bd718ee4-c181-4940-bad5-e4f34d596331", 0, "Under Armour", "3ffce650-2f77-4cde-8397-dfd50636e95c", "underarmour.supplier@example.com", true, false, null, "UNDERARMOUR.SUPPLIER@EXAMPLE.COM", "UNDERARMOUR_SUPPLIER", "AQAAAAIAAYagAAAAECY0gsXsMwS9iMlNiWQhWic+jJOXfiEcxbFXgOR9r3fYVuRdp+WXFfsmXDxHzT85EQ==", null, false, "Supplier", "ec326536-cfec-4df9-9de5-3fb16cde9965", false, "underarmour_supplier" },
                    { "cc336357-19ba-4b41-b22b-3097b4ede2ce", 0, "Self", "173c9781-2472-4ce1-a3f1-b33f67cd7034", "anna.customer@example.com", true, false, null, "ANNA.CUSTOMER@EXAMPLE.COM", "ANNA_CUSTOMER", "AQAAAAIAAYagAAAAEGlZKlxGAa969Jp72jqCJvqGPtNK+naIzbNqDYm/6IrRVC+JUX5svgKNs1XwHYeorg==", null, false, "Customer", "6f279373-d399-4ec1-8eee-080c39c67370", false, "anna_customer" },
                    { "da33737e-52e3-4406-a484-af7b51df80e9", 0, "Global Innovations", "ca4ee5e2-ad67-4cf4-8330-8f3bad7f8c4c", "david.manager@example.com", true, false, null, "DAVID.MANAGER@EXAMPLE.COM", "DAVID_MANAGER", "AQAAAAIAAYagAAAAEFGwqw/e0Y2li56zve0wu2IqKgvzKcovkL2ERXep4XO6KA/66YlncsHqkHHZdoOSzQ==", null, false, "Manager", "884ccd21-5531-4ab8-a00f-fe61329e03a0", false, "david_manager" },
                    { "e5104f1e-3760-46c3-8686-e0c582da5db9", 0, "NextGen Solutions", "803826ff-1098-4512-9f47-cbf54233ab1d", "emma.manager@example.com", true, false, null, "EMMA.MANAGER@EXAMPLE.COM", "EMMA_MANAGER", "AQAAAAIAAYagAAAAEAVDqnPmvt7XsI/2HcgkhRZkBlTe0fqvPYfEaTrI9j54i1o48ccMUNgW950EvXjXrA==", null, false, "Manager", "ed3feb5b-efd1-487a-aebc-01c3dfe205fd", false, "emma_manager" },
                    { "ed14289f-cadb-48db-b13c-a5173eb98486", 0, "Adidas", "aff70ff0-5790-4ecd-af7d-5244195bff14", "adidas.supplier@example.com", true, false, null, "ADIDAS.SUPPLIER@EXAMPLE.COM", "ADIDAS_SUPPLIER", "AQAAAAIAAYagAAAAEMXPey4OZkSvQ8yPDmnfujfcDH1bEHYiVmPvKpj+AQEPpL2HFy3AMm0Bo7C5Ah+jRw==", null, false, "Supplier", "e77969cd-35ca-4324-8bbc-b47f26709876", false, "adidas_supplier" },
                    { "f9bdd3ae-c302-43f7-8610-920aae0cd9dd", 0, "Self", "044d9543-48fa-488a-a1aa-0f833f319111", "jane.customer@example.com", true, false, null, "JANE.CUSTOMER@EXAMPLE.COM", "JANE_CUSTOMER", "AQAAAAIAAYagAAAAECsFZHHFvTIARpfvMQpUjIKALdNMImr3x6YA3HeEV2JskwJ4qtnHgZ811okXqmwPrQ==", null, false, "Customer", "97aee398-ba6d-4188-9609-d35b9711c030", false, "jane_customer" },
                    { "fc95e101-4e24-40d5-84dc-ebad807bfdda", 0, "Self", "810376df-0338-4962-bfd3-d2dab3e1def2", "lucy.customer@example.com", true, false, null, "LUCY.CUSTOMER@EXAMPLE.COM", "LUCY_CUSTOMER", "AQAAAAIAAYagAAAAEJ1e5hRhUw3EBCBeZeC4CrSxwuXeZBE0R1XRXZhiL01rWVSaLifrijTlaBwp/fJeJQ==", null, false, "Customer", "8fc917d1-3c60-43b4-80b1-57367d10208e", false, "lucy_customer" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
