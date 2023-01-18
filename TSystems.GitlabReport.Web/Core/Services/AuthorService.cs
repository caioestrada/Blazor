using System.Net.Http.Json;
using TSystems.GitlabReport.Web.Core.Interfaces;
using TSystems.GitlabReport.Web.Core.Models.AuthorReport;

namespace TSystems.GitlabReport.Web.Core.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly HttpClient _httpClient;

        public AuthorService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Author>> GetAll()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Author>>("authors");
        }

        public async Task<IEnumerable<AuthorMilestoneReportItem>> Search(string group)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<AuthorMilestoneReportItem>>($"authors/search?group={group}");
        }
    }
}
