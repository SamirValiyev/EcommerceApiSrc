using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceApiSrc.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class deletePropertyName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Detail");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CategoryProduct");

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 40, 30, 842, DateTimeKind.Local).AddTicks(535), "Filmlər & İdman" });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 40, 30, 842, DateTimeKind.Local).AddTicks(544), "turizm & oyunlar" });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 40, 30, 842, DateTimeKind.Local).AddTicks(549), "Geyim" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 21, 16, 40, 30, 842, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 21, 16, 40, 30, 842, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 21, 16, 40, 30, 842, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 21, 16, 40, 30, 842, DateTimeKind.Local).AddTicks(2904));

            migrationBuilder.UpdateData(
                table: "Detail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 40, 30, 846, DateTimeKind.Local).AddTicks(875), "Voluptas non repellendus est inventore.", "Autem." });

            migrationBuilder.UpdateData(
                table: "Detail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 40, 30, 846, DateTimeKind.Local).AddTicks(932), "Ea quis nisi consequatur ut.", "Quo suscipit." });

            migrationBuilder.UpdateData(
                table: "Detail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 40, 30, 846, DateTimeKind.Local).AddTicks(975), "Quae debitis ut nostrum quod.", "Doloremque." });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 40, 30, 848, DateTimeKind.Local).AddTicks(9702), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 5.841671885081830m, 650.59m, "İntellektual Beton Kompyuter" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Price", "Title" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 40, 30, 848, DateTimeKind.Local).AddTicks(9723), "Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals", 6.117400569105820m, 480.21m, "İnanılmaz Ağac Stul" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Detail",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CategoryProduct",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 34, 17, 959, DateTimeKind.Local).AddTicks(2993), "Kompyuterlər" });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 34, 17, 959, DateTimeKind.Local).AddTicks(3034), "Avtomobil & Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Brand",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Name" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 34, 17, 959, DateTimeKind.Local).AddTicks(3043), "İdman & Kompyuterlər" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 21, 16, 34, 17, 959, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 21, 16, 34, 17, 959, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 21, 16, 34, 17, 959, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 2, 21, 16, 34, 17, 959, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "Detail",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Name", "Title" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 34, 17, 961, DateTimeKind.Local).AddTicks(9019), "Consequatur ducimus reprehenderit asperiores velit.", null, "Sit." });

            migrationBuilder.UpdateData(
                table: "Detail",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Name", "Title" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 34, 17, 961, DateTimeKind.Local).AddTicks(9052), "Iste aperiam et repellat fugiat.", null, "Numquam adipisci." });

            migrationBuilder.UpdateData(
                table: "Detail",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Name", "Title" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 34, 17, 961, DateTimeKind.Local).AddTicks(9079), "Et delectus nemo voluptatem non.", null, "Occaecati." });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Discount", "Name", "Price", "Title" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 34, 17, 963, DateTimeKind.Local).AddTicks(4165), "The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J", 9.331896863422370m, null, 990.55m, "İnanılmaz Beton Avtomobil" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Discount", "Name", "Price", "Title" },
                values: new object[] { new DateTime(2025, 2, 21, 16, 34, 17, 963, DateTimeKind.Local).AddTicks(4235), "Boston's most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles", 0.9204918066321520m, null, 101.63m, "İntellektual Ağac Avtomobil" });
        }
    }
}
