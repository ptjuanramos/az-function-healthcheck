using Microsoft.Extensions.Diagnostics.HealthChecks;
using System;
using System.Collections.Generic;

namespace Function.HealthCheck
{
    public record HealthCheckFunctionResult(HealthStatus HealthStatus, TimeSpan Duration, IReadOnlyDictionary<string, HealthReportEntry> Entries)
    {
        public static explicit operator HealthCheckFunctionResult(HealthReport healthReport)
        {
            return new(healthReport.Status, healthReport.TotalDuration, healthReport.Entries);
        }
    }
}
