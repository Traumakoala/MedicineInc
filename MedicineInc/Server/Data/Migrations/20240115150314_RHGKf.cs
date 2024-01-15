using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicineInc.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class RHGKf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 3, 14, 675, DateTimeKind.Local).AddTicks(5538), new DateTime(2024, 1, 15, 23, 3, 14, 675, DateTimeKind.Local).AddTicks(5556) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 3, 14, 675, DateTimeKind.Local).AddTicks(5560), new DateTime(2024, 1, 15, 23, 3, 14, 675, DateTimeKind.Local).AddTicks(5561) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 3, 14, 675, DateTimeKind.Local).AddTicks(5564), new DateTime(2024, 1, 15, 23, 3, 14, 675, DateTimeKind.Local).AddTicks(5564) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 3, 14, 675, DateTimeKind.Local).AddTicks(5567), new DateTime(2024, 1, 15, 23, 3, 14, 675, DateTimeKind.Local).AddTicks(5567) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 3, 14, 675, DateTimeKind.Local).AddTicks(5570), new DateTime(2024, 1, 15, 23, 3, 14, 675, DateTimeKind.Local).AddTicks(5570) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 3, 14, 675, DateTimeKind.Local).AddTicks(5573), new DateTime(2024, 1, 15, 23, 3, 14, 675, DateTimeKind.Local).AddTicks(5574) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated", "ImageRef", "MediName" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 3, 14, 675, DateTimeKind.Local).AddTicks(5577), new DateTime(2024, 1, 15, 23, 3, 14, 675, DateTimeKind.Local).AddTicks(5578), "images/claritin.jpg", "Claritin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 1, 0, 965, DateTimeKind.Local).AddTicks(7799), new DateTime(2024, 1, 15, 23, 1, 0, 965, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 1, 0, 965, DateTimeKind.Local).AddTicks(7802), new DateTime(2024, 1, 15, 23, 1, 0, 965, DateTimeKind.Local).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 1, 0, 965, DateTimeKind.Local).AddTicks(7805), new DateTime(2024, 1, 15, 23, 1, 0, 965, DateTimeKind.Local).AddTicks(7806) });

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
                columns: new[] { "DateCreated", "DateUpdated", "ImageRef", "MediName" },
                values: new object[] { new DateTime(2024, 1, 15, 23, 1, 0, 965, DateTimeKind.Local).AddTicks(7811), new DateTime(2024, 1, 15, 23, 1, 0, 965, DateTimeKind.Local).AddTicks(7811), "images/loratadine.jpg", "Loratadine" });
        }
    }
}
