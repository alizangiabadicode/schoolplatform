using Microsoft.EntityFrameworkCore.Migrations;

namespace myschool.Migrations
{
    public partial class adding_education_lecture_and_extending_student : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "HomePhoneNumber",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NationalCode",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StuCode",
                table: "Students",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StuPhoneNumber",
                table: "Students",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    code = table.Column<int>(nullable: false),
                    Grade = table.Column<double>(nullable: false),
                    StudentId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Educations_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lectures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    EducationId = table.Column<int>(nullable: true),
                    Factor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lectures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lectures_Educations_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Educations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Educations_StudentId",
                table: "Educations",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Lectures_EducationId",
                table: "Lectures",
                column: "EducationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lectures");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "HomePhoneNumber",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "NationalCode",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StuCode",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StuPhoneNumber",
                table: "Students");
        }
    }
}
