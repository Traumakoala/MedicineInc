using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicineInc.Server.Migrations
{
    /// <inheritdoc />
    public partial class gdrf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ImageRef",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "MediName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Usage",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "feat",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Medicines",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "OrderId" },
                values: new object[] { new DateTime(2024, 1, 25, 14, 58, 52, 578, DateTimeKind.Local).AddTicks(222), new DateTime(2024, 1, 25, 14, 58, 52, 578, DateTimeKind.Local).AddTicks(234), null });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "OrderId" },
                values: new object[] { new DateTime(2024, 1, 25, 14, 58, 52, 578, DateTimeKind.Local).AddTicks(237), new DateTime(2024, 1, 25, 14, 58, 52, 578, DateTimeKind.Local).AddTicks(238), null });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated", "OrderId" },
                values: new object[] { new DateTime(2024, 1, 25, 14, 58, 52, 578, DateTimeKind.Local).AddTicks(267), new DateTime(2024, 1, 25, 14, 58, 52, 578, DateTimeKind.Local).AddTicks(268), null });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated", "OrderId" },
                values: new object[] { new DateTime(2024, 1, 25, 14, 58, 52, 578, DateTimeKind.Local).AddTicks(269), new DateTime(2024, 1, 25, 14, 58, 52, 578, DateTimeKind.Local).AddTicks(270), null });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated", "OrderId" },
                values: new object[] { new DateTime(2024, 1, 25, 14, 58, 52, 578, DateTimeKind.Local).AddTicks(271), new DateTime(2024, 1, 25, 14, 58, 52, 578, DateTimeKind.Local).AddTicks(272), null });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated", "OrderId" },
                values: new object[] { new DateTime(2024, 1, 25, 14, 58, 52, 578, DateTimeKind.Local).AddTicks(274), new DateTime(2024, 1, 25, 14, 58, 52, 578, DateTimeKind.Local).AddTicks(274), null });

            migrationBuilder.UpdateData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateCreated", "DateUpdated", "OrderId" },
                values: new object[] { new DateTime(2024, 1, 25, 14, 58, 52, 578, DateTimeKind.Local).AddTicks(275), new DateTime(2024, 1, 25, 14, 58, 52, 578, DateTimeKind.Local).AddTicks(276), null });

            migrationBuilder.CreateIndex(
                name: "IX_Medicines_OrderId",
                table: "Medicines",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_Orders_OrderId",
                table: "Medicines",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_Orders_OrderId",
                table: "Medicines");

            migrationBuilder.DropIndex(
                name: "IX_Medicines_OrderId",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Medicines");

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImageRef",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MediName",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Orders",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Usage",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "feat",
                table: "Orders",
                type: "bit",
                nullable: true);

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
    }
}
