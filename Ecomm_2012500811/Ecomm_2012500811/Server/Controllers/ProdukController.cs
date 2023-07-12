using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecomm_2012500811.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdukController : ControllerBase
    {
		public static List<Produk> produk = new List<Produk>();
        private readonly DataContext _context;

        public ProdukController(DataContext context)
		{
            _context = context;
        }

		[HttpGet]
		public async Task<ActionResult<List<Produk>>> GetAllProduk()
		{
			var produks = await _context.Produk.ToListAsync();
			return Ok(produks);
		}

		[HttpGet("{id}")]
		public async Task<ActionResult<Produk>> GetProdukById(int id)
		{
			var prod = await _context.Produk.FirstOrDefaultAsync(p => p.IdProduk == id);
			if (prod == null)
			{
				return NotFound("Data Produk Tidak Ditemukan");
			}
			return Ok(prod);
		}
		
		private async Task<List<Produk>> GetDbProduk()
		{
			return await _context.Produk.ToListAsync();
		}

		[HttpPost]
		public async Task<ActionResult<List<Produk>>> CreateProduk(Produk produk)
		{
			_context.Produk.Add(produk);
			await _context.SaveChangesAsync();
			return Ok(await GetDbProduk());
		}

		[HttpPut("{id}")]
		public async Task<ActionResult<List<Produk>>> UpdateProduk(Produk produk, int id)
		{
			var dbProduk = await _context.Produk.FirstOrDefaultAsync(sh => sh.IdProduk == id);
			if (dbProduk == null)
				return NotFound("Data Tidak Ditemukan");
			dbProduk.IdProduk = id;
			dbProduk.NamaProduk = produk.NamaProduk;
			dbProduk.DeskripsiProduk = produk.DeskripsiProduk;
			dbProduk.HargaProduk = produk.HargaProduk;
			dbProduk.HargaOriginalProduk = produk.HargaOriginalProduk;
			dbProduk.DateCreated = produk.DateCreated;
			dbProduk.DateUpdated = produk.DateUpdated;
			dbProduk.IsDelete = produk.IsDelete;
			dbProduk.IsPublic = produk.IsPublic;
			dbProduk.GambarProduk = produk.GambarProduk;
			dbProduk.IdKategori = produk.IdKategori;
			await _context.SaveChangesAsync();
			return Ok(await GetDbProduk());

		}
		[HttpDelete("{id}")]
		public async Task<ActionResult<List<Produk>>> DeleteProduk(int id)
		{
			var dbProduk = await _context.Produk.FirstOrDefaultAsync(sh => sh.IdProduk == id);
			if (dbProduk == null)
				return NotFound("Data Tidak Ditemukan");
			_context.Produk.Remove(dbProduk);
			await _context.SaveChangesAsync();
			return Ok(await GetDbProduk());
		}
	}
}
