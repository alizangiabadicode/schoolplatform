using Microsoft.EntityFrameworkCore.Migrations;

namespace myschool.Migrations
{
    public partial class moving_Grade_from_education_to_edustu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Educations");

            migrationBuilder.AddColumn<double>(
                name: "Grade",
                table: "EducStus",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grade",
                table: "EducStus");

            migrationBuilder.AddColumn<double>(
                name: "Grade",
                table: "Educations",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
