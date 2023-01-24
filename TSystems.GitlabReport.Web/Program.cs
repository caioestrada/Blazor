using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Serilog;
using TSystems.GitlabReport.Web;
using TSystems.GitlabReport.Web.Core.Startup;

try
{
    var builder = WebAssemblyHostBuilder.CreateDefault(args);
    builder.RootComponents.Add<App>("#app");
    builder.RootComponents.Add<HeadOutlet>("head::after");

    builder.RegisterHttpServices();

    await builder.Build().RunAsync();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Aplicação foi finalizada inesperadamente!");
}
finally
{
    Log.Information("Desligando...");
    Log.CloseAndFlush();
}
