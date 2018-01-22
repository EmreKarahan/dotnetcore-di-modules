using Example.Data.Repository;
using Example.Data.Repository.Impl;
using Microsoft.Extensions.DependencyInjection;

namespace Example.Data
{
    public static class ExampleDataModule
    {
        public static IServiceCollection AddDataModule(this IServiceCollection services)
        {
            services.AddScoped<IDataRepository, DataRepository>();                                 
            return services;
        }
    }
}