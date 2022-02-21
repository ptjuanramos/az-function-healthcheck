using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

namespace Function.HealthCheck
{
    public class Program
    {
        public static void Main()
        {
            var host = new HostBuilder()
                .ConfigureFunctionsWorkerDefaults()
                .ConfigureServices(collection =>
                {
                    collection.AddHealthChecks()
                        .AddIdentityServer(new Uri("https://[url]/identity/"), "IdentityService-check")
                        .AddUrlGroup(new Uri("http://httpbin.org/status/200"), "DependencyService-check")
                        .AddUrlGroup(new Uri("https://[service-url]/api/v1/health"), "SignalRService-check");
                })
                .Build();

            host.Run();
        }
    }
}