using EF.GenericRepository.ISvcs;
using EF.GenericRepository.Svcs;
using Microsoft.Extensions.DependencyInjection;

namespace EF.GenericRepository
{
    public static class Startup
    {
        public static void GenericRepository(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        }
    }
}
