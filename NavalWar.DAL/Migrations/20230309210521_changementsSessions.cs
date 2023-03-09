using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NavalWar.DAL.Migrations
{
    /// <inheritdoc />
    public partial class changementsSessions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isVertical",
                table: "Ships",
                newName: "IsVertical");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Ships",
                newName: "ShipId");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Ships",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CurrentPlayer",
                table: "Sessions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Player1Ready",
                table: "Sessions",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Player2Ready",
                table: "Sessions",
                type: "bit",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "CurrentPlayer",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "Player1Ready",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "Player2Ready",
                table: "Sessions");

            migrationBuilder.RenameColumn(
                name: "IsVertical",
                table: "Ships",
                newName: "isVertical");

            migrationBuilder.RenameColumn(
                name: "ShipId",
                table: "Ships",
                newName: "ID");
        }
    }
}
