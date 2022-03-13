using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationAPI.Data.Migrations
{
    public partial class db1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Created_At = table.Column<DateTime>(nullable: false, defaultValue: DateTime.Now),
                    Update_At = table.Column<DateTime>(nullable: false, defaultValue: DateTime.Now),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Created_At = table.Column<DateTime>(nullable: false, defaultValue: DateTime.Now),
                    Updated_At = table.Column<DateTime>(nullable: false, defaultValue: DateTime.Now),
                    IsActive = table.Column<bool>(nullable: false, defaultValue: true),
                    Category_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_Category_Category_Id",
                        column: x => x.Category_Id,
                        principalTable: "Category",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_Category_Id",
                table: "Product",
                column: "Category_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
