using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace sikho_backend.Migrations
{
    /// <inheritdoc />
    public partial class JobGrowthPollDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobGrowthPolls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    percent_change = table.Column<int>(type: "int", nullable: false),
                    ip_address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    occupation_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobGrowthPolls", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobGrowthPolls");
        }
    }
}
