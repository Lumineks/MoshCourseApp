using Microsoft.EntityFrameworkCore.Migrations;

namespace MoshCourseApp.Data.Migrations
{
    public partial class AddIsSubscribedToNewsLetter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSubrscribedToNewsLetter",
                table: "Customers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSubrscribedToNewsLetter",
                table: "Customers");
        }
    }
}
