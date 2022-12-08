using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlakSirketi.DAL.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adminler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adminler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Albumler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumAdi = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AlbumSanatci = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AlbumCikisTarihi = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    AlbumFiyat = table.Column<decimal>(type: "decimal(18,2)", maxLength: 25, nullable: false),
                    AlbumIndirimOrani = table.Column<decimal>(type: "decimal(18,2)", maxLength: 25, nullable: true),
                    AlbumSatistaMi = table.Column<bool>(type: "bit", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albumler", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adminler_KullaniciAdi",
                table: "Adminler",
                column: "KullaniciAdi",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adminler");

            migrationBuilder.DropTable(
                name: "Albumler");
        }
    }
}
