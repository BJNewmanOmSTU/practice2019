using Microsoft.EntityFrameworkCore.Migrations;

namespace Practice.Domain.Migrations
{
    public partial class Created_Models_Code_and_Attribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Code",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 32, nullable: false),
                    ProductTemplateId = table.Column<string>(nullable: true),
                    SellSource = table.Column<string>(nullable: true),
                    StoreId = table.Column<string>(nullable: true),
                    AttributeId = table.Column<string>(nullable: true),
                    Amount = table.Column<long>(nullable: false),
                    Symbol = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Code", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attribute",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 32, nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true),
                    Comment = table.Column<string>(nullable: true),
                    TypeId = table.Column<string>(nullable: true),
                    CodeId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attribute", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attribute_Code_CodeId",
                        column: x => x.CodeId,
                        principalTable: "Code",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attribute_CodeId",
                table: "Attribute",
                column: "CodeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attribute");

            migrationBuilder.DropTable(
                name: "Code");
        }
    }
}
