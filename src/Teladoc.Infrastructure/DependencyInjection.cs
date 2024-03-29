﻿using Microsoft.Extensions.DependencyInjection;
using Teladoc.Application.Interfaces;
using Teladoc.Infrastructure.Repositories;

namespace Teladoc.Infrastructure
{
    public static class DependencyInjection
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
