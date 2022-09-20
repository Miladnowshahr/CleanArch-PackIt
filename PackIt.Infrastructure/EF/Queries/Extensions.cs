using PackIt.Application.DTO;
using PackIt.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Infrastructure.Queries
{
    internal  static class Extensions
    {
        public static PackingListDto AsDto(this PackingListReadModel readModel) => new()
        {
            Id = readModel.Id,
            Name = readModel.Name,
            localization = new LocalizationDto { City = readModel.Localization.City, Country = readModel.Localization.Country },
            Items = readModel.Items?.Select(s=>
                new PackingItemDto
                {
                    Name= s.Name,
                    Quantity=s.Quantity,
                    IsPacked=s.IsPacked
                })
            
        };
    }
}
