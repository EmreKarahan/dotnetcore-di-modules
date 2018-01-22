using Microsoft.Extensions.DependencyInjection;

namespace Example.Core
{
    public static class ExampleCoreModule
    {
        public static IServiceCollection AddCoreModule(this IServiceCollection services)
        {
            services.AddTransient<ISafeExecutor, SafeExecutor>();                                 
            return services;
        }
    }
}