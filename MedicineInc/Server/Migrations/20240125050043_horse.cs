using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicineInc.Server.Migrations
{
    /// <inheritdoc />
    public partial class horse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 13, 0, 43, 451, DateTimeKind.Local).AddTicks(486), new DateTime(2024, 1, 25, 13, 0, 43, 451, DateTimeKind.Local).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 13, 0, 43, 451, DateTimeKind.Local).AddTicks(499), new DateTime(2024, 1, 25, 13, 0, 43, 451, DateTimeKind.Local).AddTicks(500) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 13, 0, 43, 451, DateTimeKind.Local).AddTicks(501), new DateTime(2024, 1, 25, 13, 0, 43, 451, DateTimeKind.Local).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 13, 0, 43, 451, DateTimeKind.Local).AddTicks(503), new DateTime(2024, 1, 25, 13, 0, 43, 451, DateTimeKind.Local).AddTicks(504) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 13, 0, 43, 451, DateTimeKind.Local).AddTicks(505), new DateTime(2024, 1, 25, 13, 0, 43, 451, DateTimeKind.Local).AddTicks(506) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 13, 0, 43, 451, DateTimeKind.Local).AddTicks(507), new DateTime(2024, 1, 25, 13, 0, 43, 451, DateTimeKind.Local).AddTicks(508) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 25, 13, 0, 43, 451, DateTimeKind.Local).AddTicks(509), new DateTime(2024, 1, 25, 13, 0, 43, 451, DateTimeKind.Local).AddTicks(509) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
