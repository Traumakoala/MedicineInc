using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicineInc.Server.Migrations
{
    /// <inheritdoc />
    public partial class behffh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 10, 26, 47, 164, DateTimeKind.Local).AddTicks(5258), new DateTime(2024, 1, 19, 10, 26, 47, 164, DateTimeKind.Local).AddTicks(5279) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 10, 26, 47, 164, DateTimeKind.Local).AddTicks(5285), new DateTime(2024, 1, 19, 10, 26, 47, 164, DateTimeKind.Local).AddTicks(5286) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 10, 26, 47, 164, DateTimeKind.Local).AddTicks(5289), new DateTime(2024, 1, 19, 10, 26, 47, 164, DateTimeKind.Local).AddTicks(5290) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 10, 26, 47, 164, DateTimeKind.Local).AddTicks(5293), new DateTime(2024, 1, 19, 10, 26, 47, 164, DateTimeKind.Local).AddTicks(5294) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 10, 26, 47, 164, DateTimeKind.Local).AddTicks(5298), new DateTime(2024, 1, 19, 10, 26, 47, 164, DateTimeKind.Local).AddTicks(5298) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 10, 26, 47, 164, DateTimeKind.Local).AddTicks(5302), new DateTime(2024, 1, 19, 10, 26, 47, 164, DateTimeKind.Local).AddTicks(5303) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 19, 10, 26, 47, 164, DateTimeKind.Local).AddTicks(5305), new DateTime(2024, 1, 19, 10, 26, 47, 164, DateTimeKind.Local).AddTicks(5306) });
        }
    }
}
