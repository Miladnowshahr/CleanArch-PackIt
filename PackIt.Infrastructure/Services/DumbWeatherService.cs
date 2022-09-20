using PackIt.Application.DTO.External;
using PackIt.Application.Service;
using PackIt.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Infrastructure.Services
{
    internal sealed class DumbWeatherService : IWeatherService
    {
        public Task<WeatherDto> GetWeatherAsync(Localization localization)
            =>
            Task.FromResult(new WeatherDto(new Random().Next(5, 30)));
    }
}
