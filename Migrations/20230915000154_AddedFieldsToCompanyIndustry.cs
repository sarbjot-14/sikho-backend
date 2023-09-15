using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sikho_backend.Migrations
{
    /// <inheritdoc />
    public partial class AddedFieldsToCompanyIndustry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cost_title",
                table: "Industries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "revenue_title",
                table: "Industries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "unit_title",
                table: "Industries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "type",
                table: "Companies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "website_link",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cost_title",
                table: "Industries");

            migrationBuilder.DropColumn(
                name: "revenue_title",
                table: "Industries");

            migrationBuilder.DropColumn(
                name: "unit_title",
                table: "Industries");

            migrationBuilder.DropColumn(
                name: "type",
                table: "Companies");

            migrationBuilder.DropColumn(
                name: "website_link",
                table: "Companies");
        }
    }
}
