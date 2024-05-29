using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EF_Bus_Passengers_Test.Migrations
{
    /// <inheritdoc />
    public partial class updatethebusandpassengerstables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "busses",
                columns: new[] { "Id", "BussName", "NumberOfseats" },
                values: new object[,]
                {
                    { 1, "The Malmö Mover", 40 },
                    { 2, "The Uppsala Uplift", 50 }
                });

            migrationBuilder.InsertData(
                table: "passengers",
                columns: new[] { "Id", "BussId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 1, "Saad", "Sabah" },
                    { 2, 1, "Ali", "Rami" },
                    { 3, 2, "Arai", "Mani" },
                    { 4, 2, "Noor", "Lother" },
                    { 5, 2, "Sara", "Wriwei" },
                    { 6, 2, "Hamad", "Mohamd" },
                    { 7, 2, "Solo", "Hussain" },
                    { 8, 1, "Ziko", "Fadi" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "busses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "busses",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
