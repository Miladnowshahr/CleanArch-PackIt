using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PackIt.Application.Service;
using PackIt.Domain.Repositories;
using PackIt.Infrastructure.EF.Context;
using PackIt.Infrastructure.EF.Options;
using PackIt.Infrastructure.EF.Repositories;
using PackIt.Infrastructure.EF.Services;
using PackIt.Shared.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Infrastructure.EF
{
    internal static class Extensions
    {
        public static IServiceCollection AddPostgres(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddScoped<IPackingListRepository, PostgresPackingListRepository>();

            services.AddScoped<IPackingListReadService, PostgresPackingListReadService>();

            var postgres = configuration.GetOptions<PostgresOption>("Postgres");
            
            services.AddDbContext<ReadDbContext>(ctx => ctx.UseNpgsql(postgres.ConnectionString));

            services.AddDbContext<WriteDbContext>(ctx => ctx.UseNpgsql(postgres.ConnectionString));
             
            return services;
        }
    }
}
