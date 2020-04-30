using Microsoft.EntityFrameworkCore.Migrations;

namespace MoshCourseApp.Data.Migrations
{
    public partial class SetBirthDateOfCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Update Customers SET BirthDate = '1/1/1980' WHERE id = 1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
