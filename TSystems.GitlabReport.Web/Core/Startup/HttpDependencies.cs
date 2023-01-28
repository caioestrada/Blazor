using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TSystems.GitlabReport.Web.Core.Interfaces;
using TSystems.GitlabReport.Web.Core.Services;

namespace TSystems.GitlabReport.Web.Core.Startup
{
    public static class HttpDependencies
    {
        public static void RegisterHttpServices(this WebAssemblyHostBuilder builder)
        {
            var apiGitlab = builder.Configuration.GetSection("GitlabUrl").Value;
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddHttpClient<IAuthorService, AuthorService>(client => { client.BaseAddress = new Uri(apiGitlab); });
            builder.Services.AddHttpClient<IGroupService, GroupService>(client => { client.BaseAddress = new Uri(apiGitlab); });
            builder.Services.AddHttpClient<IPipelineService, PipelineService>(client => { client.BaseAddress = new Uri(apiGitlab); });
            builder.Services.AddHttpClient<IMilestoneService, MilestoneService>(client => { client.BaseAddress = new Uri(apiGitlab); });
        }
    }
}
