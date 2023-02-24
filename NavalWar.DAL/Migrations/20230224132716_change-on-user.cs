using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NavalWar.DAL.Migrations
{
    /// <inheritdoc />
    public partial class changeonuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_User_UserName",
                table: "Player");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Player",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Player_User_UserName",
                table: "Player",
                column: "UserName",
                principalTable: "User",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_User_UserName",
                table: "Player");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Player",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_User_UserName",
                table: "Player",
                column: "UserName",
                principalTable: "User",
                principalColumn: "Name");
        }
    }
}
