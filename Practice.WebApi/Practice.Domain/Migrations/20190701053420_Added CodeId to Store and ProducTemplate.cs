using Microsoft.EntityFrameworkCore.Migrations;

namespace Practice.Domain.Migrations
{
    public partial class AddedCodeIdtoStoreandProducTemplate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Store",
                table: "Store");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTemplate",
                table: "ProductTemplate");

            migrationBuilder.RenameTable(
                name: "Store",
                newName: "Stores");

            migrationBuilder.RenameTable(
                name: "ProductTemplate",
                newName: "ProductTemplates");

            migrationBuilder.AlterColumn<string>(
                name: "StoreId",
                table: "Codes",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductTemplateId",
                table: "Codes",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Stores",
                table: "Stores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTemplates",
                table: "ProductTemplates",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Codes_ProductTemplateId",
                table: "Codes",
                column: "ProductTemplateId",
                unique: true,
                filter: "[ProductTemplateId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Codes_StoreId",
                table: "Codes",
                column: "StoreId",
                unique: true,
                filter: "[StoreId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Codes_ProductTemplates_ProductTemplateId",
                table: "Codes",
                column: "ProductTemplateId",
                principalTable: "ProductTemplates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Codes_Stores_StoreId",
                table: "Codes",
                column: "StoreId",
                principalTable: "Stores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Codes_ProductTemplates_ProductTemplateId",
                table: "Codes");

            migrationBuilder.DropForeignKey(
                name: "FK_Codes_Stores_StoreId",
                table: "Codes");

            migrationBuilder.DropIndex(
                name: "IX_Codes_ProductTemplateId",
                table: "Codes");

            migrationBuilder.DropIndex(
                name: "IX_Codes_StoreId",
                table: "Codes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Stores",
                table: "Stores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductTemplates",
                table: "ProductTemplates");

            migrationBuilder.RenameTable(
                name: "Stores",
                newName: "Store");

            migrationBuilder.RenameTable(
                name: "ProductTemplates",
                newName: "ProductTemplate");

            migrationBuilder.AlterColumn<string>(
                name: "StoreId",
                table: "Codes",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductTemplateId",
                table: "Codes",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Store",
                table: "Store",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductTemplate",
                table: "ProductTemplate",
                column: "Id");
        }
    }
}
