using Microsoft.EntityFrameworkCore.Migrations;

namespace myschool.Migrations
{
    public partial class deleting_code_from_education : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "code",
                table: "Educations");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "code",
                table: "Educations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
