using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PackIt.Infrastructure.EF.Migrations
{
    public partial class localizationtopLocalization : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "localization",
                schema: "packing",
                table: "PackingList",
                newName: "Localization");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Localization",
                schema: "packing",
                table: "PackingList",
                newName: "localization");
        }
    }
}
