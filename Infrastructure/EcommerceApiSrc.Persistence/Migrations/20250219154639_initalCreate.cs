using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EcommerceApiSrc.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initalCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brand",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Detail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Detail_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    CategoriesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.CategoriesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Category_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Product_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brand",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 19, 19, 46, 39, 211, DateTimeKind.Local).AddTicks(2119), false, "oyunlar, Elektronika & садинструмент" },
                    { 2, new DateTime(2025, 2, 19, 19, 46, 39, 211, DateTimeKind.Local).AddTicks(2125), false, "Avtomobil" },
                    { 3, new DateTime(2025, 2, 19, 19, 46, 39, 211, DateTimeKind.Local).AddTicks(2129), true, "oyunlar" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "ParentId", "Priority" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 19, 19, 46, 39, 211, DateTimeKind.Local).AddTicks(3534), false, "Elektrik", 0, 1 },
                    { 2, new DateTime(2025, 2, 19, 19, 46, 39, 211, DateTimeKind.Local).AddTicks(3536), false, "Trend", 0, 2 },
                    { 3, new DateTime(2025, 2, 19, 19, 46, 39, 211, DateTimeKind.Local).AddTicks(3538), false, "Komputer", 1, 1 },
                    { 4, new DateTime(2025, 2, 19, 19, 46, 39, 211, DateTimeKind.Local).AddTicks(3539), false, "Qadın", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Detail",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "IsDeleted", "Name", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 2, 19, 19, 46, 39, 213, DateTimeKind.Local).AddTicks(866), "Hic est ut qui dolorem.", false, null, "Sunt." },
                    { 2, 3, new DateTime(2025, 2, 19, 19, 46, 39, 213, DateTimeKind.Local).AddTicks(903), "Harum non quo non dolore.", true, null, "Est quas." },
                    { 3, 4, new DateTime(2025, 2, 19, 19, 46, 39, 213, DateTimeKind.Local).AddTicks(931), "Nam distinctio repellendus ut accusamus.", false, null, "Esse." }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "BrandId", "CreatedDate", "Description", "Discount", "IsDeleted", "Name", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 2, 19, 19, 46, 39, 214, DateTimeKind.Local).AddTicks(4402), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 7.63176016139260m, false, null, 49.13m, "İntellektual Rezin Sviter" },
                    { 2, 3, new DateTime(2025, 2, 19, 19, 46, 39, 214, DateTimeKind.Local).AddTicks(4424), "The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality", 8.132927523955060m, false, null, 852.59m, "Fantastik Ağac Beret" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_ProductsId",
                table: "CategoryProduct",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Detail_CategoryId",
                table: "Detail",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_BrandId",
                table: "Product",
                column: "BrandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

            migrationBuilder.DropTable(
                name: "Detail");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Brand");
        }
    }
}
