using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Serilog;
using Serilog.Core;

namespace TSystems.GitlabReport.Web.Core.Startup
{
    public static class LogConfiguration
    {
        public static void RegisterLog(this WebAssemblyHostBuilder builder)
        {
            var levelSwitch = new LoggingLevelSwitch(Serilog.Events.LogEventLevel.Error);
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.ControlledBy(levelSwitch)
                .Enrich.WithProperty("InstanceId", Guid.NewGuid().ToString("n"))
                .WriteTo.BrowserConsole()
                .CreateLogger();

            builder.Services.AddLogging(loggingBuilder => loggingBuilder.AddSerilog(dispose: true));
        }
    }
}
