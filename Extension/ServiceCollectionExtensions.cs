using tcirs_service.Repositories;
using tcirs_service.Services;

namespace tcirs_service.Extension
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IFileService, FileService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IListFService, ListFService>();
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IListFRepositories, ListFRepositories>();
            services.AddScoped<IFileRepositories, FileRepositories>();

            return services;
        }
    }
}
