using Microsoft.EntityFrameworkCore.Migrations;

namespace SpaceExploreCrewService.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Captains",
                columns: table => new
                {
                    CaptainId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaptainName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Captains", x => x.CaptainId);
                });

            migrationBuilder.CreateTable(
                name: "Shuttles",
                columns: table => new
                {
                    ShuttleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShuttleName = table.Column<string>(nullable: false),
                    ShuttleTire = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shuttles", x => x.ShuttleId);
                });

            migrationBuilder.CreateTable(
                name: "Crews",
                columns: table => new
                {
                    CrewId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaptainId = table.Column<int>(nullable: false),
                    ShuttleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crews", x => x.CrewId);
                    table.ForeignKey(
                        name: "FK_Crews_Captains_CaptainId",
                        column: x => x.CaptainId,
                        principalTable: "Captains",
                        principalColumn: "CaptainId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Crews_Shuttles_ShuttleId",
                        column: x => x.ShuttleId,
                        principalTable: "Shuttles",
                        principalColumn: "ShuttleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Robots",
                columns: table => new
                {
                    RobotId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RobotName = table.Column<string>(nullable: true),
                    ManufacturingYear = table.Column<int>(nullable: false),
                    CrewId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Robots", x => x.RobotId);
                    table.ForeignKey(
                        name: "FK_Robots_Crews_CrewId",
                        column: x => x.CrewId,
                        principalTable: "Crews",
                        principalColumn: "CrewId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Crews_CaptainId",
                table: "Crews",
                column: "CaptainId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Crews_ShuttleId",
                table: "Crews",
                column: "ShuttleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Robots_CrewId",
                table: "Robots",
                column: "CrewId");

            migrationBuilder.Sql(@"
            DECLARE @FlorinId INT, @SorinaId INT, @GeorgeId INT, @CristinaId INT, @GhisaId INT, @ArrowId INT, @DaciaId INT, @MuskId INT, @AbacId INT, @StarId INT, @Crew1Id INT
                  , @Crew2Id INT, @Crew3Id INT, @Crew4Id INT, @Crew5Id INT

            INSERT INTO Captains VALUES('Florin');
            SET @FlorinId = SCOPE_IDENTITY();
            INSERT INTO Captains VALUES('Sorina');
            SET @SorinaId = SCOPE_IDENTITY();
            INSERT INTO Captains VALUES('George');
            SET @GeorgeId = SCOPE_IDENTITY();
            INSERT INTO Captains VALUES('Cristina');
            SET @CristinaId = SCOPE_IDENTITY();
            INSERT INTO Captains VALUES('Ghisa');
            SET @GhisaId = SCOPE_IDENTITY();


            INSERT INTO Shuttles VALUES('Speed Arrow', 4);
            SET @ArrowId = SCOPE_IDENTITY();
            INSERT INTO Shuttles VALUES('Dacia Thrust', 2);
            SET @DaciaId = SCOPE_IDENTITY();
            INSERT INTO Shuttles VALUES('Musk Eagle', 1);
            SET @MuskId = SCOPE_IDENTITY();
            INSERT INTO Shuttles VALUES('Abac Falcon', 5);
            SET @AbacId = SCOPE_IDENTITY();
            INSERT INTO Shuttles VALUES('Star Destroyer', 1);
            SET @StarId = SCOPE_IDENTITY();


            INSERT INTO Crews VALUES(@FlorinId, @ArrowId);
            SET @Crew1Id = SCOPE_IDENTITY();
            INSERT INTO Crews VALUES(@GhisaId, @DaciaId);
            SET @Crew2Id = SCOPE_IDENTITY();
            INSERT INTO Crews VALUES(@SorinaId, @AbacId);
            SET @Crew3Id = SCOPE_IDENTITY();
            INSERT INTO Crews VALUES(@GeorgeId, @MuskId);
            SET @Crew4Id = SCOPE_IDENTITY();
            INSERT INTO Crews VALUES(@CristinaId, @StarId);
            SET @Crew5Id = SCOPE_IDENTITY();



            INSERT INTO Robots VALUES('R120', 2500, @Crew1Id);
            INSERT INTO Robots VALUES('R130', 2520, @Crew1Id);
            INSERT INTO Robots VALUES('F120', 2515, @Crew1Id);
            INSERT INTO Robots VALUES('HG40', 2513, @Crew2Id);
            INSERT INTO Robots VALUES('RX120', 2519, @Crew2Id);
            INSERT INTO Robots VALUES('RX121', 2520, @Crew3Id);
            INSERT INTO Robots VALUES('RX122', 2530, @Crew3Id);
            INSERT INTO Robots VALUES('TX122', 2530, @Crew4Id);
            INSERT INTO Robots VALUES('RX132', 2511, @Crew4Id);
            INSERT INTO Robots VALUES('RY142', 2531, @Crew5Id);
            INSERT INTO Robots VALUES('RY143', 2532, @Crew5Id);
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Robots");

            migrationBuilder.DropTable(
                name: "Crews");

            migrationBuilder.DropTable(
                name: "Captains");

            migrationBuilder.DropTable(
                name: "Shuttles");

            migrationBuilder.Sql(@" 
                Delete From Crews;
                Delete From Captains;
                Delete From Shuttles;
                Delete From Robots;    
                ");
        
        }
    }
}
