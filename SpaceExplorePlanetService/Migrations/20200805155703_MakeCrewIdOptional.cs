using Microsoft.EntityFrameworkCore.Migrations;

namespace SpaceExplorePlanetService.Migrations
{
    public partial class MakeCrewIdOptional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CrewId",
                table: "Planets",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.Sql(@"
             Update Planets
             Set CrewId = null
             Where CrewId = 0;
   
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CrewId",
                table: "Planets",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
