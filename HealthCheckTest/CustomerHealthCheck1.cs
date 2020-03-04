using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace HealthCheckTest
{
    public class CustomerHealthCheck1 : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            var healthCheckResult = HealthCheckResult.Healthy();

            return Task.FromResult(healthCheckResult);
        }
    }
    public class CustomerHealthCheck2 : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            var healthCheckResult = HealthCheckResult.Healthy();

            return Task.FromResult(healthCheckResult);
        }
    }
}