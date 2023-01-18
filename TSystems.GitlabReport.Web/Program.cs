using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TSystems.GitlabReport.Web;
using TSystems.GitlabReport.Web.Core.Interfaces;
using TSystems.GitlabReport.Web.Core.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddHttpClient<IAuthorService, AuthorService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration.GetSection("GitlabUrl").Value);
    //client.DefaultRequestHeaders.Add("Authorization", $"Bearer {builder.Configuration.GetSection("Token").Value}");
});
builder.Services.AddHttpClient<IGroupService, GroupService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration.GetSection("GitlabUrl").Value);
    //client.DefaultRequestHeaders.Add("Authorization", $"Bearer {builder.Configuration.GetSection("Token").Value}");
});

await builder.Build().RunAsync();
