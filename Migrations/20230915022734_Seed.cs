using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sikho_backend.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "type",
                table: "Industries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Industries",
                columns: new[] { "Id", "cost_title", "revenue_title", "type", "unit_title" },
                values: new object[,]
                {
                    { 1, "Average Cost per Ride", "Estimated Total Sales", 0, "Trips Completed" },
                    { 2, "Sales per Location", "Estimated Total Sales", 1, "Number of Locations" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "IndustryId", "name", "type", "website_link" },
                values: new object[,]
                {
                    { 1, 1, "Waymo", 0, "https://waymo.com/" },
                    { 2, 1, "Cruise", 0, "https://getcruise.com/" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Industries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "type",
                table: "Industries");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Companies");
        }
    }
}
