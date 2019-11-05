using Microsoft.EntityFrameworkCore.Migrations;

namespace myschool.Migrations
{
    public partial class modifying_edustu_add_year : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "EducStus",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Year",
                table: "EducStus");
        }
    }
}
