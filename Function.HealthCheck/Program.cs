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
                        .AddUrlGroup(new Uri("http://httpbin.org/status/200"), "DependencyService-check")
                        .AddUrlGroup(new Uri("https://[...]/identity/.well-known/openid-configuration"), "IdentityService-check");
                })
                .Build();

            host.Run();
        }
    }
}