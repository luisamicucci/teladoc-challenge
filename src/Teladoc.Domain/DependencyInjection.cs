using Microsoft.Extensions.DependencyInjection;

namespace Teladoc.Domain
{
    public static class DependencyInjection
    {
        public static void AddDomain(this IServiceCollection services)
        {
            services.AddDbContext<TeladocApiContext>();
        }
    }
}
