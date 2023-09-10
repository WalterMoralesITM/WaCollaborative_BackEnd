using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WaCollaborative.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SchemaParametersINCountryAndStateAndCity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_States_StateId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_States_Countries_CountryId",
                table: "States");

            migrationBuilder.DropPrimaryKey(
                name: "PK_States",
                table: "States");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.RenameTable(
                name: "States",
                newName: "State",
                newSchema: "Parameters");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "Country",
                newSchema: "Parameters");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "City",
                newSchema: "Parameters");

            migrationBuilder.RenameIndex(
                name: "IX_States_CountryId_Name",
                schema: "Parameters",
                table: "State",
                newName: "IX_State_CountryId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Countries_Name",
                schema: "Parameters",
                table: "Country",
                newName: "IX_Country_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_StateId_Name",
                schema: "Parameters",
                table: "City",
                newName: "IX_City_StateId_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_State",
                schema: "Parameters",
                table: "State",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Country",
                schema: "Parameters",
                table: "Country",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                schema: "Parameters",
                table: "City",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_City_State_StateId",
                schema: "Parameters",
                table: "City",
                column: "StateId",
                principalSchema: "Parameters",
                principalTable: "State",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_State_Country_CountryId",
                schema: "Parameters",
                table: "State",
                column: "CountryId",
                principalSchema: "Parameters",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_State_StateId",
                schema: "Parameters",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_State_Country_CountryId",
                schema: "Parameters",
                table: "State");

            migrationBuilder.DropPrimaryKey(
                name: "PK_State",
                schema: "Parameters",
                table: "State");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Country",
                schema: "Parameters",
                table: "Country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                schema: "Parameters",
                table: "City");

            migrationBuilder.RenameTable(
                name: "State",
                schema: "Parameters",
                newName: "States");

            migrationBuilder.RenameTable(
                name: "Country",
                schema: "Parameters",
                newName: "Countries");

            migrationBuilder.RenameTable(
                name: "City",
                schema: "Parameters",
                newName: "Cities");

            migrationBuilder.RenameIndex(
                name: "IX_State_CountryId_Name",
                table: "States",
                newName: "IX_States_CountryId_Name");

            migrationBuilder.RenameIndex(
                name: "IX_Country_Name",
                table: "Countries",
                newName: "IX_Countries_Name");

            migrationBuilder.RenameIndex(
                name: "IX_City_StateId_Name",
                table: "Cities",
                newName: "IX_Cities_StateId_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_States",
                table: "States",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_States_StateId",
                table: "Cities",
                column: "StateId",
                principalTable: "States",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_States_Countries_CountryId",
                table: "States",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
