using Microsoft.EntityFrameworkCore.Migrations;

namespace SelfAplication.Migrations
{
    public partial class Spellos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Spells",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpellName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpellElement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpellLvl = table.Column<int>(type: "int", nullable: false),
                    SpellDmg = table.Column<int>(type: "int", nullable: false),
                    SpellRange = table.Column<int>(type: "int", nullable: false),
                    SpellCastTime = table.Column<int>(type: "int", nullable: false),
                    SpellConcetration = table.Column<int>(type: "int", nullable: false),
                    SpellDesc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spells", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Spells");
        }
    }
}
