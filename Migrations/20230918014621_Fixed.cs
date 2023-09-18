using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sikho_backend.Migrations
{
    /// <inheritdoc />
    public partial class Fixed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DataPoints",
                columns: new[] { "Id", "CompanyId", "cost", "cost_source", "units", "units_source", "year" },
                values: new object[,]
                {
                    { 20, 7, null, null, 10, "https://www.tastetoronto.com/news/torontos-robo-cafe-opens-second-location-in-kensington-market", 2020 },
                    { 21, 4, null, null, 2, "https://cafexapp.com/ ", 2020 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 21);
        }
    }
}
