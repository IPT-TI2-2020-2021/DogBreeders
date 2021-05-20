using Microsoft.EntityFrameworkCore.Migrations;

namespace DogBreeders.Migrations
{
    public partial class NewMNRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DogsVeterinary",
                columns: table => new
                {
                    ListOfDogsId = table.Column<int>(type: "int", nullable: false),
                    VetsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogsVeterinary", x => new { x.ListOfDogsId, x.VetsId });
                    table.ForeignKey(
                        name: "FK_DogsVeterinary_Dogs_ListOfDogsId",
                        column: x => x.ListOfDogsId,
                        principalTable: "Dogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DogsVeterinary_Vets_VetsId",
                        column: x => x.VetsId,
                        principalTable: "Vets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DogsVeterinary_VetsId",
                table: "DogsVeterinary",
                column: "VetsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DogsVeterinary");

            migrationBuilder.DropTable(
                name: "Vets");
        }
    }
}
