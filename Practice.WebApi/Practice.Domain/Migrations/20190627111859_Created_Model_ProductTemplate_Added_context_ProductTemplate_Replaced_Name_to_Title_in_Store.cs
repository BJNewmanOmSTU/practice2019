using Microsoft.EntityFrameworkCore.Migrations;

namespace Practice.Domain.Migrations
{
    public partial class Created_Model_ProductTemplate_Added_context_ProductTemplate_Replaced_Name_to_Title_in_Store : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Store",
                newName: "Title");

            migrationBuilder.CreateTable(
                name: "ProductTemplate",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 32, nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTemplate", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductTemplate");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Store",
                newName: "Name");
        }
    }
}
