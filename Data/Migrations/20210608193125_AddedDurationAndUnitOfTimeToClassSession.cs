using Microsoft.EntityFrameworkCore.Migrations;

namespace MS587FinalProject.Data.Migrations
{
    public partial class AddedDurationAndUnitOfTimeToClassSession : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "ClassSessions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UnitOfTime",
                table: "ClassSessions",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "ClassSessions");

            migrationBuilder.DropColumn(
                name: "UnitOfTime",
                table: "ClassSessions");
        }
    }
}
