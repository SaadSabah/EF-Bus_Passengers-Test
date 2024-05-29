using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Bus_Passengers_Test.Migrations
{
    /// <inheritdoc />
    public partial class Createthebusandpassengerstables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "busses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BussName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfseats = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_busses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "passengers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BussId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_passengers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_passengers_busses_BussId",
                        column: x => x.BussId,
                        principalTable: "busses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_passengers_BussId",
                table: "passengers",
                column: "BussId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "passengers");

            migrationBuilder.DropTable(
                name: "busses");
        }
    }
}
