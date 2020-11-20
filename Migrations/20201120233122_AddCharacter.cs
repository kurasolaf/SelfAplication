using Microsoft.EntityFrameworkCore.Migrations;

namespace SelfAplication.Migrations
{
    public partial class AddCharacter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Desc",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Done",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Characters");

            migrationBuilder.AddColumn<int>(
                name: "AbilitiesPoints",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AbilityAlchemy",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AbilityConcetration",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AdvancedCharacterDesc",
                table: "Characters",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdvancedDodge",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AdvancedMeleAtk",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AdvancedRangedAtk",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AdvancedWill",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BasicClass",
                table: "Characters",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BasicLvl",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BasicName",
                table: "Characters",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BasicRace",
                table: "Characters",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Inventory",
                table: "Characters",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatCharisma",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatConstitution",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatDexterity",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatInteligence",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatStrenght",
                table: "Characters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatWisdom",
                table: "Characters",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AbilitiesPoints",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "AbilityAlchemy",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "AbilityConcetration",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "AdvancedCharacterDesc",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "AdvancedDodge",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "AdvancedMeleAtk",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "AdvancedRangedAtk",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "AdvancedWill",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "BasicClass",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "BasicLvl",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "BasicName",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "BasicRace",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "Inventory",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "StatCharisma",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "StatConstitution",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "StatDexterity",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "StatInteligence",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "StatStrenght",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "StatWisdom",
                table: "Characters");

            migrationBuilder.AddColumn<string>(
                name: "Desc",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Done",
                table: "Characters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Characters",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
