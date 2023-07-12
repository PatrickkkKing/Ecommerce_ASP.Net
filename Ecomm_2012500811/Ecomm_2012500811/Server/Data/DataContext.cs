namespace Ecomm_2012500811.Server.Data
{
	public class DataContext : DbContext
	{
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
          
        }

        public DbSet<Produk> Produk { get; set; }
        public DbSet<Varian> Varian { get; set; }
        public DbSet<Kategori> Kategori { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Produk>().HasData(

				new Produk
				{
					IdProduk = 1,
					IdKategori = 1,
					NamaProduk = "Sepatu Adidas",
					DeskripsiProduk = "Sepatu Adidas Ukuran 38-43",
					GambarProduk = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTISLcBhlpqPMC1iE-qIBVWED3REW0qfK2pA_dXB_3yG3vEQFXZ8afMmsvMG1zvHbbJp1g&usqp=CAU",
					HargaProduk = 149.000m,
					HargaOriginalProduk = 199.000m,
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					IsDelete = false,
					IsPublic = true
				},

				new Produk
				{
					IdProduk = 2,
					IdKategori = 1,
					NamaProduk = "Sepatu Nike",
					DeskripsiProduk = "Sepatu Nike Ukuran 38-43",
					GambarProduk = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQq6RTSQnR_qiByUu3iH8e20oGUecnUIQxC_G9fj-OLEaKzHawsmho2wbKzC98Q88JTFLE&usqp=CAU",
					HargaProduk = 949.000m,
					HargaOriginalProduk = 999.000m,
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					IsDelete = false,
					IsPublic = true
				},

				new Produk
				{
					IdProduk = 3,
					IdKategori = 1,
					NamaProduk = "Sepatu Ventella",
					DeskripsiProduk = "Sepatu Ventella Ukuran 38-43",
					GambarProduk = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTePc6kARywUKCvpom7b7zNqsvSdCKjGXCd1zANjS2HTXXSxqlzWMDEiqol0Oebz9ZrBFc&usqp=CAU",
					HargaProduk = 349.000m,
					HargaOriginalProduk = 399.000m,
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					IsDelete = false,
					IsPublic = true
				},

				new Produk
				{
					IdProduk = 4,
					IdKategori = 2,
					NamaProduk = "Sepatu Jordan",
					DeskripsiProduk = "Sepatu Jordan Ukuran 38-43",
					GambarProduk = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRv7AoizoHCEmgByOHokrFFAIkPrb5SXUH3ElgQprRtsSzKMLi_O4Dx8DlmIrE-QiVtnPk&usqp=CAU",
					HargaProduk = 449.000m,
					HargaOriginalProduk = 499.000m,
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					IsDelete = false,
					IsPublic = true
				},

				new Produk
				{
					IdProduk = 5,
					IdKategori = 2,
					NamaProduk = "Sepatu Vans",
					DeskripsiProduk = "Sepatu Vans Ukuran 38-43",
					GambarProduk = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRYijF-XI6xk7kadZc3UxFfy37-JkdQbIjkGPLMAlPC3_33zUwX7_i3ZVEMXuN6Grw9G2o&usqp=CAU",
					HargaProduk = 99.000m,
					HargaOriginalProduk = 149.000m,
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					IsDelete = false,
					IsPublic = true
				},

				new Produk
				{
					IdProduk = 6,
					IdKategori = 2,
					NamaProduk = "Sepatu Mizuno",
					DeskripsiProduk = "Sepatu Mizuno High Ukuran 40-43",
					GambarProduk = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcReTaGHZ7Wmq5JErl_uv0qOWggHbMgjRJEv8bvu0TjyXS4lJJKmZavjr5vdQT-eiYA-EBQ&usqp=CAU",
					HargaProduk = 649.000m,
					HargaOriginalProduk = 699.000m,
					DateCreated = DateTime.Now,
					DateUpdated = DateTime.Now,
					IsDelete = false,
					IsPublic = true
				}
			);

			modelBuilder.Entity<Kategori>().HasData(
				new Kategori { IdKategori=1, NamaKategori="Sneakers"},
				new Kategori { IdKategori=2, NamaKategori="Sport"}
			);
		}
	}
}
