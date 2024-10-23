using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Danesh_Azmon.Migrations
{
    /// <inheritdoc />
    public partial class _1_Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_class",
                columns: table => new
                {
                    ClassId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_class", x => x.ClassId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_exam",
                columns: table => new
                {
                    ExamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_exam", x => x.ExamId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_user",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_user", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "tbl_examClass",
                columns: table => new
                {
                    ExamId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_examClass", x => new { x.ExamId, x.ClassId });
                    table.ForeignKey(
                        name: "FK_tbl_examClass_tbl_class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "tbl_class",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_examClass_tbl_exam_ExamId",
                        column: x => x.ExamId,
                        principalTable: "tbl_exam",
                        principalColumn: "ExamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_question",
                columns: table => new
                {
                    QuestionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_question", x => x.QuestionId);
                    table.ForeignKey(
                        name: "FK_tbl_question_tbl_exam_ExamId",
                        column: x => x.ExamId,
                        principalTable: "tbl_exam",
                        principalColumn: "ExamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tbl_studentClass",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    ClassId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_studentClass", x => new { x.StudentId, x.ClassId });
                    table.ForeignKey(
                        name: "FK_tbl_studentClass_tbl_class_ClassId",
                        column: x => x.ClassId,
                        principalTable: "tbl_class",
                        principalColumn: "ClassId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbl_studentClass_tbl_user_StudentId",
                        column: x => x.StudentId,
                        principalTable: "tbl_user",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbl_examClass_ClassId",
                table: "tbl_examClass",
                column: "ClassId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_question_ExamId",
                table: "tbl_question",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_tbl_studentClass_ClassId",
                table: "tbl_studentClass",
                column: "ClassId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_examClass");

            migrationBuilder.DropTable(
                name: "tbl_question");

            migrationBuilder.DropTable(
                name: "tbl_studentClass");

            migrationBuilder.DropTable(
                name: "tbl_exam");

            migrationBuilder.DropTable(
                name: "tbl_class");

            migrationBuilder.DropTable(
                name: "tbl_user");
        }
    }
}
