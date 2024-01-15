using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicineInc.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class RHGKFG : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 1, 0, 965, DateTimeKind.Local).AddTicks(7773), new DateTime(2024, 1, 15, 23, 1, 0, 965, DateTimeKind.Local).AddTicks(7792) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 1, 0, 965, DateTimeKind.Local).AddTicks(7796), new DateTime(2024, 1, 15, 23, 1, 0, 965, DateTimeKind.Local).AddTicks(7797) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "Price" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 1, 0, 965, DateTimeKind.Local).AddTicks(7799), new DateTime(2024, 1, 15, 23, 1, 0, 965, DateTimeKind.Local).AddTicks(7800), 7.4900000000000002 });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "Price" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 1, 0, 965, DateTimeKind.Local).AddTicks(7802), new DateTime(2024, 1, 15, 23, 1, 0, 965, DateTimeKind.Local).AddTicks(7803), 4.29 });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "ImageRef", "MediName" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 1, 0, 965, DateTimeKind.Local).AddTicks(7805), new DateTime(2024, 1, 15, 23, 1, 0, 965, DateTimeKind.Local).AddTicks(7806), "images/tylenol.jpg", "Tylenol" });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 1, 0, 965, DateTimeKind.Local).AddTicks(7808), new DateTime(2024, 1, 15, 23, 1, 0, 965, DateTimeKind.Local).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 1, 0, 965, DateTimeKind.Local).AddTicks(7811), new DateTime(2024, 1, 15, 23, 1, 0, 965, DateTimeKind.Local).AddTicks(7811) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DateCreated", "DateUpdated", "Price" },
                values: new object[] { new DateTime(2024, 1, 15, 22, 55, 2, 705, DateTimeKind.Local).AddTicks(6543), new DateTime(2024, 1, 15, 22, 55, 2, 705, DateTimeKind.Local).AddTicks(6543), 7.5 });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "Price" },
                values: new object[] { new DateTime(2024, 1, 15, 22, 55, 2, 705, DateTimeKind.Local).AddTicks(6546), new DateTime(2024, 1, 15, 22, 55, 2, 705, DateTimeKind.Local).AddTicks(6547), 4.25 });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "ImageRef", "MediName" },
                values: new object[] { new DateTime(2024, 1, 15, 22, 55, 2, 705, DateTimeKind.Local).AddTicks(6550), new DateTime(2024, 1, 15, 22, 55, 2, 705, DateTimeKind.Local).AddTicks(6551), "images/acetaminophen.jpg", "Acetaminophen" });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 22, 55, 2, 705, DateTimeKind.Local).AddTicks(6553), new DateTime(2024, 1, 15, 22, 55, 2, 705, DateTimeKind.Local).AddTicks(6554) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 22, 55, 2, 705, DateTimeKind.Local).AddTicks(6557), new DateTime(2024, 1, 15, 22, 55, 2, 705, DateTimeKind.Local).AddTicks(6558) });
        }
    }
}
