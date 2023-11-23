﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WaCollaborative.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveStatusFromProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Status_StatusId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_StatusId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Products");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_StatusId",
                table: "Products",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Status_StatusId",
                table: "Products",
                column: "StatusId",
                principalSchema: "Parameters",
                principalTable: "Status",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
