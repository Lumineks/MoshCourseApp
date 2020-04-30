using Microsoft.EntityFrameworkCore.Migrations;

namespace MoshCourseApp.Data.Migrations
{
    public partial class ExtendPopulationOfGenres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Genre (Name) VALUES ('Adventure')");
            migrationBuilder.Sql("INSERT INTO Genre (Name) VALUES ('Thriller')");
            migrationBuilder.Sql("INSERT INTO Genre (Name) VALUES ('Family')");
            migrationBuilder.Sql("INSERT INTO Genre (Name) VALUES ('Science-Fiction')");
            migrationBuilder.Sql("INSERT INTO Genre (Name) VALUES ('Romance')");
            migrationBuilder.Sql("INSERT INTO Genre (Name) VALUES ('Horror')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
