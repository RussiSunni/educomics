using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EnglishEducomics.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    IsCorrectOption = table.Column<bool>(nullable: false),
                    QuestionID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Lesson",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    ObjectiveID = table.Column<Guid>(nullable: false),
                    IsComplete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lesson", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Objective",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsMastered = table.Column<bool>(nullable: false),
                    CourseID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objective", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Content = table.Column<string>(nullable: true),
                    IsMastered = table.Column<bool>(nullable: false),
                    ObjectiveID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    InitialLevel = table.Column<int>(nullable: false),
                    DateJoined = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropTable(
                name: "Lesson");

            migrationBuilder.DropTable(
                name: "Objective");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
