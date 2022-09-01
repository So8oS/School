using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School.Migrations
{
    public partial class neww : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentRankViewModelStudentId",
                table: "Ranks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StudentRankViewModel",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Grade = table.Column<int>(type: "int", nullable: false),
                    RankId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentRankViewModel", x => x.StudentId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ranks_StudentRankViewModelStudentId",
                table: "Ranks",
                column: "StudentRankViewModelStudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ranks_StudentRankViewModel_StudentRankViewModelStudentId",
                table: "Ranks",
                column: "StudentRankViewModelStudentId",
                principalTable: "StudentRankViewModel",
                principalColumn: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ranks_StudentRankViewModel_StudentRankViewModelStudentId",
                table: "Ranks");

            migrationBuilder.DropTable(
                name: "StudentRankViewModel");

            migrationBuilder.DropIndex(
                name: "IX_Ranks_StudentRankViewModelStudentId",
                table: "Ranks");

            migrationBuilder.DropColumn(
                name: "StudentRankViewModelStudentId",
                table: "Ranks");
        }
    }
}
