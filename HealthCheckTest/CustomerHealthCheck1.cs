using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace HealthCheckTest
{
    public class CustomerHealthCheck1 : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context,
                                                        CancellationToken cancellationToken = new CancellationToken())
        {
            var result = MyDb.IsExists 
                ? HealthCheckResult.Healthy() 
                : HealthCheckResult.Unhealthy();
            return Task.FromResult(result);
        }
    }

    public class CustomerHealthCheck2 : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context,
                                                        CancellationToken cancellationToken = new CancellationToken())
        {
            var result = MyRedis.IsExists 
                ? HealthCheckResult.Healthy() 
                : HealthCheckResult.Unhealthy();
            return Task.FromResult(result);
        }
    }

    public class MyRedis
    {
        public static bool IsExists { get; set; }
    }

    public class MyDb
    {
        public static bool IsExists => false;
    }
}