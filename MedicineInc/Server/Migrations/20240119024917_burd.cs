using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicineInc.Server.Migrations
{
    /// <inheritdoc />
    public partial class burd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 10, 49, 17, 299, DateTimeKind.Local).AddTicks(7086), new DateTime(2024, 1, 19, 10, 49, 17, 299, DateTimeKind.Local).AddTicks(7107) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 10, 49, 17, 299, DateTimeKind.Local).AddTicks(7117), new DateTime(2024, 1, 19, 10, 49, 17, 299, DateTimeKind.Local).AddTicks(7118) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 10, 49, 17, 299, DateTimeKind.Local).AddTicks(7121), new DateTime(2024, 1, 19, 10, 49, 17, 299, DateTimeKind.Local).AddTicks(7121) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 10, 49, 17, 299, DateTimeKind.Local).AddTicks(7124), new DateTime(2024, 1, 19, 10, 49, 17, 299, DateTimeKind.Local).AddTicks(7125) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 10, 49, 17, 299, DateTimeKind.Local).AddTicks(7128), new DateTime(2024, 1, 19, 10, 49, 17, 299, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 10, 49, 17, 299, DateTimeKind.Local).AddTicks(7132), new DateTime(2024, 1, 19, 10, 49, 17, 299, DateTimeKind.Local).AddTicks(7133) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 10, 49, 17, 299, DateTimeKind.Local).AddTicks(7135), new DateTime(2024, 1, 19, 10, 49, 17, 299, DateTimeKind.Local).AddTicks(7136) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 10, 29, 23, 927, DateTimeKind.Local).AddTicks(9140), new DateTime(2024, 1, 19, 10, 29, 23, 927, DateTimeKind.Local).AddTicks(9159) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 10, 29, 23, 927, DateTimeKind.Local).AddTicks(9278), new DateTime(2024, 1, 19, 10, 29, 23, 927, DateTimeKind.Local).AddTicks(9279) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 10, 29, 23, 927, DateTimeKind.Local).AddTicks(9283), new DateTime(2024, 1, 19, 10, 29, 23, 927, DateTimeKind.Local).AddTicks(9284) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 10, 29, 23, 927, DateTimeKind.Local).AddTicks(9287), new DateTime(2024, 1, 19, 10, 29, 23, 927, DateTimeKind.Local).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 10, 29, 23, 927, DateTimeKind.Local).AddTicks(9291), new DateTime(2024, 1, 19, 10, 29, 23, 927, DateTimeKind.Local).AddTicks(9291) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 10, 29, 23, 927, DateTimeKind.Local).AddTicks(9294), new DateTime(2024, 1, 19, 10, 29, 23, 927, DateTimeKind.Local).AddTicks(9295) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 10, 29, 23, 927, DateTimeKind.Local).AddTicks(9297), new DateTime(2024, 1, 19, 10, 29, 23, 927, DateTimeKind.Local).AddTicks(9298) });
        }
    }
}
