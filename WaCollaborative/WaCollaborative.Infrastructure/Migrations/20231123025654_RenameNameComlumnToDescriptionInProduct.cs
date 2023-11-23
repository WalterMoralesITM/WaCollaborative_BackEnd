using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WaCollaborative.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RenameNameComlumnToDescriptionInProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Segments",
                newName: "Description");

            migrationBuilder.RenameIndex(
                name: "IX_Segments_Name",
                table: "Segments",
                newName: "IX_Segments_Description");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "MeasurementUnits",
                newName: "Description");

            migrationBuilder.RenameIndex(
                name: "IX_MeasurementUnits_Name",
                table: "MeasurementUnits",
                newName: "IX_MeasurementUnits_Description");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "Description");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_Name",
                table: "Categories",
                newName: "IX_Categories_Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Segments",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_Segments_Description",
                table: "Segments",
                newName: "IX_Segments_Name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "MeasurementUnits",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_MeasurementUnits_Description",
                table: "MeasurementUnits",
                newName: "IX_MeasurementUnits_Name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Categories",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_Description",
                table: "Categories",
                newName: "IX_Categories_Name");
        }
    }
}
