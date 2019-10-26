using Microsoft.EntityFrameworkCore.Migrations;

namespace myschool.Migrations
{
    public partial class changing_teacher_schedule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DayOfWeek",
                table: "Schedules",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LectureId",
                table: "Schedules",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Schedules",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_LectureId",
                table: "Schedules",
                column: "LectureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Lectures_LectureId",
                table: "Schedules",
                column: "LectureId",
                principalTable: "Lectures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Lectures_LectureId",
                table: "Schedules");

            migrationBuilder.DropIndex(
                name: "IX_Schedules_LectureId",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "DayOfWeek",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "LectureId",
                table: "Schedules");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Schedules");
        }
    }
}
