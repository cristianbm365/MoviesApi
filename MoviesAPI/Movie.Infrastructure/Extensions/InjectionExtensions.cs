using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Movie.Infrastructure.Persistences.Context;

namespace Movie.Infrastructure.Extensions
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjectionInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var assembly = typeof(MovieDatabaseContext).Assembly.FullName;

            services.AddDbContext<MovieDatabaseContext>(
                options => options.UseSqlServer(
                    configuration.GetConnectionString("MovieConection"), b => b.MigrationsAssembly(assembly)), ServiceLifetime.Transient);

            return services;
        }
    }
}
