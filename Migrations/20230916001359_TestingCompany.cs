using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sikho_backend.Migrations
{
    /// <inheritdoc />
    public partial class TestingCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Industries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<int>(type: "int", nullable: false),
                    unit_title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cost_title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    revenue_title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Industries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndustryId = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    website_link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type = table.Column<int>(type: "int", nullable: false),
                    image_link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    video_link = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Companies_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DataPoints",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    units_source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    units = table.Column<int>(type: "int", nullable: true),
                    cost_source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cost = table.Column<int>(type: "int", nullable: true),
                    year = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataPoints", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DataPoints_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Industries",
                columns: new[] { "Id", "cost_title", "revenue_title", "type", "unit_title" },
                values: new object[,]
                {
                    { 1, "Average Cost per Trip", "Estimated Total Sales", 1, "Trips Completed" },
                    { 2, "Sales per Location", "Estimated Total Sales", 2, "Number of Locations" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "IndustryId", "image_link", "name", "type", "video_link", "website_link" },
                values: new object[,]
                {
                    { 1, 1, "https://lh3.googleusercontent.com/J0ugh3MHXa6tgOeXoP0aS27NCHNURCHOl-bTqgLW2R8ACZFn2FxwTJWn9DGHA4tG7h6zvxiZrndU_HKwzXpJDbDvSrqQJWR3ItKz5fud=rw-w2880-e365", "Waylmo", 2, "https://www.youtube.com/embed/uKfAJDEkstg", "https://waymo.com/" },
                    { 2, 1, "https://images.ctfassets.net/95kuvdv8zn1v/5o4wKdIkXUT7V2WZQciD9b/9007ad36565c4b0f4600a42f96b0adc5/brand_assets_icon_f3f5f8_bg.png?fit=fill&f=center&fm=jpg", "Cruise", 2, "https://www.youtube.com/embed/HfcAsfmYbUA", "https://getcruise.com/" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Companies_IndustryId",
                table: "Companies",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_DataPoints_CompanyId",
                table: "DataPoints",
                column: "CompanyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DataPoints");

            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Industries");
        }
    }
}
