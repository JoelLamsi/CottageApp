using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class ChangednameforCottagetable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Cottage_CottageId",
                table: "Reservations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cottage",
                table: "Cottage");

            migrationBuilder.RenameTable(
                name: "Cottage",
                newName: "Cottages");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cottages",
                table: "Cottages",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Cottages",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 10, 19, 16, 45, 0, 829, DateTimeKind.Local).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "Cottages",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 10, 19, 16, 45, 0, 829, DateTimeKind.Local).AddTicks(485));

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Cottages_CottageId",
                table: "Reservations",
                column: "CottageId",
                principalTable: "Cottages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Cottage",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2023, 10, 19, 12, 12, 56, 869, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Cottage",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2023, 10, 19, 12, 12, 56, 869, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Cottage_CottageId",
                table: "Reservations",
                column: "CottageId",
                principalTable: "Cottage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
