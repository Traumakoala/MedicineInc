using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicineInc.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class ajhalfh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 22, 55, 2, 705, DateTimeKind.Local).AddTicks(6516), new DateTime(2024, 1, 15, 22, 55, 2, 705, DateTimeKind.Local).AddTicks(6531) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 22, 55, 2, 705, DateTimeKind.Local).AddTicks(6539), new DateTime(2024, 1, 15, 22, 55, 2, 705, DateTimeKind.Local).AddTicks(6540) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 22, 55, 2, 705, DateTimeKind.Local).AddTicks(6543), new DateTime(2024, 1, 15, 22, 55, 2, 705, DateTimeKind.Local).AddTicks(6543) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 22, 55, 2, 705, DateTimeKind.Local).AddTicks(6546), new DateTime(2024, 1, 15, 22, 55, 2, 705, DateTimeKind.Local).AddTicks(6547) });

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "Id", "Count", "CreatedBy", "DateCreated", "DateUpdated", "ImageRef", "MediName", "OrderId", "Price", "UpdatedBy", "Usage" },
                values: new object[,]
                {
                    { 5, 0, "System", new DateTime(2024, 1, 15, 22, 55, 2, 705, DateTimeKind.Local).AddTicks(6550), new DateTime(2024, 1, 15, 22, 55, 2, 705, DateTimeKind.Local).AddTicks(6551), "images/acetaminophen.jpg", "Acetaminophen", null, 9.9900000000000002, "System", "Pain reliever and fever reducer" },
                    { 6, 0, "System", new DateTime(2024, 1, 15, 22, 55, 2, 705, DateTimeKind.Local).AddTicks(6553), new DateTime(2024, 1, 15, 22, 55, 2, 705, DateTimeKind.Local).AddTicks(6554), "images/ibuprofen.jpg", "Ibuprofen", null, 7.4900000000000002, "System", "Nonsteroidal anti-inflammatory drug (NSAID)" },
                    { 7, 0, "System", new DateTime(2024, 1, 15, 22, 55, 2, 705, DateTimeKind.Local).AddTicks(6557), new DateTime(2024, 1, 15, 22, 55, 2, 705, DateTimeKind.Local).AddTicks(6558), "images/loratadine.jpg", "Loratadine", null, 5.9900000000000002, "System", "Antihistamine for allergy relief" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 10, 37, 561, DateTimeKind.Local).AddTicks(3335), new DateTime(2024, 1, 15, 19, 10, 37, 561, DateTimeKind.Local).AddTicks(3352) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 10, 37, 561, DateTimeKind.Local).AddTicks(3355), new DateTime(2024, 1, 15, 19, 10, 37, 561, DateTimeKind.Local).AddTicks(3356) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 10, 37, 561, DateTimeKind.Local).AddTicks(3359), new DateTime(2024, 1, 15, 19, 10, 37, 561, DateTimeKind.Local).AddTicks(3359) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 19, 10, 37, 561, DateTimeKind.Local).AddTicks(3361), new DateTime(2024, 1, 15, 19, 10, 37, 561, DateTimeKind.Local).AddTicks(3362) });
        }
    }
}
