using Ecomm_2012500811.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using System.Reflection.Metadata;

namespace Ecomm_2012500811.Client.Services.ProdukService
{
	public class ProdukService : IProdukService
	{
		private readonly HttpClient _http;
        private readonly NavigationManager _navigationManager;

        public ProdukService(HttpClient http, NavigationManager navigationManager)
        {
			_http = http;
            _navigationManager = navigationManager;
        }

        public List<Produk> Produks { get; set; } = new List<Produk>();

        public async Task CreateProduk(Produk produk)
        {
            var result = await _http.PostAsJsonAsync("api/produk", produk);
            var response = await result.Content.ReadFromJsonAsync<List<Produk>>();
            Produks = response;
            _navigationManager.NavigateTo("/manajemendata");
        }

        public async Task DeleteProduk(int id)
        {
            var result = await _http.DeleteAsync($"api/produk/{id}");
            var response = await result.Content.ReadFromJsonAsync<List<Produk>>();
            Produks = response;
            _navigationManager.NavigateTo("/manajemendata");
        }

        public async Task GetAllProduk()
		{
			var result = await _http.GetFromJsonAsync<List<Produk>>("api/Produk");
			if (result != null)
			{
				Produks = result;
			}
		}

		public async Task<Produk> GetProdukById(int id)
		{
			var result = await _http.GetFromJsonAsync<Produk>($"api/Produk/{id}");
			if (result != null)
				return result;
			throw new Exception("Data Produk Tidak Ditemukan");
		}

        public async Task UpdateProduk(Produk produk)
        {
            var result = await _http.PutAsJsonAsync($"api/produk/{produk.IdProduk}", produk);
            var response = await result.Content.ReadFromJsonAsync<List<Produk>>();
            Produks = response;
            _navigationManager.NavigateTo("/manajemendata");
        }
    }
}
