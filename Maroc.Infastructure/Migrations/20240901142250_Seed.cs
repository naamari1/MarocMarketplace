using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Maroc.Infastructure.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalItems = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CurrentStock = table.Column<int>(type: "int", nullable: false),
                    RecordLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("09aec814-d61a-49c5-9825-0c6d5db827da"), "Decoration" },
                    { new Guid("1a8f927b-b978-4d50-ac93-422dc26ae038"), "Jewelry" },
                    { new Guid("219d12ff-5173-4cb7-9d08-c8d0bc050d6d"), "Home" },
                    { new Guid("4a8bbfac-9a39-4fac-ba7a-ecc73405d6db"), "Games" },
                    { new Guid("562bbed0-2966-4929-9eaa-310b1e640438"), "Art" },
                    { new Guid("6dcac4ff-8b23-4264-af27-1c3621ede620"), "Clothing" },
                    { new Guid("70ff1a49-b23b-4846-88fb-0b148b868c5c"), "Islam" },
                    { new Guid("735c11f0-e003-46ac-8ac1-6a849716fc07"), "Lamps" },
                    { new Guid("7e7c0e3a-d97b-4ebe-9f92-844550f1570b"), "Baby" },
                    { new Guid("84641041-2a1a-4988-93fa-716720338521"), "Shoes" },
                    { new Guid("859e8fba-2671-43e3-ba07-628dce1a5fee"), "Accessories" },
                    { new Guid("877191a7-5acd-4560-b327-1baab8dd450b"), "Home" },
                    { new Guid("8f2070bf-09c4-4c8a-bbb6-656227e29c32"), "Bags" },
                    { new Guid("a073be93-6967-44d8-a996-c59744b08317"), "Cookware" },
                    { new Guid("aca908b1-a425-45c8-8621-5094cbbd0275"), "Personal Care" },
                    { new Guid("c57bce6f-c3c7-4c16-87f8-d201e8d78bc6"), "Music" },
                    { new Guid("ce98178d-90db-4fe8-8b7d-3766f9dca364"), "Garden" },
                    { new Guid("d8e0908b-d5de-4945-994b-c4ccf2227d19"), "Antiques" },
                    { new Guid("e10ed622-437e-42c5-807c-a500f16627d3"), "Garden" },
                    { new Guid("ed0b858d-6b97-4f32-8b5f-4c2a4ffb3ba3"), "Luggage" },
                    { new Guid("f53257ef-2537-45d8-bb6a-3c2b66c0e6bf"), "Handmade" },
                    { new Guid("f9aaa1f3-e477-495e-b2cc-1c8cec8fbad4"), "Books" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName" },
                values: new object[,]
                {
                    { new Guid("5af3834c-d02d-44a0-84cd-e97e97334db6"), "Anis" },
                    { new Guid("c22bb1fa-fa61-4ef3-a37e-f09b119db5ae"), "Nouri" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "OrderDate", "Status", "TotalItems", "UserId" },
                values: new object[,]
                {
                    { new Guid("04a385f9-933a-4cc5-9e0f-71d088cab374"), new DateTime(2024, 9, 1, 16, 22, 49, 684, DateTimeKind.Local).AddTicks(4120), "Pending", 3, new Guid("c22bb1fa-fa61-4ef3-a37e-f09b119db5ae") },
                    { new Guid("3a5ab519-d155-442c-843e-1751a0428af2"), new DateTime(2024, 9, 1, 16, 22, 49, 684, DateTimeKind.Local).AddTicks(4080), "Processing", 2, new Guid("5af3834c-d02d-44a0-84cd-e97e97334db6") }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("445c1f8a-54a0-4588-a628-8c7a7cb61abc"), new Guid("8f2070bf-09c4-4c8a-bbb6-656227e29c32"), "dsdsds", "", "Bag", 30m, 5 },
                    { new Guid("7f9985dc-3998-44e7-b1ec-17f9383d5e2a"), new Guid("a073be93-6967-44d8-a996-c59744b08317"), "blalalalala", "", "Tajine", 20m, 5 },
                    { new Guid("8ae70984-8d34-4268-b05f-3a54cc7ba1d1"), new Guid("6dcac4ff-8b23-4264-af27-1c3621ede620"), "dddd", "", "Djellaba", 50m, 5 },
                    { new Guid("b40f6183-ce18-4905-af02-7b7b4e6d474f"), new Guid("70ff1a49-b23b-4846-88fb-0b148b868c5c"), "ddd", "", "Quran", 10m, 5 }
                });

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Id", "CurrentStock", "ProductId", "RecordLevel" },
                values: new object[,]
                {
                    { new Guid("0c821682-b640-4ab1-a7cb-04f7b22ed442"), 5, new Guid("8ae70984-8d34-4268-b05f-3a54cc7ba1d1"), 1 },
                    { new Guid("846824a0-f750-4985-a860-d72b45c5d4b2"), 5, new Guid("b40f6183-ce18-4905-af02-7b7b4e6d474f"), 1 },
                    { new Guid("e1f3f6af-b1e9-48f5-a3a7-472d8994b151"), 5, new Guid("445c1f8a-54a0-4588-a628-8c7a7cb61abc"), 1 },
                    { new Guid("fc747ad7-9ecb-49e8-9c03-af88fddcd7f7"), 5, new Guid("7f9985dc-3998-44e7-b1ec-17f9383d5e2a"), 1 }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "OrderId", "Price", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { new Guid("67b63ab4-714e-420f-b9b7-8a53d6084c54"), new Guid("3a5ab519-d155-442c-843e-1751a0428af2"), 20m, new Guid("7f9985dc-3998-44e7-b1ec-17f9383d5e2a"), 2 },
                    { new Guid("a3072fe5-808f-4312-8746-0c493be7b094"), new Guid("04a385f9-933a-4cc5-9e0f-71d088cab374"), 50m, new Guid("8ae70984-8d34-4268-b05f-3a54cc7ba1d1"), 3 }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "Amount", "OrderId", "PaymentDate", "PaymentMethod" },
                values: new object[,]
                {
                    { new Guid("2e192ba3-fa58-402e-bed5-ed1791944fa5"), 40m, new Guid("3a5ab519-d155-442c-843e-1751a0428af2"), new DateTime(2024, 9, 1, 16, 22, 49, 684, DateTimeKind.Local).AddTicks(4130), "PayPal" },
                    { new Guid("ecd8c4df-d1ad-4bdc-a3f5-bf0e59d151c6"), 150m, new Guid("04a385f9-933a-4cc5-9e0f-71d088cab374"), new DateTime(2024, 9, 1, 16, 22, 49, 684, DateTimeKind.Local).AddTicks(4134), "BankContact" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Content", "ProductId", "Rating", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("3eed2bba-a366-4d29-9a1e-5cda79dcd28b"), "Good product", new Guid("7f9985dc-3998-44e7-b1ec-17f9383d5e2a"), 4, "d", new Guid("5af3834c-d02d-44a0-84cd-e97e97334db6") },
                    { new Guid("e883df4b-18ee-40f0-9bd3-cfad907a67cc"), "Nice product", new Guid("8ae70984-8d34-4268-b05f-3a54cc7ba1d1"), 3, "s", new Guid("c22bb1fa-fa61-4ef3-a37e-f09b119db5ae") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_ProductId",
                table: "Inventories",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrderId",
                table: "Payments",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
