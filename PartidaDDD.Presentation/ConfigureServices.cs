using Microsoft.Extensions.DependencyInjection;
using PartidaDDD.Domain.Commands.Handlers;
using PartidaDDD.Domain.Repositories;
using PartidaDDD.Infra.Context;
using PartidaDDD.Infra.Repositories;
using PartidaDDD.Presentation.Configuration;
using PartidaDDD.Presentation.Forms;

namespace PartidaDDD.Presentation
{
    public abstract class ConfigureServices
    {
        public static ServiceCollection Configure(ServiceCollection services)
        {
            services.AddTransient<ICarRepository, CarRepository>();
            services.AddTransient<CarHandler>();
            services.AddTransient<FormRegisterCar>();

            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<UserHandler>();
            services.AddTransient<FormRegisterUser>();

            services.AddTransient<FormMainPage>();

            services.AddTransient<IDBConfiguration, MSSqlConfiguration>();
            services.AddSingleton<IDB, MSSqlDB>();

            return services;
        }
    }
}
