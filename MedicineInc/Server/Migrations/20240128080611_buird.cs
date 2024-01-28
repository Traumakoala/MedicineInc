using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicineInc.Server.Migrations
{
    /// <inheritdoc />
    public partial class buird : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "StaffAddress",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "StaffPassword",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "StaffUser",
                table: "Staffs");

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 28, 16, 6, 11, 847, DateTimeKind.Local).AddTicks(9502), new DateTime(2024, 1, 28, 16, 6, 11, 847, DateTimeKind.Local).AddTicks(9512) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 28, 16, 6, 11, 847, DateTimeKind.Local).AddTicks(9516), new DateTime(2024, 1, 28, 16, 6, 11, 847, DateTimeKind.Local).AddTicks(9516) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 28, 16, 6, 11, 847, DateTimeKind.Local).AddTicks(9518), new DateTime(2024, 1, 28, 16, 6, 11, 847, DateTimeKind.Local).AddTicks(9518) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 28, 16, 6, 11, 847, DateTimeKind.Local).AddTicks(9520), new DateTime(2024, 1, 28, 16, 6, 11, 847, DateTimeKind.Local).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 28, 16, 6, 11, 847, DateTimeKind.Local).AddTicks(9521), new DateTime(2024, 1, 28, 16, 6, 11, 847, DateTimeKind.Local).AddTicks(9522) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 28, 16, 6, 11, 847, DateTimeKind.Local).AddTicks(9523), new DateTime(2024, 1, 28, 16, 6, 11, 847, DateTimeKind.Local).AddTicks(9524) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 28, 16, 6, 11, 847, DateTimeKind.Local).AddTicks(9525), new DateTime(2024, 1, 28, 16, 6, 11, 847, DateTimeKind.Local).AddTicks(9526) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StaffAddress",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StaffPassword",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StaffUser",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 28, 15, 46, 41, 695, DateTimeKind.Local).AddTicks(3764), new DateTime(2024, 1, 28, 15, 46, 41, 695, DateTimeKind.Local).AddTicks(3774) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 28, 15, 46, 41, 695, DateTimeKind.Local).AddTicks(3777), new DateTime(2024, 1, 28, 15, 46, 41, 695, DateTimeKind.Local).AddTicks(3777) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 28, 15, 46, 41, 695, DateTimeKind.Local).AddTicks(3779), new DateTime(2024, 1, 28, 15, 46, 41, 695, DateTimeKind.Local).AddTicks(3779) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 28, 15, 46, 41, 695, DateTimeKind.Local).AddTicks(3780), new DateTime(2024, 1, 28, 15, 46, 41, 695, DateTimeKind.Local).AddTicks(3781) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 28, 15, 46, 41, 695, DateTimeKind.Local).AddTicks(3782), new DateTime(2024, 1, 28, 15, 46, 41, 695, DateTimeKind.Local).AddTicks(3783) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 28, 15, 46, 41, 695, DateTimeKind.Local).AddTicks(3784), new DateTime(2024, 1, 28, 15, 46, 41, 695, DateTimeKind.Local).AddTicks(3785) });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 1, 28, 15, 46, 41, 695, DateTimeKind.Local).AddTicks(3787), new DateTime(2024, 1, 28, 15, 46, 41, 695, DateTimeKind.Local).AddTicks(3788) });
        }
    }
}
