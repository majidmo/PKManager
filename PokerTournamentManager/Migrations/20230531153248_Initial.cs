using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokerTournamentManager.Migrations
{
    public partial class Initial : Migration
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
                    BuyIn = table.Column<double>(type: "float", nullable: false),
                    Rebuy = table.Column<double>(type: "float", nullable: false),
                    AddOn = table.Column<double>(type: "float", nullable: false),
                    MaxAddOnCount = table.Column<int>(type: "int", nullable: false),
                    Bounty = table.Column<double>(type: "float", nullable: false),
                    StackSizeStarting = table.Column<int>(type: "int", nullable: false),
                    StackSizeAddon = table.Column<int>(type: "int", nullable: false),
                    StackSizeRebuy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournaments", x => x.TournamentId);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    ParticipantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TournamentId = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false),
                    FinishPosition = table.Column<int>(type: "int", nullable: false),
                    RebuyCount = table.Column<int>(type: "int", nullable: false),
                    AddOnCount = table.Column<int>(type: "int", nullable: false),
                    BountiesWon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.ParticipantId);
                    table.ForeignKey(
                        name: "FK_Participants_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "PlayerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Participants_Tournaments_TournamentId",
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
                    { 1, 0.0, 0.0, 600.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, 0, "Gabe Fenton Openning $600 No Limit Holdem", 600.0, 0, 0, 0, new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saeid's House" },
                    { 2, 0.0, 0.0, 25.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, 0, "Saeid #1 $25 No Limit Holdem", 25.0, 0, 0, 0, new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saeid's House" },
                    { 3, 0.0, 0.0, 25.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, 0, "Saeid #2 $25 No Limit Holdem", 25.0, 0, 0, 0, new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saeid's House" },
                    { 4, 0.0, 0.0, 50.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, 0, "Saeid #3 $50 No Limit Holdem", 50.0, 0, 0, 0, new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saeid's House" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Participants_PlayerId",
                table: "Participants",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_TournamentId",
                table: "Participants",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_UserName",
                table: "Players",
                column: "UserName",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Leagues");

            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Tournaments");
        }
    }
}
