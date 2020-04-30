using Microsoft.EntityFrameworkCore.Migrations;

namespace MoshCourseApp.Data.Migrations
{
    public partial class SetNameOfMembershipType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Update MembershipType SET Name = 'Pay as You Go' WHERE id = 1");
            migrationBuilder.Sql("Update MembershipType SET Name = 'Monthly' WHERE id = 2");
            migrationBuilder.Sql("Update MembershipType SET Name = 'Quarterly' WHERE id = 3");
            migrationBuilder.Sql("Update MembershipType SET Name = 'Annual' WHERE id = 4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
