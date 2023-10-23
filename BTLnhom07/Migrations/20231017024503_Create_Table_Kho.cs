using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BTLnhom07.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_Kho : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Khoss",
                columns: table => new
                {
                    SanPhamName = table.Column<string>(type: "TEXT", nullable: false),
                    SoLuongTong = table.Column<string>(type: "TEXT", nullable: false),
                    SoluongXuat = table.Column<string>(type: "TEXT", nullable: false),
                    SoLuongTon = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khoss", x => x.SanPhamName);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Khoss");
        }
    }
}
