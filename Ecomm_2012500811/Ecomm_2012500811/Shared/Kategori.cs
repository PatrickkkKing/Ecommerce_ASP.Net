using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecomm_2012500811.Shared
{
	public class Kategori
	{
		[Key]
		public int IdKategori { get; set; }
		public string NamaKategori { get; set; } = string.Empty;
		public List<Produk> Produk { get; set; } = new List<Produk>();
	}
}
