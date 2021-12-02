using Microsoft.EntityFrameworkCore.Migrations;

namespace BasicRequestLab.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    Cnum = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sname = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Comm = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.Cnum);
                });

            migrationBuilder.InsertData(
                table: "Vendors",
                columns: new[] { "Cnum", "City", "Comm", "Sname" },
                values: new object[,]
                {
                    { 1001, "London", 0.12m, "Peel" },
                    { 1002, "San Jose", 0.13m, "Serres" },
                    { 1004, "London", 0.11m, "Motika" },
                    { 1007, "Barcelona", 0.15m, "Rifkin" },
                    { 1003, "New York", 0.1m, "Axelrod" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vendors");
        }
    }
}
