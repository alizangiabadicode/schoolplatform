using Microsoft.EntityFrameworkCore.Migrations;

namespace myschool.Migrations
{
    public partial class adding_schoolEducations_teacherschool_teacherlecture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "Educations",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "schoolEducations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolId = table.Column<int>(nullable: false),
                    EducationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_schoolEducations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_schoolEducations_Educations_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Educations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_schoolEducations_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teacher",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    ScheduleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teacher", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teacher_Schedules_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "Schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TeacherLectures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherId = table.Column<int>(nullable: false),
                    LectureId = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherLectures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherLectures_Lectures_LectureId",
                        column: x => x.LectureId,
                        principalTable: "Lectures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherLectures_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherSchools",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherId = table.Column<int>(nullable: false),
                    SchoolId = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherSchools", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeacherSchools_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherSchools_Teacher_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teacher",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Educations_TeacherId",
                table: "Educations",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_schoolEducations_EducationId",
                table: "schoolEducations",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_schoolEducations_SchoolId",
                table: "schoolEducations",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Teacher_ScheduleId",
                table: "Teacher",
                column: "ScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherLectures_LectureId",
                table: "TeacherLectures",
                column: "LectureId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherLectures_TeacherId",
                table: "TeacherLectures",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSchools_SchoolId",
                table: "TeacherSchools",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherSchools_TeacherId",
                table: "TeacherSchools",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Teacher_TeacherId",
                table: "Educations",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Teacher_TeacherId",
                table: "Educations");

            migrationBuilder.DropTable(
                name: "schoolEducations");

            migrationBuilder.DropTable(
                name: "TeacherLectures");

            migrationBuilder.DropTable(
                name: "TeacherSchools");

            migrationBuilder.DropTable(
                name: "Teacher");

            migrationBuilder.DropIndex(
                name: "IX_Educations_TeacherId",
                table: "Educations");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Educations");
        }
    }
}
