using Microsoft.EntityFrameworkCore.Migrations;

namespace SelfAplication.Migrations
{
    public partial class AddedGoldInCharater : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Gold",
                table: "Characters",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gold",
                table: "Characters");
        }
    }
}
