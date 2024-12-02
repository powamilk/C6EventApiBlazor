

using DAL.Entities;

namespace PL.Guides.Service
{
    public class GiaoDichService : IGiaoDichService
    {
        private readonly HttpClient _httpClient;

        public GiaoDichService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://localhost:7078/api/");
        }
        public async Task AddAsync(GiaoDichTaiChinh vm)
        {
            var response = await _httpClient.PostAsJsonAsync("giaodich", vm);
            var erorr = await response.Content.ReadAsStringAsync();
            
        }

        public async Task DeleteAsync(Guid id)
        {
            await _httpClient.DeleteAsync($"giaodich/{id}");
        }

        public async Task<IEnumerable<GiaoDichTaiChinh>> GetAllAsync()
        {
            var response = await _httpClient.GetAsync("giaodich");
            var giaoDich = await response.Content.ReadFromJsonAsync<IEnumerable<GiaoDichTaiChinh>>();
            return giaoDich ?? new List<GiaoDichTaiChinh>();
        }

        public async Task<GiaoDichTaiChinh> GetByIdAsync(Guid id)
        {
            return await _httpClient.GetFromJsonAsync<GiaoDichTaiChinh>($"giaodich/{id}");
        }

        public async Task UpdateAsync(Guid id, GiaoDichTaiChinh vm)
        {
            await _httpClient.PutAsJsonAsync($"giaodich/{id}", vm);
        }
    }
}
