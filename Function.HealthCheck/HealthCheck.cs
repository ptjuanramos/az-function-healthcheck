using System.Net;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Logging;

namespace Function.HealthCheck
{
    public class HealthCheck
    {
        private readonly HealthCheckService _healthCheckService;

        public HealthCheck(HealthCheckService healthCheckService)
        {
            _healthCheckService = healthCheckService;
        }

        [Function("HealthCheck")]
        public async Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestData req, FunctionContext executionContext)
        {
            ILogger logger = executionContext.GetLogger(nameof(HealthCheck));
            logger.LogInformation("C# HTTP trigger function processed a request.");

            HealthReport healthReport = await _healthCheckService.CheckHealthAsync();
            HealthCheckFunctionResult result = (HealthCheckFunctionResult)healthReport;
            
            var response = req.CreateResponse(HttpStatusCode.OK);

            await response.WriteAsJsonAsync(result);

            return response;
        }
    }
}
