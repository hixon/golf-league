using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace golf_league.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePlayerTypeId_type : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_PlayerType_PlayerTypeId1",
                table: "Player");

            migrationBuilder.DropIndex(
                name: "IX_Player_PlayerTypeId1",
                table: "Player");

            migrationBuilder.DropColumn(
                name: "PlayerTypeId1",
                table: "Player");

            migrationBuilder.AlterColumn<long>(
                name: "PlayerTypeId",
                table: "Player",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Player_PlayerTypeId",
                table: "Player",
                column: "PlayerTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_PlayerType_PlayerTypeId",
                table: "Player",
                column: "PlayerTypeId",
                principalTable: "PlayerType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_PlayerType_PlayerTypeId",
                table: "Player");

            migrationBuilder.DropIndex(
                name: "IX_Player_PlayerTypeId",
                table: "Player");

            migrationBuilder.AlterColumn<int>(
                name: "PlayerTypeId",
                table: "Player",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "PlayerTypeId1",
                table: "Player",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_Player_PlayerTypeId1",
                table: "Player",
                column: "PlayerTypeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_PlayerType_PlayerTypeId1",
                table: "Player",
                column: "PlayerTypeId1",
                principalTable: "PlayerType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
