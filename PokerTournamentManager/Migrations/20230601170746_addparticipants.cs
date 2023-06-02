using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PokerTournamentManager.Migrations
{
    public partial class addparticipants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FinishPosition",
                table: "Participants",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "IsPlayerEligibleForPrize",
                table: "Participants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Participants",
                columns: new[] { "ParticipantId", "AddOnCount", "BountiesWon", "FinishPosition", "IsPlayerEligibleForPrize", "PlayerId", "RebuyCount", "TournamentId" },
                values: new object[,]
                {
                    { 1, 0, 0, 1, true, 1, 0, 2 },
                    { 2, 0, 0, 2, true, 2, 1, 2 },
                    { 3, 0, 0, 3, true, 3, 1, 2 },
                    { 4, 0, 0, 4, true, 4, 0, 2 },
                    { 5, 0, 0, 5, true, 5, 0, 2 },
                    { 6, 0, 0, 6, true, 6, 1, 2 },
                    { 7, 0, 0, 7, true, 7, 1, 2 },
                    { 8, 0, 0, 8, true, 8, 0, 2 },
                    { 9, 0, 0, 9, true, 9, 0, 2 },
                    { 10, 0, 0, 3, true, 1, 1, 3 },
                    { 11, 0, 0, 2, true, 3, 1, 3 },
                    { 12, 0, 0, 1, true, 4, 0, 3 },
                    { 13, 0, 0, 9, true, 5, 0, 3 },
                    { 14, 0, 0, 8, true, 7, 1, 3 },
                    { 15, 0, 0, 7, true, 8, 1, 3 },
                    { 16, 0, 0, 4, true, 9, 0, 3 },
                    { 17, 0, 0, 5, true, 12, 0, 3 },
                    { 18, 0, 0, 6, true, 14, 0, 3 },
                    { 19, 0, 0, 10, true, 15, 0, 3 },
                    { 20, 0, 0, 1, true, 11, 0, 4 },
                    { 21, 0, 0, 2, true, 12, 1, 4 },
                    { 22, 0, 0, 3, true, 13, 1, 4 },
                    { 23, 0, 0, 4, true, 4, 0, 4 },
                    { 24, 0, 0, 5, true, 15, 0, 4 },
                    { 25, 0, 0, 6, true, 16, 1, 4 },
                    { 26, 0, 0, 7, true, 7, 1, 4 },
                    { 27, 0, 0, 8, true, 18, 0, 4 },
                    { 28, 0, 0, 9, true, 19, 0, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Participants",
                keyColumn: "ParticipantId",
                keyValue: 28);

            migrationBuilder.DropColumn(
                name: "IsPlayerEligibleForPrize",
                table: "Participants");

            migrationBuilder.AlterColumn<int>(
                name: "FinishPosition",
                table: "Participants",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
