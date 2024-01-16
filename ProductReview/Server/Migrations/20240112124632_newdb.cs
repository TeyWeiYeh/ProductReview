﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductReview.Server.Migrations
{
    /// <inheritdoc />
    public partial class newdb : Migration
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
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "Keys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Use = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Algorithm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsX509Certificate = table.Column<bool>(type: "bit", nullable: false),
                    DataProtected = table.Column<bool>(type: "bit", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                    table.ForeignKey(
                        name: "FK_News_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Favourites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favourites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favourites_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Favourites_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Links",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlatformName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Links_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<int>(type: "int", nullable: false),
                    BatteryLife = table.Column<int>(type: "int", nullable: false),
                    Performance = table.Column<int>(type: "int", nullable: false),
                    UserFriendly = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Reviews_ReviewId",
                        column: x => x.ReviewId,
                        principalTable: "Reviews",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "41c88b26-250e-4afd-a5df-04441bf9e9b4", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEEHAZ3mhBGKo1EqRWpYetfl+nxmbj4wcMvhL+ahUn3JqVm0Bmz9lK5+h3Gh6k7v/3Q==", null, false, "7a08ea41-6b11-49a1-8685-1f849d4c3663", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
<<<<<<<< HEAD:ProductReview/Server/Migrations/20240112041912_newdb.cs
                    { 1, "System", new DateTime(2024, 1, 12, 12, 19, 12, 260, DateTimeKind.Local).AddTicks(8397), new DateTime(2024, 1, 12, 12, 19, 12, 260, DateTimeKind.Local).AddTicks(8407), "Phones", "System" },
                    { 2, "System", new DateTime(2024, 1, 12, 12, 19, 12, 260, DateTimeKind.Local).AddTicks(8409), new DateTime(2024, 1, 12, 12, 19, 12, 260, DateTimeKind.Local).AddTicks(8410), "Laptops", "System" }
========
                    { 1, "System", new DateTime(2024, 1, 12, 20, 46, 32, 748, DateTimeKind.Local).AddTicks(875), new DateTime(2024, 1, 12, 20, 46, 32, 748, DateTimeKind.Local).AddTicks(887), "Phones", "System" },
                    { 2, "System", new DateTime(2024, 1, 12, 20, 46, 32, 748, DateTimeKind.Local).AddTicks(891), new DateTime(2024, 1, 12, 20, 46, 32, 748, DateTimeKind.Local).AddTicks(892), "Laptops", "System" }
>>>>>>>> eb3fbf48bb3251b2483615ac904a14539b2e81d1:ProductReview/Server/Migrations/20240112124632_newdb.cs
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Description", "ReviewId", "UpdatedBy" },
                values: new object[,]
                {
<<<<<<<< HEAD:ProductReview/Server/Migrations/20240112041912_newdb.cs
                    { 1, "System", new DateTime(2024, 1, 12, 12, 19, 12, 260, DateTimeKind.Local).AddTicks(8751), new DateTime(2024, 1, 12, 12, 19, 12, 260, DateTimeKind.Local).AddTicks(8752), "Comment 1", null, "System" },
                    { 2, "System", new DateTime(2024, 1, 12, 12, 19, 12, 260, DateTimeKind.Local).AddTicks(8754), new DateTime(2024, 1, 12, 12, 19, 12, 260, DateTimeKind.Local).AddTicks(8754), "Comment 2", null, "System" }
========
                    { 1, "System", new DateTime(2024, 1, 12, 20, 46, 32, 748, DateTimeKind.Local).AddTicks(1179), new DateTime(2024, 1, 12, 20, 46, 32, 748, DateTimeKind.Local).AddTicks(1180), "Comment 1", null, "System" },
                    { 2, "System", new DateTime(2024, 1, 12, 20, 46, 32, 748, DateTimeKind.Local).AddTicks(1182), new DateTime(2024, 1, 12, 20, 46, 32, 748, DateTimeKind.Local).AddTicks(1182), "Comment 2", null, "System" }
>>>>>>>> eb3fbf48bb3251b2483615ac904a14539b2e81d1:ProductReview/Server/Migrations/20240112124632_newdb.cs
                });

            migrationBuilder.InsertData(
                table: "Links",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "LinkUrl", "PlatformName", "ProductId", "UpdatedBy" },
                values: new object[,]
                {
<<<<<<<< HEAD:ProductReview/Server/Migrations/20240112041912_newdb.cs
                    { 1, "System", new DateTime(2024, 1, 12, 12, 19, 12, 260, DateTimeKind.Local).AddTicks(9398), new DateTime(2024, 1, 12, 12, 19, 12, 260, DateTimeKind.Local).AddTicks(9399), "https://www.amazon.com/New-Simple-Mobile-Prepaid-Product/dp/B0875RK26R/ref=sr_1_1?keywords=iPhone+SE&qid=1704944545&sr=8-1", "Amazon", null, "System" },
                    { 2, "System", new DateTime(2024, 1, 12, 12, 19, 12, 260, DateTimeKind.Local).AddTicks(9400), new DateTime(2024, 1, 12, 12, 19, 12, 260, DateTimeKind.Local).AddTicks(9401), "https://www.apple.com/iphone-se/", "Apple", null, "System" }
========
                    { 1, "System", new DateTime(2024, 1, 12, 20, 46, 32, 748, DateTimeKind.Local).AddTicks(1668), new DateTime(2024, 1, 12, 20, 46, 32, 748, DateTimeKind.Local).AddTicks(1669), "https://www.amazon.com/New-Simple-Mobile-Prepaid-Product/dp/B0875RK26R/ref=sr_1_1?keywords=iPhone+SE&qid=1704944545&sr=8-1", "Amazon", null, "System" },
                    { 2, "System", new DateTime(2024, 1, 12, 20, 46, 32, 748, DateTimeKind.Local).AddTicks(1670), new DateTime(2024, 1, 12, 20, 46, 32, 748, DateTimeKind.Local).AddTicks(1671), "https://www.apple.com/iphone-se/", "Apple", null, "System" }
>>>>>>>> eb3fbf48bb3251b2483615ac904a14539b2e81d1:ProductReview/Server/Migrations/20240112124632_newdb.cs
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "DateCreated", "DateUpdated", "Description", "Title", "UpdatedBy" },
                values: new object[,]
                {
<<<<<<<< HEAD:ProductReview/Server/Migrations/20240112041912_newdb.cs
                    { 1, null, "System", new DateTime(2024, 1, 12, 12, 19, 12, 260, DateTimeKind.Local).AddTicks(9578), new DateTime(2024, 1, 12, 12, 19, 12, 260, DateTimeKind.Local).AddTicks(9579), "Apple has confirmed that they will not have iphone 16", "Apple to skip 16 and jump to 17", "System" },
                    { 2, null, "System", new DateTime(2024, 1, 12, 12, 19, 12, 260, DateTimeKind.Local).AddTicks(9580), new DateTime(2024, 1, 12, 12, 19, 12, 260, DateTimeKind.Local).AddTicks(9581), "Samsung's Z fold 6 design leaked", "Samsung Z fold 6 leaked", "System" }
========
                    { 1, null, "System", new DateTime(2024, 1, 12, 20, 46, 32, 748, DateTimeKind.Local).AddTicks(1824), new DateTime(2024, 1, 12, 20, 46, 32, 748, DateTimeKind.Local).AddTicks(1825), "Apple has confirmed that they will not have iphone 16", "Apple to skip 16 and jump to 17", "System" },
                    { 2, null, "System", new DateTime(2024, 1, 12, 20, 46, 32, 748, DateTimeKind.Local).AddTicks(1826), new DateTime(2024, 1, 12, 20, 46, 32, 748, DateTimeKind.Local).AddTicks(1827), "Samsung's Z fold 6 design leaked", "Samsung Z fold 6 leaked", "System" }
>>>>>>>> eb3fbf48bb3251b2483615ac904a14539b2e81d1:ProductReview/Server/Migrations/20240112124632_newdb.cs
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "DateCreated", "DateUpdated", "Description", "Image", "Name", "UpdatedBy" },
                values: new object[,]
                {
<<<<<<<< HEAD:ProductReview/Server/Migrations/20240112041912_newdb.cs
                    { 1, null, "System", new DateTime(2024, 1, 12, 12, 19, 12, 260, DateTimeKind.Local).AddTicks(9018), new DateTime(2024, 1, 12, 12, 19, 12, 260, DateTimeKind.Local).AddTicks(9019), "Iphone SE...", "https://www.apple.com/newsroom/images/product/iphone/standard/Apple_announce-iphone13pro_09142021_big.jpg.large.jpg", "Iphone SE", "System" },
                    { 2, null, "System", new DateTime(2024, 1, 12, 12, 19, 12, 260, DateTimeKind.Local).AddTicks(9021), new DateTime(2024, 1, 12, 12, 19, 12, 260, DateTimeKind.Local).AddTicks(9022), "Iphone 13", "https://www.apple.com/newsroom/images/product/iphone/standard/Apple_announce-iphone13pro_09142021_big.jpg.large.jpg", "Iphone 13 ", "System" }
========
                    { 1, null, "System", new DateTime(2024, 1, 12, 20, 46, 32, 748, DateTimeKind.Local).AddTicks(1349), new DateTime(2024, 1, 12, 20, 46, 32, 748, DateTimeKind.Local).AddTicks(1350), "Iphone SE...", "https://www.apple.com/newsroom/images/product/iphone/standard/Apple_announce-iphone13pro_09142021_big.jpg.large.jpg", "Iphone SE", "System" },
                    { 2, null, "System", new DateTime(2024, 1, 12, 20, 46, 32, 748, DateTimeKind.Local).AddTicks(1352), new DateTime(2024, 1, 12, 20, 46, 32, 748, DateTimeKind.Local).AddTicks(1352), "Iphone 13", "https://www.apple.com/newsroom/images/product/iphone/standard/Apple_announce-iphone13pro_09142021_big.jpg.large.jpg", "Iphone 13 ", "System" }
>>>>>>>> eb3fbf48bb3251b2483615ac904a14539b2e81d1:ProductReview/Server/Migrations/20240112124632_newdb.cs
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "BatteryLife", "CreatedBy", "CustomerId", "DateCreated", "DateUpdated", "Description", "Performance", "ProductId", "Title", "UpdatedBy", "UserFriendly", "Value" },
                values: new object[,]
                {
<<<<<<<< HEAD:ProductReview/Server/Migrations/20240112041912_newdb.cs
                    { 1, 1, "System", null, new DateTime(2024, 1, 12, 12, 19, 12, 260, DateTimeKind.Local).AddTicks(9208), new DateTime(2024, 1, 12, 12, 19, 12, 260, DateTimeKind.Local).AddTicks(9209), "Iphone SE is so ass", 1, null, "Iphone SE review", "System", 1, 1 },
                    { 2, 5, "System", null, new DateTime(2024, 1, 12, 12, 19, 12, 260, DateTimeKind.Local).AddTicks(9211), new DateTime(2024, 1, 12, 12, 19, 12, 260, DateTimeKind.Local).AddTicks(9212), "Iphone 13 has the best value in 2024", 5, null, "Iphone 13 review", "System", 5, 5 }
========
                    { 1, 1, "System", null, new DateTime(2024, 1, 12, 20, 46, 32, 748, DateTimeKind.Local).AddTicks(1509), new DateTime(2024, 1, 12, 20, 46, 32, 748, DateTimeKind.Local).AddTicks(1510), "Iphone SE is so ass", 1, null, "Iphone SE review", "System", 1, 1 },
                    { 2, 5, "System", null, new DateTime(2024, 1, 12, 20, 46, 32, 748, DateTimeKind.Local).AddTicks(1512), new DateTime(2024, 1, 12, 20, 46, 32, 748, DateTimeKind.Local).AddTicks(1513), "Iphone 13 has the best value in 2024", 5, null, "Iphone 13 review", "System", 5, 5 }
>>>>>>>> eb3fbf48bb3251b2483615ac904a14539b2e81d1:ProductReview/Server/Migrations/20240112124632_newdb.cs
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ReviewId",
                table: "Comments",
                column: "ReviewId");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_Favourites_CustomerId",
                table: "Favourites",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Favourites_ProductId",
                table: "Favourites",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Keys_Use",
                table: "Keys",
                column: "Use");

            migrationBuilder.CreateIndex(
                name: "IX_Links_ProductId",
                table: "Links",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_News_CategoryId",
                table: "News",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_ConsumedTime",
                table: "PersistedGrants",
                column: "ConsumedTime");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CustomerId",
                table: "Reviews",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");
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
                name: "Comments");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "Favourites");

            migrationBuilder.DropTable(
                name: "Keys");

            migrationBuilder.DropTable(
                name: "Links");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
