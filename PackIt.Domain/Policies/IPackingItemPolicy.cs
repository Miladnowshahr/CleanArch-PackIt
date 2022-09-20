using PackIt.Domain.Const;
using PackIt.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Domain.Policies
{
    public record PolicyData(TravelDays Days,Const.Gender Gender, ValueObjects.Temperature Temperature,Localization Localization);
}
