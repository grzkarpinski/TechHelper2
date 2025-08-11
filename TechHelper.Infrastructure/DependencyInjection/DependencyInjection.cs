using Microsoft.Extensions.DependencyInjection;
using TechHelper.Infrastructure.Repositories.Interfaces;
using TechHelper.Infrastructure.Repositories.Implementations;

namespace TechHelper.Infrastructure.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureRepositories(this IServiceCollection services)
        {
            services.AddScoped<IMillingToolRepository, MillingToolRepository>();
            services.AddScoped<IDrillRepository, DrillRepository>();
            services.AddScoped<IMillingInsertRepository, MillingInsertRepository>();
            services.AddScoped<ICutterHeadRepository, CutterHeadRepository>();
            services.AddScoped<ICuttingParametersRangeRepository, CuttingParametersRangeRepository>();
            services.AddScoped<ICuttingParametersFinalRepository, CuttingParametersFinalRepository>();
            return services;
        }
    }
}
