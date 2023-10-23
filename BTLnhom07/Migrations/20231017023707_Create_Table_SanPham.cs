using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BTLnhom07.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_SanPham : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    SanPhamCode = table.Column<string>(type: "TEXT", nullable: false),
                    SanPhamName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.SanPhamCode);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SanPham");
        }
    }
}
