using Microsoft.EntityFrameworkCore.Migrations;

namespace SpaceExplorePlanetService.Migrations
{
    public partial class populatePlantes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            INSERT INTO Planets VALUES('Mercur','Mercur',null,1);
            INSERT INTO Planets VALUES('Venus','Venus',null,1);
            INSERT INTO Planets VALUES('Pamant','Pamant',null,1);
            INSERT INTO Planets VALUES('R2D2','R2D2',null,1);
            INSERT INTO Planets VALUES('Oban','Oban',null,1);
            INSERT INTO Planets VALUES('X210Q','X210Q',null,1);
            INSERT INTO Planets VALUES('Pluto','Pluto',null,1);
            INSERT INTO Planets VALUES('Lapusel','Lapusel',null,1);
            INSERT INTO Planets VALUES('Recea','Recea',null,1);
            INSERT INTO Planets VALUES('Jupiter','Jupiter',null,1);
            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE FROM Planets");
        }
    }
}
