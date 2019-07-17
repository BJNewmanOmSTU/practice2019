using Microsoft.EntityFrameworkCore.Migrations;

namespace Practice.Domain.Migrations
{
    public partial class AddedStatusOrderUniqNumberRemovedCodefieldsintoCodemodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OrderUniqNumber",
                table: "Code",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Removed",
                table: "Code",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Code",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderUniqNumber",
                table: "Code");

            migrationBuilder.DropColumn(
                name: "Removed",
                table: "Code");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Code");
        }
    }
}
