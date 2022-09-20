using PackIt.Domain.ValueObjects;
using PackIt.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Application.Commands.Exception
{
    public class MissingLocalizationWeatherException : PackItException
    {
        public MissingLocalizationWeatherException(Localization localization) : base($"Couldn't fetch weather data for localization '{localization.country}/{localization.city}")
        {
            Localization = localization;
        }

        public Localization Localization { get; }
    }
}
