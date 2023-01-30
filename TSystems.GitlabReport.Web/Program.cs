using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Serilog;
using TSystems.GitlabReport.Web;
using TSystems.GitlabReport.Web.Core.Startup;

internal class Program
{
    private static async Task Main(string[] args)
    {
        try
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.RegisterLog();
            builder.RegisterHttpServices();
            builder.Services.AddBlazoredLocalStorage(opt => opt.JsonSerializerOptions.WriteIndented = true);

            await builder.Build().RunAsync();
        }
        catch (Exception ex)
        {
            Log.Fatal(ex, "Erro inesperado ao inicializar a aplicação!");
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }
}