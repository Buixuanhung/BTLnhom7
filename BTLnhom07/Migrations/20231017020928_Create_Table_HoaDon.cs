using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BTLnhom07.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_HoaDon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    HoaDonCode = table.Column<string>(type: "TEXT", nullable: false),
                    HoaDonName = table.Column<string>(type: "TEXT", nullable: false),
                    SanPhamCode = table.Column<string>(type: "TEXT", nullable: false),
                    SoLuong = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.HoaDonCode);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDon");
        }
    }
}
