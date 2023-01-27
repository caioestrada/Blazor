using System.Net.Http.Json;
using TSystems.GitlabReport.Web.Core.Interfaces;
using TSystems.GitlabReport.Web.Core.Models.Pipeline;

namespace TSystems.GitlabReport.Web.Core.Services
{
    public class PipelineService : IPipelineService
    {
        private readonly HttpClient _httpClient;

        public PipelineService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<GroupReport>> GetAllByYear(int year)
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<GroupReport>>($"pipelines/{year}");
        }
    }
}
