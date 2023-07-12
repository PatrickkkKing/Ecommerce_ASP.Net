using Ecomm_2012500811.Shared;

namespace Ecomm_2012500811.Client.Services.ProdukService
{
    public interface IProdukService
    {
        List<Produk> Produks { get; set; }
        Task GetAllProduk();
        Task<Produk> GetProdukById(int id);
        Task CreateProduk(Produk produk);
        Task UpdateProduk(Produk produk);
        Task DeleteProduk(int id);
    }
}
