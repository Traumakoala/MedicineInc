using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MedicineInc.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class aaaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Medicines_Orders_OrderID",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "OrderFinal",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Controlled",
                table: "Medicines");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Staffs",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Orders",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "OrderDetails",
                table: "Orders",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "OrderID",
                table: "Medicines",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Medicines",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Manufacturer",
                table: "Medicines",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Ingredient",
                table: "Medicines",
                newName: "ImageRef");

            migrationBuilder.RenameColumn(
                name: "ExpiryDate",
                table: "Medicines",
                newName: "DateUpdated");

            migrationBuilder.RenameColumn(
                name: "Dosage",
                table: "Medicines",
                newName: "CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Medicines_OrderID",
                table: "Medicines",
                newName: "IX_Medicines_OrderId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Customers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Branches",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Staffs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Medicines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Medicines",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Branches",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Branches",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Branches",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Branches",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Medicines",
                columns: new[] { "Id", "Count", "CreatedBy", "DateCreated", "DateUpdated", "ImageRef", "MediName", "OrderId", "Price", "UpdatedBy", "Usage" },
                values: new object[,]
                {
                    { 1, 0, "System", new DateTime(2024, 1, 15, 19, 10, 37, 561, DateTimeKind.Local).AddTicks(3335), new DateTime(2024, 1, 15, 19, 10, 37, 561, DateTimeKind.Local).AddTicks(3352), "images/Glucosamine.jpg", "Glucosamine", null, 10.99, "System", "Best Vitamins to stay healthy" },
                    { 2, 0, "System", new DateTime(2024, 1, 15, 19, 10, 37, 561, DateTimeKind.Local).AddTicks(3355), new DateTime(2024, 1, 15, 19, 10, 37, 561, DateTimeKind.Local).AddTicks(3356), "images/panadol.jpg", "Panadol", null, 5.9900000000000002, "System", "Most Popular Item for Cold and Fever" },
                    { 3, 0, "System", new DateTime(2024, 1, 15, 19, 10, 37, 561, DateTimeKind.Local).AddTicks(3359), new DateTime(2024, 1, 15, 19, 10, 37, 561, DateTimeKind.Local).AddTicks(3359), "images/bandaids.jpg", "Bandaids", null, 7.5, "System", "For any and all injuries" },
                    { 4, 0, "System", new DateTime(2024, 1, 15, 19, 10, 37, 561, DateTimeKind.Local).AddTicks(3361), new DateTime(2024, 1, 15, 19, 10, 37, 561, DateTimeKind.Local).AddTicks(3362), "images/strepsils.jpg", "Strepsils", null, 4.25, "System", "To soothe your sore throat" }
                });

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

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medicines",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Medicines");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Branches");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Branches");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Staffs",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Orders",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Orders",
                newName: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Medicines",
                newName: "OrderID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Medicines",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Medicines",
                newName: "Manufacturer");

            migrationBuilder.RenameColumn(
                name: "ImageRef",
                table: "Medicines",
                newName: "Ingredient");

            migrationBuilder.RenameColumn(
                name: "DateUpdated",
                table: "Medicines",
                newName: "ExpiryDate");

            migrationBuilder.RenameColumn(
                name: "CreatedBy",
                table: "Medicines",
                newName: "Dosage");

            migrationBuilder.RenameIndex(
                name: "IX_Medicines_OrderId",
                table: "Medicines",
                newName: "IX_Medicines_OrderID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customers",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Branches",
                newName: "ID");

            migrationBuilder.AddColumn<bool>(
                name: "OrderFinal",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Controlled",
                table: "Medicines",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Medicines_Orders_OrderID",
                table: "Medicines",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "ID");
        }
    }
}
