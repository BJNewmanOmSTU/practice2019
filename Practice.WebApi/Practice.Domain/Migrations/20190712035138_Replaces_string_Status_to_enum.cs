using Microsoft.EntityFrameworkCore.Migrations;

namespace Practice.Domain.Migrations
{
    public partial class Replaces_string_Status_to_enum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Code");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Code",
                nullable: true);
        }
    }
}
