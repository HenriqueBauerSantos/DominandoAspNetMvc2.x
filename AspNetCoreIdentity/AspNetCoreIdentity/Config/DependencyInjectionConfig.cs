using AspNetCoreIdentity.Extensions;
using Microsoft.AspNetCore.Authorization;
using KissLog;

namespace AspNetCoreIdentity.Config
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddSingleton<IAuthorizationHandler, PermissaoNecessariaHandler>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(context => Logger.Factory.Get());

            services.AddScoped<AuditoriaFilter>();

            return services;
        }
    }
}
