using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace School.Migrations
{
    public partial class names : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ranks_RankViewModel_RankViewModelTeacherId",
                table: "Ranks");

            migrationBuilder.DropTable(
                name: "RankViewModel");

            migrationBuilder.DropIndex(
                name: "IX_Ranks_RankViewModelTeacherId",
                table: "Ranks");

            migrationBuilder.DropColumn(
                name: "RankViewModelTeacherId",
                table: "Ranks");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RankViewModelTeacherId",
                table: "Ranks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RankViewModel",
                columns: table => new
                {
                    TeacherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RankId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RankViewModel", x => x.TeacherId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ranks_RankViewModelTeacherId",
                table: "Ranks",
                column: "RankViewModelTeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ranks_RankViewModel_RankViewModelTeacherId",
                table: "Ranks",
                column: "RankViewModelTeacherId",
                principalTable: "RankViewModel",
                principalColumn: "TeacherId");
        }
    }
}
