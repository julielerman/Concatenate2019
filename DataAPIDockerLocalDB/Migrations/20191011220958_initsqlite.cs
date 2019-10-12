using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAPI_LocalDB.Migrations
{
    public partial class initsqlite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Magazine",
                columns: table => new
                {
                    MagazineId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Magazine", x => x.MagazineId);
                });

            migrationBuilder.InsertData(
                table: "Magazine",
                columns: new[] { "MagazineId", "Name" },
                values: new object[] { 1, "Concatenate Magazine" });

            migrationBuilder.InsertData(
                table: "Magazine",
                columns: new[] { "MagazineId", "Name" },
                values: new object[] { 2, "Docker Magazine" });

            migrationBuilder.InsertData(
                table: "Magazine",
                columns: new[] { "MagazineId", "Name" },
                values: new object[] { 3, "EFCore Magazine" });

            migrationBuilder.InsertData(
                table: "Magazine",
                columns: new[] { "MagazineId", "Name" },
                values: new object[] { 4, "SQLite Magazine" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Magazine");
        }
    }
}
