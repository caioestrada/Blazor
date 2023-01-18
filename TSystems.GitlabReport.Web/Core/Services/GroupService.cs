using System.Net.Http.Json;
using TSystems.GitlabReport.Web.Core.Interfaces;

namespace TSystems.GitlabReport.Web.Core.Services
{
    public class GroupService : IGroupService
    {
        private readonly HttpClient _httpClient;

        public GroupService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Dictionary<string, string>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<Dictionary<string, string>>("groups");
        }
    }
}
