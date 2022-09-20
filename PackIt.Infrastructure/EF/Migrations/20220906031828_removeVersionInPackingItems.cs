using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PackIt.Infrastructure.EF.Migrations
{
    public partial class removeVersionInPackingItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Version",
                schema: "packing",
                table: "PackingItems");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Version",
                schema: "packing",
                table: "PackingItems",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
