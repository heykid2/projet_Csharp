using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NavalWar.DAL.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    SessionId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => new { x.UserId, x.SessionId });
                    table.ForeignKey(
                        name: "FK_Player_User_UserName",
                        column: x => x.UserName,
                        principalTable: "User",
                        principalColumn: "Name");
                });

            migrationBuilder.CreateTable(
                name: "Ship",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PV = table.Column<int>(type: "int", nullable: false),
                    PlayerSessionId = table.Column<int>(type: "int", nullable: true),
                    PlayerUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ship", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ship_Player_PlayerUserId_PlayerSessionId",
                        columns: x => new { x.PlayerUserId, x.PlayerSessionId },
                        principalTable: "Player",
                        principalColumns: new[] { "UserId", "SessionId" });
                });

            migrationBuilder.CreateTable(
                name: "Shot",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    X = table.Column<int>(type: "int", nullable: false),
                    Y = table.Column<int>(type: "int", nullable: false),
                    IsHit = table.Column<bool>(type: "bit", nullable: false),
                    PlayerSessionId = table.Column<int>(type: "int", nullable: true),
                    PlayerUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shot", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shot_Player_PlayerUserId_PlayerSessionId",
                        columns: x => new { x.PlayerUserId, x.PlayerSessionId },
                        principalTable: "Player",
                        principalColumns: new[] { "UserId", "SessionId" });
                });

            migrationBuilder.CreateIndex(
                name: "IX_Player_UserName",
                table: "Player",
                column: "UserName");

            migrationBuilder.CreateIndex(
                name: "IX_Ship_PlayerUserId_PlayerSessionId",
                table: "Ship",
                columns: new[] { "PlayerUserId", "PlayerSessionId" });

            migrationBuilder.CreateIndex(
                name: "IX_Shot_PlayerUserId_PlayerSessionId",
                table: "Shot",
                columns: new[] { "PlayerUserId", "PlayerSessionId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ship");

            migrationBuilder.DropTable(
                name: "Shot");

            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
