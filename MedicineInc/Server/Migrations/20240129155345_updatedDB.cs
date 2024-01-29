using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicineInc.Server.Migrations
{
    /// <inheritdoc />
    public partial class updatedDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 23, 53, 45, 519, DateTimeKind.Local).AddTicks(8565), new DateTime(2024, 1, 29, 23, 53, 45, 519, DateTimeKind.Local).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 23, 53, 45, 519, DateTimeKind.Local).AddTicks(8582), new DateTime(2024, 1, 29, 23, 53, 45, 519, DateTimeKind.Local).AddTicks(8583) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 23, 53, 45, 519, DateTimeKind.Local).AddTicks(8584), new DateTime(2024, 1, 29, 23, 53, 45, 519, DateTimeKind.Local).AddTicks(8585) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 23, 53, 45, 519, DateTimeKind.Local).AddTicks(8586), new DateTime(2024, 1, 29, 23, 53, 45, 519, DateTimeKind.Local).AddTicks(8587) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 23, 53, 45, 519, DateTimeKind.Local).AddTicks(8589), new DateTime(2024, 1, 29, 23, 53, 45, 519, DateTimeKind.Local).AddTicks(8589) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 23, 53, 45, 519, DateTimeKind.Local).AddTicks(8591), new DateTime(2024, 1, 29, 23, 53, 45, 519, DateTimeKind.Local).AddTicks(8591) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 23, 53, 45, 519, DateTimeKind.Local).AddTicks(8592), new DateTime(2024, 1, 29, 23, 53, 45, 519, DateTimeKind.Local).AddTicks(8593) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 23, 2, 51, 312, DateTimeKind.Local).AddTicks(9365), new DateTime(2024, 1, 29, 23, 2, 51, 312, DateTimeKind.Local).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 23, 2, 51, 312, DateTimeKind.Local).AddTicks(9381), new DateTime(2024, 1, 29, 23, 2, 51, 312, DateTimeKind.Local).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 23, 2, 51, 312, DateTimeKind.Local).AddTicks(9384), new DateTime(2024, 1, 29, 23, 2, 51, 312, DateTimeKind.Local).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 23, 2, 51, 312, DateTimeKind.Local).AddTicks(9386), new DateTime(2024, 1, 29, 23, 2, 51, 312, DateTimeKind.Local).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 23, 2, 51, 312, DateTimeKind.Local).AddTicks(9388), new DateTime(2024, 1, 29, 23, 2, 51, 312, DateTimeKind.Local).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 23, 2, 51, 312, DateTimeKind.Local).AddTicks(9390), new DateTime(2024, 1, 29, 23, 2, 51, 312, DateTimeKind.Local).AddTicks(9390) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 29, 23, 2, 51, 312, DateTimeKind.Local).AddTicks(9392), new DateTime(2024, 1, 29, 23, 2, 51, 312, DateTimeKind.Local).AddTicks(9392) });
        }
    }
}
