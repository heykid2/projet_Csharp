using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NavalWar.DAL.Migrations
{
    /// <inheritdoc />
    public partial class chngSessPlay : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Player1Ready",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "Player2Ready",
                table: "Sessions");

            migrationBuilder.AddColumn<bool>(
                name: "IsReady",
                table: "Player",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReady",
                table: "Player");

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
    }
}
