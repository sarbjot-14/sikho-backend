using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sikho_backend.Migrations
{
    /// <inheritdoc />
    public partial class DataPointTableAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataPoint_Companies_CompanyId",
                table: "DataPoint");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DataPoint",
                table: "DataPoint");

            migrationBuilder.RenameTable(
                name: "DataPoint",
                newName: "DataPoints");

            migrationBuilder.RenameIndex(
                name: "IX_DataPoint_CompanyId",
                table: "DataPoints",
                newName: "IX_DataPoints_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DataPoints",
                table: "DataPoints",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DataPoints_Companies_CompanyId",
                table: "DataPoints",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataPoints_Companies_CompanyId",
                table: "DataPoints");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DataPoints",
                table: "DataPoints");

            migrationBuilder.RenameTable(
                name: "DataPoints",
                newName: "DataPoint");

            migrationBuilder.RenameIndex(
                name: "IX_DataPoints_CompanyId",
                table: "DataPoint",
                newName: "IX_DataPoint_CompanyId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DataPoint",
                table: "DataPoint",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DataPoint_Companies_CompanyId",
                table: "DataPoint",
                column: "CompanyId",
                principalTable: "Companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
