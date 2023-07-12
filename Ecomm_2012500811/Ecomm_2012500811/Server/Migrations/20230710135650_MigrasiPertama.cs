using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecomm_2012500811.Server.Migrations
{
    /// <inheritdoc />
    public partial class MigrasiPertama : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    IdKategori = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamaKategori = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.IdKategori);
                });

            migrationBuilder.CreateTable(
                name: "Varian",
                columns: table => new
                {
                    IdVarian = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamaVarian = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Varian", x => x.IdVarian);
                });

            migrationBuilder.CreateTable(
                name: "Produk",
                columns: table => new
                {
                    IdProduk = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamaProduk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeskripsiProduk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GambarProduk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HargaProduk = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    HargaOriginalProduk = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdKategori = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produk", x => x.IdProduk);
                    table.ForeignKey(
                        name: "FK_Produk_Kategori_IdKategori",
                        column: x => x.IdKategori,
                        principalTable: "Kategori",
                        principalColumn: "IdKategori",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kategori",
                columns: new[] { "IdKategori", "NamaKategori" },
                values: new object[,]
                {
                    { 1, "Sneakers" },
                    { 2, "Sport" }
                });

            migrationBuilder.InsertData(
                table: "Produk",
                columns: new[] { "IdProduk", "DateCreated", "DateUpdated", "DeskripsiProduk", "GambarProduk", "HargaOriginalProduk", "HargaProduk", "IdKategori", "IsDelete", "IsPublic", "NamaProduk" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 10, 20, 56, 50, 13, DateTimeKind.Local).AddTicks(2677), new DateTime(2023, 7, 10, 20, 56, 50, 13, DateTimeKind.Local).AddTicks(2697), "Sepatu Adidas Ukuran 38-43", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTISLcBhlpqPMC1iE-qIBVWED3REW0qfK2pA_dXB_3yG3vEQFXZ8afMmsvMG1zvHbbJp1g&usqp=CAU", 199.000m, 149.000m, 1, false, true, "Sepatu Adidas" },
                    { 2, new DateTime(2023, 7, 10, 20, 56, 50, 13, DateTimeKind.Local).AddTicks(2705), new DateTime(2023, 7, 10, 20, 56, 50, 13, DateTimeKind.Local).AddTicks(2706), "Sepatu Nike Ukuran 38-43", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQq6RTSQnR_qiByUu3iH8e20oGUecnUIQxC_G9fj-OLEaKzHawsmho2wbKzC98Q88JTFLE&usqp=CAU", 999.000m, 949.000m, 1, false, true, "Sepatu Nike" },
                    { 3, new DateTime(2023, 7, 10, 20, 56, 50, 13, DateTimeKind.Local).AddTicks(2709), new DateTime(2023, 7, 10, 20, 56, 50, 13, DateTimeKind.Local).AddTicks(2710), "Sepatu Ventella Ukuran 38-43", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTePc6kARywUKCvpom7b7zNqsvSdCKjGXCd1zANjS2HTXXSxqlzWMDEiqol0Oebz9ZrBFc&usqp=CAU", 399.000m, 349.000m, 1, false, true, "Sepatu Ventella" },
                    { 4, new DateTime(2023, 7, 10, 20, 56, 50, 13, DateTimeKind.Local).AddTicks(2714), new DateTime(2023, 7, 10, 20, 56, 50, 13, DateTimeKind.Local).AddTicks(2715), "Sepatu Jordan Ukuran 38-43", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRv7AoizoHCEmgByOHokrFFAIkPrb5SXUH3ElgQprRtsSzKMLi_O4Dx8DlmIrE-QiVtnPk&usqp=CAU", 499.000m, 449.000m, 2, false, true, "Sepatu Jordan" },
                    { 5, new DateTime(2023, 7, 10, 20, 56, 50, 13, DateTimeKind.Local).AddTicks(2717), new DateTime(2023, 7, 10, 20, 56, 50, 13, DateTimeKind.Local).AddTicks(2718), "Sepatu Vans Ukuran 38-43", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRYijF-XI6xk7kadZc3UxFfy37-JkdQbIjkGPLMAlPC3_33zUwX7_i3ZVEMXuN6Grw9G2o&usqp=CAU", 149.000m, 99.000m, 2, false, true, "Sepatu Vans" },
                    { 6, new DateTime(2023, 7, 10, 20, 56, 50, 13, DateTimeKind.Local).AddTicks(2721), new DateTime(2023, 7, 10, 20, 56, 50, 13, DateTimeKind.Local).AddTicks(2722), "Sepatu Mizuno High Ukuran 40-43", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcReTaGHZ7Wmq5JErl_uv0qOWggHbMgjRJEv8bvu0TjyXS4lJJKmZavjr5vdQT-eiYA-EBQ&usqp=CAU", 699.000m, 649.000m, 2, false, true, "Sepatu Mizuno" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produk_IdKategori",
                table: "Produk",
                column: "IdKategori");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produk");

            migrationBuilder.DropTable(
                name: "Varian");

            migrationBuilder.DropTable(
                name: "Kategori");
        }
    }
}
