using System.Net.Http.Json;
using TSystems.GitlabReport.Web.Core.Interfaces;
using TSystems.GitlabReport.Web.Core.Models.Groups;

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

        public async Task<List<Group>> GetAllWithId()
        {
            return await _httpClient.GetFromJsonAsync<List<Group>>("groups/WithId");
        }
    }
}
