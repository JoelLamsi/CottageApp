using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class CreateInitCottageData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Cottages_CottageId",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cottages",
                table: "Cottages");

            migrationBuilder.RenameTable(
                name: "Cottages",
                newName: "Cottage");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cottage",
                table: "Cottage",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Cottage",
                columns: new[] { "Id", "CostPerDay", "DateAdded", "Description", "IsElectricity", "IsSauna", "PictureUrl", "Rooms", "Title" },
                values: new object[,]
                {
                    { 1, 50.00m, new DateTime(2023, 10, 13, 10, 11, 36, 209, DateTimeKind.Local).AddTicks(9828), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", false, false, "img/cottage1.jpeg", 0, "Foo" },
                    { 2, 250.00m, new DateTime(2023, 10, 13, 10, 11, 36, 210, DateTimeKind.Local).AddTicks(33), null, false, false, "img/cottage2.jpeg", 0, "Bar" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Cottage_CottageId",
                table: "Reservations",
                column: "CottageId",
                principalTable: "Cottage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Cottage_CottageId",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cottage",
                table: "Cottage");

            migrationBuilder.DeleteData(
                table: "Cottage",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cottage",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameTable(
                name: "Cottage",
                newName: "Cottages");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cottages",
                table: "Cottages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Cottages_CottageId",
                table: "Reservations",
                column: "CottageId",
                principalTable: "Cottages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
