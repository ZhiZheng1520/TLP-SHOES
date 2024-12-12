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
                name: "Discount_Logic",
                columns: table => new
                {
                    dlu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    percentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discount_Logic", x => x.dlu);
                });

            migrationBuilder.CreateTable(
                name: "Inventory",
                columns: table => new
                {
                    ivt = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    item_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    category = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    gender = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    size = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    image_path = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    approval_status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventory", x => x.ivt);
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    notification_id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    sender_username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    receiver_username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    message = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.notification_id);
                });

            migrationBuilder.CreateTable(
                name: "Supply_Form",
                columns: table => new
                {
                    sku = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    item_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    category = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    gender = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    size = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    image_path = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    date_created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    approval_status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supply_Form", x => x.sku);
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
                    { "00ddae97-843c-49fe-ae97-e37dfa45a38e", 0, "Adidas", "8ee8d850-0aac-44c3-ab07-01f4401f2adc", "adidas.supplier@example.com", true, false, null, "ADIDAS.SUPPLIER@EXAMPLE.COM", "ADIDAS_SUPPLIER", "AQAAAAIAAYagAAAAEGY5KZrCTRtxlhYv7u5SqO3qybK5wZPdBlFeCjXQkYrltYvO0/brRyZfkCcZ3Yxpww==", null, false, "Supplier", "f97c266d-5a24-420b-8cdb-67bfcdb0ac73", false, "adidas_supplier" },
                    { "043d1feb-a2e1-4d62-a2b8-f2d610b2daa6", 0, "Innovative Tech Ltd.", "9a69ded2-df4e-497f-9509-90cc8f9b9334", "sarah.manager@example.com", true, false, null, "SARAH.MANAGER@EXAMPLE.COM", "SARAH_MANAGER", "AQAAAAIAAYagAAAAEAfUVWyfBJswIJ1LSH5ED7KexMn/p8k7RhAmrGfRmowbceA9lSDWiSaTMuKf+qQUaA==", null, false, "Manager", "f6e136a1-e67b-41b4-b551-9f9d2a856802", false, "sarah_manager" },
                    { "1c89bd90-78b6-4129-987e-16bb4ab86f6e", 0, "Self", "27abc3dd-1e1d-4986-8134-c04053f1f442", "lucy.customer@example.com", true, false, null, "LUCY.CUSTOMER@EXAMPLE.COM", "LUCY_CUSTOMER", "AQAAAAIAAYagAAAAENV9NyaXVx7eCf9YjEX8xv+4d/Fm/QkToPuPMmecuV4ji7nkEqP9sx6Fod7Kgez3XA==", null, false, "Customer", "94fbd67a-27af-4f58-b608-4e4c12e4f13e", false, "lucy_customer" },
                    { "218a4c6e-69a3-44e8-80cb-7bc8a3ae5d6e", 0, "Under Armour", "530d4a35-bf47-4297-9542-8c78f4d48042", "underarmour.supplier@example.com", true, false, null, "UNDERARMOUR.SUPPLIER@EXAMPLE.COM", "UNDERARMOUR_SUPPLIER", "AQAAAAIAAYagAAAAEPqPM84JowMqAT99toUiFSdxQquzLSvyq1YYoGdN0ahRrTuxnT4ln4AakNZLZC8GmA==", null, false, "Supplier", "d7f75c65-c5df-4393-abaf-997cac61888b", false, "underarmour_supplier" },
                    { "2494b3bc-2e79-4344-915b-5a070fcf2361", 0, "New Balance", "e6b50299-79ca-4fca-bddf-b472d47248a3", "newbalance.supplier@example.com", true, false, null, "NEWBALANCE.SUPPLIER@EXAMPLE.COM", "NEWBALANCE_SUPPLIER", "AQAAAAIAAYagAAAAECVrkQufNNbuaDXApH4iJkU1s15n+qIgxiNCY5X6wtZy+60vGfT7ko+esKkcpufl5g==", null, false, "Supplier", "eefe7424-f4e4-44e3-a0f7-c68b1216d7b9", false, "newbalance_supplier" },
                    { "2d5d4e50-34b6-441d-9e9a-ee67abdf5ecd", 0, "Puma", "1e9be0c3-73ce-43b0-912c-3a047d934cbd", "puma.supplier@example.com", true, false, null, "PUMA.SUPPLIER@EXAMPLE.COM", "PUMA_SUPPLIER", "AQAAAAIAAYagAAAAEEwrIeethOrz8vjAeExj0P4sTbEsjRtb5ziiTNzBTKLIyuQwWmhzudGsNM7nLN+DQw==", null, false, "Supplier", "d2fcf092-193d-4d03-b95a-6e42357f3119", false, "puma_supplier" },
                    { "554dc4ba-59ba-4e0b-a6e8-b36b8db0e785", 0, "Self", "a6ee5d7e-9651-48ed-923a-2d05d0514a99", "anna.customer@example.com", true, false, null, "ANNA.CUSTOMER@EXAMPLE.COM", "ANNA_CUSTOMER", "AQAAAAIAAYagAAAAEBjMpAueSqpdsyECUEa729Z6yJaNPJcCFyk0llgl4tNAjzMuCqEJlj9D5h4DIPntyw==", null, false, "Customer", "2891ef06-8748-4c4d-aac9-3e9817168831", false, "anna_customer" },
                    { "7507aae8-d9df-4d2b-ae82-e552e5c71bb4", 0, "Self", "6e0fd450-bec5-4c60-af2f-28c50507a625", "mark.customer@example.com", true, false, null, "MARK.CUSTOMER@EXAMPLE.COM", "MARK_CUSTOMER", "AQAAAAIAAYagAAAAEKStQVBT1thfnRwexxqDO/v3D8BeeuiFFSCtOiv2ugInH3vjsiApvz6fwNMdNVC5eA==", null, false, "Customer", "84395a92-2b23-4000-b0d6-bc843ae00def", false, "mark_customer" },
                    { "815e9417-8100-4e5e-8a75-9f96face9e66", 0, "Self", "d20212f2-7230-4c8e-ae36-00a129039798", "peter.customer@example.com", true, false, null, "PETER.CUSTOMER@EXAMPLE.COM", "PETER_CUSTOMER", "AQAAAAIAAYagAAAAELHwCA05pfpxUBd4iTgvOZdtYCrFYOQA/ZyD4JYGMrFSccVe5yhxCqlf6Ge3CTHJCw==", null, false, "Customer", "3b8efd54-54f7-4d99-a126-ad25ddcb8e10", false, "peter_customer" },
                    { "85aae980-e206-4b2a-9771-6006214aa87d", 0, "Global Innovations", "c09480b5-cbd7-4104-b62d-926d1f7d11f5", "david.manager@example.com", true, false, null, "DAVID.MANAGER@EXAMPLE.COM", "DAVID_MANAGER", "AQAAAAIAAYagAAAAECVl+pW4jBBFGYRzuLSFpfWxyc/Yod2CqV0ERCY/yjGSgYyTun0Ed8Tez0Hah6AP8A==", null, false, "Manager", "5b6d7f37-f585-47c6-b521-7849c45911c9", false, "david_manager" },
                    { "86a47f30-e780-4ab6-b62d-56658eb1cb26", 0, "TechSolutions Inc.", "fee4af98-a1fe-4e6e-bfac-61dd7dae7266", "alex.manager@example.com", true, false, null, "ALEX.MANAGER@EXAMPLE.COM", "ALEX_MANAGER", "AQAAAAIAAYagAAAAEGcUpwVrI487t1/TsWogANznY6T24dZ3w4cprR+PBHXxvGD5kuCCFOB+yww1zFmO1w==", null, false, "Manager", "16b7e0f6-488e-4671-a286-bf27d540eada", false, "alex_manager" },
                    { "ad00643d-2728-4e4f-9219-372ace5af77d", 0, "Digital Strategies Co.", "888c33b9-c792-4266-91bc-5e32b2ae5a56", "john.manager@example.com", true, false, null, "JOHN.MANAGER@EXAMPLE.COM", "JOHN_MANAGER", "AQAAAAIAAYagAAAAEPNqOM/uH2QPCAXRXwTpnw0zR87wn+DKt0wReK/k2ScAICkGC7ecVUTZUgRI7/y73w==", null, false, "Manager", "5d7cccf9-bfa2-47e3-a41f-4bc6b88ff690", false, "john_manager" },
                    { "b6697626-79fb-4799-838c-9675219093c4", 0, "Self", "f9689331-6fba-4fb4-a52e-609e153283ea", "jane.customer@example.com", true, false, null, "JANE.CUSTOMER@EXAMPLE.COM", "JANE_CUSTOMER", "AQAAAAIAAYagAAAAEAnl7muGD++ftiXjrlRICYUyHLruUNL8bRRMXP3xBLvoIKuYk5enDwOPmqF8nbWHSQ==", null, false, "Customer", "749bccb9-7830-4c30-8714-2c11eba94428", false, "jane_customer" },
                    { "bc559606-4603-4807-9ec7-1f4f1daa3b21", 0, "NextGen Solutions", "dfc6e43f-98d6-4665-8c0e-d207635ce0ae", "emma.manager@example.com", true, false, null, "EMMA.MANAGER@EXAMPLE.COM", "EMMA_MANAGER", "AQAAAAIAAYagAAAAEEw5vr0fpHfpibfwBSwD9TWUFeQZlkM2KNbLK82AEmiBRt+wBTo/xt/gO7w2HaEjdA==", null, false, "Manager", "9cb84768-1f01-4658-977f-734a28f5f4ab", false, "emma_manager" },
                    { "ee9c32f2-23e2-4299-b30f-d4ee6d12ba4f", 0, "Nike", "976cb2f5-5b18-4e1a-93a8-8f94f3b27d3f", "nike.supplier@example.com", true, false, null, "NIKE.SUPPLIER@EXAMPLE.COM", "NIKE_SUPPLIER", "AQAAAAIAAYagAAAAEAsYvKr89lJ68WWSkEgQpZ30M63WyYBBLcJ9rl3wc/0vZgXwWCEkWjUpKDfMDUhTvg==", null, false, "Supplier", "6f7b1758-7589-428d-9a2d-790adedb5ba6", false, "nike_supplier" }
                });

            migrationBuilder.InsertData(
                table: "Discount_Logic",
                columns: new[] { "dlu", "percentage", "quantity" },
                values: new object[,]
                {
                    { "DL-001", 10m, 100 },
                    { "DL-002", 30m, 1000 },
                    { "DL-003", 50m, 10000 }
                });

            migrationBuilder.InsertData(
                table: "Inventory",
                columns: new[] { "ivt", "approval_status", "category", "date_created", "description", "gender", "image_path", "item_name", "price", "quantity", "size", "username" },
                values: new object[,]
                {
                    { "SK-001", "declined", "sport", new DateTime(2024, 12, 10, 15, 42, 34, 0, DateTimeKind.Unspecified), "Best shoe in the world", "female", "~/assets/images/item-6.jpg", "Ultraboost", 200m, 100, 7, "001" },
                    { "SK-002", "approved", "dress", new DateTime(2024, 12, 11, 10, 25, 47, 0, DateTimeKind.Unspecified), "Best shoe in the world", "female", "~/assets/images/item-7.jpg", "Jordan", 300m, 100, 7, "002" },
                    { "SK-003", "pending", "casual", new DateTime(2024, 12, 12, 8, 13, 22, 0, DateTimeKind.Unspecified), "Best shoe in the world", "female", "~/assets/images/item-8.jpg", "Nike Scandal", 800m, 100, 7, "003" },
                    { "SK-004", "approved", "casual", new DateTime(2024, 12, 13, 18, 50, 5, 0, DateTimeKind.Unspecified), "Best shoe in the world", "female", "~/assets/images/item-14.jpg", "adidas", 75m, 100, 7, "004" },
                    { "SK-005", "pending", "dress", new DateTime(2024, 12, 14, 20, 34, 59, 0, DateTimeKind.Unspecified), "Best shoe in the world", "female", "~/assets/images/item-13.jpg", "T-shirt", 25.00m, 100, 7, "005" }
                });

            migrationBuilder.InsertData(
                table: "Notification",
                columns: new[] { "notification_id", "date_created", "message", "receiver_username", "sender_username", "status" },
                values: new object[,]
                {
                    { "NID-001", new DateTime(2024, 12, 10, 15, 42, 34, 0, DateTimeKind.Unspecified), "SK-001 - Your subsmision has been declide. As quantity not enough, it has to be 100", "002", "001", "Unread" },
                    { "NID-002", new DateTime(2024, 12, 10, 15, 42, 34, 0, DateTimeKind.Unspecified), "SK-002 - Your subsmision has been approved.", "002", "001", "Unread" },
                    { "NID-003", new DateTime(2024, 12, 11, 9, 30, 0, 0, DateTimeKind.Unspecified), "SK-002 - Your subsmision has been approved.", "004", "003", "Unread" },
                    { "NID-004", new DateTime(2024, 12, 12, 10, 15, 20, 0, DateTimeKind.Unspecified), "SK-003 - Your subsmision has been declined.", "001", "005", "Read" }
                });

            migrationBuilder.InsertData(
                table: "Supply_Form",
                columns: new[] { "sku", "approval_status", "category", "date_created", "description", "gender", "image_path", "item_name", "price", "quantity", "size", "username" },
                values: new object[,]
                {
                    { "SK-001", "declined", "sport", new DateTime(2024, 12, 10, 15, 42, 34, 0, DateTimeKind.Unspecified), "Best shoe in the world", "female", "~/assets/images/item-6.jpg", "Ultraboost", 200m, 100, 7, "001" },
                    { "SK-002", "approved", "dress", new DateTime(2024, 12, 11, 10, 25, 47, 0, DateTimeKind.Unspecified), "Best shoe in the world", "female", "~/assets/images/item-7.jpg", "Jordan", 300m, 100, 7, "002" },
                    { "SK-003", "pending", "casual", new DateTime(2024, 12, 12, 8, 13, 22, 0, DateTimeKind.Unspecified), "Best shoe in the world", "female", "~/assets/images/item-8.jpg", "Nike Scandal", 800m, 100, 7, "003" },
                    { "SK-004", "approved", "casual", new DateTime(2024, 12, 13, 18, 50, 5, 0, DateTimeKind.Unspecified), "Best shoe in the world", "female", "~/assets/images/item-14.jpg", "adidas", 75m, 100, 7, "004" },
                    { "SK-005", "pending", "dress", new DateTime(2024, 12, 14, 20, 34, 59, 0, DateTimeKind.Unspecified), "Best shoe in the world", "female", "~/assets/images/item-13.jpg", "T-shirt", 25.00m, 100, 7, "005" }
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
                name: "Discount_Logic");

            migrationBuilder.DropTable(
                name: "Inventory");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "Supply_Form");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
