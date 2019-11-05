using Microsoft.EntityFrameworkCore.Migrations;

namespace myschool.Migrations
{
    public partial class modifying_all_models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Schools_SchoolId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_SchoolId",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "Schedules");

            migrationBuilder.RenameColumn(
                name: "score",
                table: "Grades",
                newName: "Score");

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "TeacherLectures",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Teacher",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentId",
                table: "schoolEducations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClassId",
                table: "Schedules",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Grades",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Payed",
                table: "EducStus",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    SchoolId = table.Column<int>(nullable: false),
                    EducationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Class_Educations_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Educations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Class_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Cash = table.Column<decimal>(nullable: false),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeacherLectures_ClassId",
                table: "TeacherLectures",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_schoolEducations_PaymentId",
                table: "schoolEducations",
                column: "PaymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_ClassId",
                table: "Schedules",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Class_EducationId",
                table: "Class",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Class_SchoolId",
                table: "Class",
                column: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Class_ClassId",
                table: "Schedules",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_schoolEducations_Payment_PaymentId",
                table: "schoolEducations",
                column: "PaymentId",
                principalTable: "Payment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherLectures_Class_ClassId",
                table: "TeacherLectures",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Class_ClassId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_schoolEducations_Payment_PaymentId",
                table: "schoolEducations");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherLectures_Class_ClassId",
                table: "TeacherLectures");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_TeacherLectures_ClassId",
                table: "TeacherLectures");

            migrationBuilder.DropIndex(
                name: "IX_schoolEducations_PaymentId",
                table: "schoolEducations");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_ClassId",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "TeacherLectures");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "schoolEducations");

            migrationBuilder.DropColumn(
                name: "ClassId",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "Payed",
                table: "EducStus");

            migrationBuilder.RenameColumn(
                name: "Score",
                table: "Grades",
                newName: "score");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Teacher",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Teacher",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SchoolId",
                table: "Schedules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_SchoolId",
                table: "Schedules",
                column: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Schools_SchoolId",
                table: "Schedules",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
