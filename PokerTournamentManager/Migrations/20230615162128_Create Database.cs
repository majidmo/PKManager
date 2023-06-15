using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokerTournamentManager.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leagues",
                columns: table => new
                {
                    LeagueId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeagueName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leagues", x => x.LeagueId);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.PlayerId);
                });

            migrationBuilder.CreateTable(
                name: "Tournaments",
                columns: table => new
                {
                    TournamentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeagueId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Venue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaxParticipants = table.Column<int>(type: "int", nullable: false),
                    BuyIn = table.Column<decimal>(type: "money", nullable: false),
                    Rebuy = table.Column<decimal>(type: "money", nullable: false),
                    AddOn = table.Column<decimal>(type: "money", nullable: false),
                    MaxAddOnCount = table.Column<int>(type: "int", nullable: false),
                    Bounty = table.Column<decimal>(type: "money", nullable: false),
                    StackSizeStarting = table.Column<int>(type: "int", nullable: false),
                    StackSizeAddon = table.Column<int>(type: "int", nullable: false),
                    StackSizeRebuy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournaments", x => x.TournamentId);
                });

            migrationBuilder.CreateTable(
                name: "TournamentResults",
                columns: table => new
                {
                    TournamentResultId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TournamentId = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    IsPlayerEligibleForPrize = table.Column<bool>(type: "bit", nullable: false),
                    PrizeMoney = table.Column<decimal>(type: "money", nullable: false),
                    FinishPosition = table.Column<int>(type: "int", nullable: true),
                    RebuyCount = table.Column<int>(type: "int", nullable: false),
                    AddOnCount = table.Column<int>(type: "int", nullable: false),
                    BountiesWon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TournamentResults", x => x.TournamentResultId);
                    table.ForeignKey(
                        name: "FK_TournamentResults_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TournamentResults_Tournaments_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournaments",
                        principalColumn: "TournamentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "LeagueId", "EndTime", "LeagueName", "StartTime" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Freiburg's Tavern Poker Club", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabe's Poker League", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Raleigh Persian Club Poker League", new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "PlayerId", "UserName" },
                values: new object[,]
                {
                    { 1, "Saeid" },
                    { 2, "Masoud" },
                    { 3, "Nikolai" },
                    { 4, "Michael" },
                    { 5, "Silvia" },
                    { 6, "Simon" },
                    { 7, "Andreas" },
                    { 8, "Isabela" },
                    { 9, "Klaus" },
                    { 10, "Eva" },
                    { 11, "Vika" },
                    { 12, "Majid" },
                    { 13, "Sebastian" },
                    { 14, "Pedram" },
                    { 15, "Thomas" },
                    { 16, "Kiril" },
                    { 17, "Christoph" },
                    { 18, "Konstantin" },
                    { 19, "Mehdi" }
                });

            migrationBuilder.InsertData(
                table: "Tournaments",
                columns: new[] { "TournamentId", "AddOn", "Bounty", "BuyIn", "EndTime", "LeagueId", "MaxAddOnCount", "MaxParticipants", "Name", "Rebuy", "StackSizeAddon", "StackSizeRebuy", "StackSizeStarting", "StartTime", "Venue" },
                values: new object[,]
                {
                    { 1, 0m, 0m, 600m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, 0, "Gabe Fenton Openning $600 No Limit Holdem", 600m, 0, 0, 0, new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saeid's House" },
                    { 2, 0m, 0m, 25m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, 0, "Saeid #1 $25 No Limit Holdem", 25m, 0, 0, 0, new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saeid's House" },
                    { 3, 0m, 0m, 25m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, 0, "Saeid #2 $25 No Limit Holdem", 25m, 0, 0, 0, new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saeid's House" },
                    { 4, 0m, 0m, 50m, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, 0, "Saeid #3 $50 No Limit Holdem", 50m, 0, 0, 0, new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saeid's House" }
                });

            migrationBuilder.InsertData(
                table: "TournamentResults",
                columns: new[] { "TournamentResultId", "AddOnCount", "BountiesWon", "FinishPosition", "IsPlayerEligibleForPrize", "PlayerId", "PrizeMoney", "RebuyCount", "TournamentId" },
                values: new object[,]
                {
                    { 1, 0, 0, 1, true, 1, 163m, 0, 2 },
                    { 2, 0, 0, 2, true, 2, 97m, 1, 2 },
                    { 3, 0, 0, 3, true, 3, 65m, 1, 2 },
                    { 4, 0, 0, 4, true, 4, 0m, 0, 2 },
                    { 5, 0, 0, 5, true, 5, 0m, 0, 2 },
                    { 6, 0, 0, 6, true, 6, 0m, 1, 2 },
                    { 7, 0, 0, 7, true, 7, 0m, 1, 2 },
                    { 8, 0, 0, 8, true, 8, 0m, 0, 2 },
                    { 9, 0, 0, 9, true, 9, 0m, 0, 2 },
                    { 10, 0, 0, 3, true, 1, 85m, 2, 3 },
                    { 11, 0, 0, 2, true, 3, 127m, 1, 3 },
                    { 12, 0, 0, 1, true, 4, 213m, 0, 3 },
                    { 13, 0, 0, 9, true, 5, 0m, 0, 3 },
                    { 14, 0, 0, 8, true, 7, 0m, 1, 3 },
                    { 15, 0, 0, 7, true, 8, 0m, 2, 3 },
                    { 16, 0, 0, 4, true, 9, 0m, 0, 3 },
                    { 17, 0, 0, 5, true, 12, 0m, 0, 3 },
                    { 18, 0, 0, 6, true, 14, 0m, 0, 3 },
                    { 19, 0, 0, 10, true, 15, 0m, 1, 3 },
                    { 20, 0, 0, 1, true, 11, 325m, 0, 4 },
                    { 21, 0, 0, 2, true, 12, 195m, 1, 4 },
                    { 22, 0, 0, 3, true, 13, 130m, 1, 4 },
                    { 23, 0, 0, 4, true, 4, 0m, 0, 4 },
                    { 24, 0, 0, 5, true, 15, 0m, 0, 4 },
                    { 25, 0, 0, 6, true, 16, 0m, 1, 4 },
                    { 26, 0, 0, 7, true, 7, 0m, 1, 4 },
                    { 27, 0, 0, 8, true, 18, 0m, 0, 4 },
                    { 28, 0, 0, 9, true, 19, 0m, 0, 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_UserName",
                table: "Players",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TournamentResults_PlayerId",
                table: "TournamentResults",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_TournamentResults_TournamentId",
                table: "TournamentResults",
                column: "TournamentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leagues");

            migrationBuilder.DropTable(
                name: "TournamentResults");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Tournaments");
        }
    }
}
