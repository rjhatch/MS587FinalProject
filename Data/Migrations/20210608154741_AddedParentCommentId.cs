using Microsoft.EntityFrameworkCore.Migrations;

namespace MS587FinalProject.Data.Migrations
{
    public partial class AddedParentCommentId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentCommentId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentCommentId",
                table: "Comments");
        }
    }
}
