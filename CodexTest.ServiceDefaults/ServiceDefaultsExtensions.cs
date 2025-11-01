using Aspire.Hosting;
using Microsoft.Extensions.Hosting;

namespace CodexTest.ServiceDefaults;

public static class ServiceDefaultsExtensions
{
    public static IDistributedApplicationBuilder AddServiceDefaults(this IDistributedApplicationBuilder builder)
    {
        // Customize distributed application defaults here as needed.
        return builder;
    }

    public static IHostApplicationBuilder AddServiceDefaults(this IHostApplicationBuilder builder)
    {
        // Customize host-specific defaults here as needed.
        return builder;
    }
}
