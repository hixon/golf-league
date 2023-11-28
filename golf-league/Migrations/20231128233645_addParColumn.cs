using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace golf_league.Migrations
{
    /// <inheritdoc />
    public partial class addParColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Par",
                table: "HoleInfo",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Par",
                table: "HoleInfo");
        }
    }
}
