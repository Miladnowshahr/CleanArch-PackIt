using PackIt.Application.DTO.External;
using PackIt.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Application.Service
{
    public interface IWeatherService
    {
        Task<WeatherDto> GetWeatherAsync(Localization localization);
    }
}
