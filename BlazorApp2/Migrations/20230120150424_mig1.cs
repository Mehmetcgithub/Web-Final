using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp2.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "habers",
                columns: table => new
                {
                    HaberId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HaberTitle = table.Column<string>(nullable: true),
                    HaberDescription = table.Column<string>(nullable: true),
                    HaberAuthor = table.Column<string>(nullable: true),
                    HaberImage = table.Column<string>(nullable: true),
                    HaberCategory = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_habers", x => x.HaberId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "habers");
        }
    }
}
