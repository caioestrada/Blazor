using System.Net.Http.Json;
using TSystems.GitlabReport.Web.Core.Interfaces;
using TSystems.GitlabReport.Web.Core.Models.AuthorReport;
using TSystems.GitlabReport.Web.Core.Models.Milestone;

namespace TSystems.GitlabReport.Web.Core.Services
{
    public class MilestoneService : IMilestoneService
    {
        private readonly HttpClient _httpClient;

        public MilestoneService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Milestone>> Search(MilestoneFilter authorsFilter)
        {
            using var response = await _httpClient.PostAsJsonAsync("milestones/search", authorsFilter);
            return await response.Content.ReadFromJsonAsync<IEnumerable<Milestone>>();
        }
    }
}
