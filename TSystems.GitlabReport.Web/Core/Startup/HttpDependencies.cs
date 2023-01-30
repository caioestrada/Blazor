using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TSystems.GitlabReport.Web.Core.Interfaces;
using TSystems.GitlabReport.Web.Core.Services;
using TSystems.GitlabReport.Web.Core.Startup.Interceptor;

namespace TSystems.GitlabReport.Web.Core.Startup
{
    public static class HttpDependencies
    {
        public static void RegisterHttpServices(this WebAssemblyHostBuilder builder)
        {
            var apiGitlab = builder.Configuration.GetSection("GitlabUrl").Value;
            
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddTransient<AuthorizationInterceptor>();
            builder.Services
                .AddHttpClient("HttpMessageHandlers", client => { client.BaseAddress = new Uri(apiGitlab); })
                .AddHttpMessageHandler<AuthorizationInterceptor>();

            builder.Services.AddHttpClient<IAuthorService, AuthorService>("HttpMessageHandlers");
            builder.Services.AddHttpClient<IGroupService, GroupService>("HttpMessageHandlers");
            builder.Services.AddHttpClient<IPipelineService, PipelineService>("HttpMessageHandlers");
            builder.Services.AddHttpClient<IMilestoneService, MilestoneService>("HttpMessageHandlers");
        }
    }
}
