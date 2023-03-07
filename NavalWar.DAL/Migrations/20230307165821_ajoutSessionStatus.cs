using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NavalWar.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ajoutSessionStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_Map_HasMapMapId",
                table: "Player");

            migrationBuilder.DropForeignKey(
                name: "FK_Player_Session_SessionId",
                table: "Player");

            migrationBuilder.DropForeignKey(
                name: "FK_Ship_Player_PlayerId",
                table: "Ship");

            migrationBuilder.DropTable(
                name: "Map");

            migrationBuilder.DropIndex(
                name: "IX_Player_HasMapMapId",
                table: "Player");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ship",
                table: "Ship");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Session",
                table: "Session");

            migrationBuilder.DropColumn(
                name: "HasMapMapId",
                table: "Player");

            migrationBuilder.RenameTable(
                name: "Ship",
                newName: "Ships");

            migrationBuilder.RenameTable(
                name: "Session",
                newName: "Sessions");

            migrationBuilder.RenameIndex(
                name: "IX_Ship_PlayerId",
                table: "Ships",
                newName: "IX_Ships_PlayerId");

            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "Ships",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "X",
                table: "Ships",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Y",
                table: "Ships",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "isVertical",
                table: "Ships",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "Player2Id",
                table: "Sessions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Player1Id",
                table: "Sessions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Sessions",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ships",
                table: "Ships",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sessions",
                table: "Sessions",
                column: "SessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Sessions_SessionId",
                table: "Player",
                column: "SessionId",
                principalTable: "Sessions",
                principalColumn: "SessionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ships_Player_PlayerId",
                table: "Ships",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "PlayerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_Sessions_SessionId",
                table: "Player");

            migrationBuilder.DropForeignKey(
                name: "FK_Ships_Player_PlayerId",
                table: "Ships");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ships",
                table: "Ships");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sessions",
                table: "Sessions");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "X",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "Y",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "isVertical",
                table: "Ships");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Sessions");

            migrationBuilder.RenameTable(
                name: "Ships",
                newName: "Ship");

            migrationBuilder.RenameTable(
                name: "Sessions",
                newName: "Session");

            migrationBuilder.RenameIndex(
                name: "IX_Ships_PlayerId",
                table: "Ship",
                newName: "IX_Ship_PlayerId");

            migrationBuilder.AddColumn<int>(
                name: "HasMapMapId",
                table: "Player",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Player2Id",
                table: "Session",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Player1Id",
                table: "Session",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ship",
                table: "Ship",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Session",
                table: "Session",
                column: "SessionId");

            migrationBuilder.CreateTable(
                name: "Map",
                columns: table => new
                {
                    MapId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Map", x => x.MapId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Player_HasMapMapId",
                table: "Player",
                column: "HasMapMapId");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Map_HasMapMapId",
                table: "Player",
                column: "HasMapMapId",
                principalTable: "Map",
                principalColumn: "MapId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Session_SessionId",
                table: "Player",
                column: "SessionId",
                principalTable: "Session",
                principalColumn: "SessionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ship_Player_PlayerId",
                table: "Ship",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "PlayerId");
        }
    }
}
