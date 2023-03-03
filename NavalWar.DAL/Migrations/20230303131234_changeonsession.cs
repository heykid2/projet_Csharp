using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NavalWar.DAL.Migrations
{
    /// <inheritdoc />
    public partial class changeonsession : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ship_Player_PlayerUserId_PlayerSessionId",
                table: "Ship");

            migrationBuilder.DropForeignKey(
                name: "FK_Shot_Player_PlayerUserId_PlayerSessionId",
                table: "Shot");

            migrationBuilder.DropIndex(
                name: "IX_Shot_PlayerUserId_PlayerSessionId",
                table: "Shot");

            migrationBuilder.DropIndex(
                name: "IX_Ship_PlayerUserId_PlayerSessionId",
                table: "Ship");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Player",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "PlayerSessionId",
                table: "Shot");

            migrationBuilder.DropColumn(
                name: "PlayerSessionId",
                table: "Ship");

            migrationBuilder.RenameColumn(
                name: "PlayerUserId",
                table: "Shot",
                newName: "PlayerId");

            migrationBuilder.RenameColumn(
                name: "PlayerUserId",
                table: "Ship",
                newName: "PlayerId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Player",
                newName: "HasMapMapId");

            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "Player",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Player",
                table: "Player",
                column: "PlayerId");

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

            migrationBuilder.CreateTable(
                name: "Session",
                columns: table => new
                {
                    SessionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Player1Id = table.Column<int>(type: "int", nullable: false),
                    Player2Id = table.Column<int>(type: "int", nullable: false),
                    WinnerPlayerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session", x => x.SessionId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shot_PlayerId",
                table: "Shot",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ship_PlayerId",
                table: "Ship",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_HasMapMapId",
                table: "Player",
                column: "HasMapMapId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_SessionId",
                table: "Player",
                column: "SessionId");

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
                onDelete: ReferentialAction.NoAction,
                onUpdate: ReferentialAction.NoAction
            );

            migrationBuilder.AddForeignKey(
                name: "FK_Ship_Player_PlayerId",
                table: "Ship",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shot_Player_PlayerId",
                table: "Shot",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Session_Player_Player1Id",
                table: "Session",
                column: "Player1Id",
                principalTable: "Player",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Session_Player_Player2Id",
                table: "Session",
                column: "Player2Id",
                principalTable: "Player",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropForeignKey(
                name: "FK_Shot_Player_PlayerId",
                table: "Shot");

            migrationBuilder.DropTable(
                name: "Map");

            migrationBuilder.DropTable(
                name: "Session");

            migrationBuilder.DropIndex(
                name: "IX_Shot_PlayerId",
                table: "Shot");

            migrationBuilder.DropIndex(
                name: "IX_Ship_PlayerId",
                table: "Ship");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Player",
                table: "Player");

            migrationBuilder.DropIndex(
                name: "IX_Player_HasMapMapId",
                table: "Player");

            migrationBuilder.DropIndex(
                name: "IX_Player_SessionId",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "Player");

            migrationBuilder.RenameColumn(
                name: "PlayerId",
                table: "Shot",
                newName: "PlayerUserId");

            migrationBuilder.RenameColumn(
                name: "PlayerId",
                table: "Ship",
                newName: "PlayerUserId");

            migrationBuilder.RenameColumn(
                name: "HasMapMapId",
                table: "Player",
                newName: "UserId");

            migrationBuilder.AddColumn<int>(
                name: "PlayerSessionId",
                table: "Shot",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlayerSessionId",
                table: "Ship",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Player",
                table: "Player",
                columns: new[] { "UserId", "SessionId" });

            migrationBuilder.CreateIndex(
                name: "IX_Shot_PlayerUserId_PlayerSessionId",
                table: "Shot",
                columns: new[] { "PlayerUserId", "PlayerSessionId" });

            migrationBuilder.CreateIndex(
                name: "IX_Ship_PlayerUserId_PlayerSessionId",
                table: "Ship",
                columns: new[] { "PlayerUserId", "PlayerSessionId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Ship_Player_PlayerUserId_PlayerSessionId",
                table: "Ship",
                columns: new[] { "PlayerUserId", "PlayerSessionId" },
                principalTable: "Player",
                principalColumns: new[] { "UserId", "SessionId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Shot_Player_PlayerUserId_PlayerSessionId",
                table: "Shot",
                columns: new[] { "PlayerUserId", "PlayerSessionId" },
                principalTable: "Player",
                principalColumns: new[] { "UserId", "SessionId" });
        }
    }
}
