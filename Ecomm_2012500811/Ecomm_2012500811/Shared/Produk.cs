using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecomm_2012500811.Shared
{
    public class Produk
    {
		[Key]
        public int IdProduk { get; set; }
		[Required(ErrorMessage="Nama Harus Diisi")]
        public string NamaProduk { get; set; } = string.Empty;
		[Required(ErrorMessage = "Deskripsi Harus Diisi")]
		public string DeskripsiProduk { get; set; } = string.Empty;
		[Required(ErrorMessage = "Url Harus Diisi")]
		public string GambarProduk { get; set; } = "https://via.placeholder.com/300x300";
		[Required(ErrorMessage = "Harga Harus Diisi")]
		[Column(TypeName = "decimal(8,2)")]
		public decimal HargaProduk { get; set; }
		[Required(ErrorMessage = "Harga Original Harus Diisi")]
		[Column(TypeName = "decimal(8,2)")]
		public decimal HargaOriginalProduk { get; set; }
		[Required(ErrorMessage = "Harus Dipilih")]
		public bool IsPublic { get; set; }
		[Required(ErrorMessage = "Harus Dipilih")]
		public bool IsDelete { get; set; }
		public DateTime DateCreated { get; set; } = DateTime.Now;
		public DateTime DateUpdated { get; set; } = DateTime.Now;
		[ForeignKey(nameof(IdKategori))]
		public Kategori? Kategori { get; set; }
		[Required(ErrorMessage = "Id Kategori Harus Diisi")]
		public int IdKategori { get; set; }
	}
}
