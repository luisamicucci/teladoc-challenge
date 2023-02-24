using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Teladoc.Application.Profiles;

namespace Teladoc.Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            services.AddAutoMapper(typeof(UserProfile));
        }
    }
}
