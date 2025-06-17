using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaginasWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class addTableSitios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sitios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sitios", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sitios");
        }
    }
}
