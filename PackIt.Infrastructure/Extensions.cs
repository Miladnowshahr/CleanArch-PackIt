using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PackIt.Application.Service;
using PackIt.Infrastructure.EF;
using PackIt.Infrastructure.EF.Options;
using PackIt.Infrastructure.Logging;
using PackIt.Infrastructure.Services;
using PackIt.Shared.Abstractions.Commands;
using PackIt.Shared.Options;
using PackIt.Shared.Queries;

namespace PackIt.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IWeatherService,DumbWeatherService>();
            services.AddPostgres(configuration);
            services.AddQueries();

            services.TryDecorate(typeof(ICommandHandler<>), typeof(LoggingCommandHandlerDecorator<>));

            return services;
        }
    }
}