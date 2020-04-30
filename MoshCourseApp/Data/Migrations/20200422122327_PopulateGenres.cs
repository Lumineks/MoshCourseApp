using Microsoft.EntityFrameworkCore.Migrations;

namespace MoshCourseApp.Data.Migrations
{
    public partial class PopulateGenres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.Sql("INSERT INTO Genre (Name) VALUES ('Action')");
            migrationBuilder.Sql("INSERT INTO Genre (Name) VALUES ('Comedy')");            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
