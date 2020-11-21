using Microsoft.EntityFrameworkCore.Migrations;

namespace SelfAplication.Migrations
{
    public partial class AddedProperitiesInChatacter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdvancedBaseAtk",
                table: "Characters",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdvancedBaseAtk",
                table: "Characters");
        }
    }
}
