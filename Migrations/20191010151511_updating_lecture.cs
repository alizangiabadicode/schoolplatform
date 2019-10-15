using Microsoft.EntityFrameworkCore.Migrations;

namespace myschool.Migrations
{
    public partial class updating_lecture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lectures_Educations_EducationId",
                table: "Lectures");

            migrationBuilder.AlterColumn<int>(
                name: "EducationId",
                table: "Lectures",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Lectures_Educations_EducationId",
                table: "Lectures",
                column: "EducationId",
                principalTable: "Educations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lectures_Educations_EducationId",
                table: "Lectures");

            migrationBuilder.AlterColumn<int>(
                name: "EducationId",
                table: "Lectures",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Lectures_Educations_EducationId",
                table: "Lectures",
                column: "EducationId",
                principalTable: "Educations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
