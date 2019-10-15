using Microsoft.EntityFrameworkCore.Migrations;

namespace myschool.Migrations
{
    public partial class updating_studen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Students_StudentId",
                table: "Educations");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Educations",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Students_StudentId",
                table: "Educations",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Educations_Students_StudentId",
                table: "Educations");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Educations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Educations_Students_StudentId",
                table: "Educations",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
