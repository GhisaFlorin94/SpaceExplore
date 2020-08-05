using Microsoft.EntityFrameworkCore.Migrations;

namespace SpaceExplorePlanetService.Migrations
{
    public partial class AddCrewIdOnPlanet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Planets_Descriptions_DescriptionId",
                table: "Planets");

            migrationBuilder.DropForeignKey(
                name: "FK_Robots_Planets_PlanetId",
                table: "Robots");

            migrationBuilder.DropTable(
                name: "Descriptions");

            migrationBuilder.DropIndex(
                name: "IX_Robots_PlanetId",
                table: "Robots");

            migrationBuilder.DropIndex(
                name: "IX_Planets_DescriptionId",
                table: "Planets");

            migrationBuilder.DropColumn(
                name: "PlanetId",
                table: "Robots");

            migrationBuilder.DropColumn(
                name: "DescriptionId",
                table: "Planets");

            migrationBuilder.AddColumn<int>(
                name: "CrewId",
                table: "Planets",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Planets",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CrewId",
                table: "Planets");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Planets");

            migrationBuilder.AddColumn<int>(
                name: "PlanetId",
                table: "Robots",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DescriptionId",
                table: "Planets",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Descriptions",
                columns: table => new
                {
                    DescriptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaptainId = table.Column<int>(type: "int", nullable: false),
                    CaptainName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descriptions", x => x.DescriptionId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Robots_PlanetId",
                table: "Robots",
                column: "PlanetId");

            migrationBuilder.CreateIndex(
                name: "IX_Planets_DescriptionId",
                table: "Planets",
                column: "DescriptionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Planets_Descriptions_DescriptionId",
                table: "Planets",
                column: "DescriptionId",
                principalTable: "Descriptions",
                principalColumn: "DescriptionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Robots_Planets_PlanetId",
                table: "Robots",
                column: "PlanetId",
                principalTable: "Planets",
                principalColumn: "PlanetId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
