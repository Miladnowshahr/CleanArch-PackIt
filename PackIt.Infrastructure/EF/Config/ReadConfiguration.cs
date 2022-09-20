using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PackIt.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Infrastructure.EF.Config
{
    internal sealed class ReadConfiguration : IEntityTypeConfiguration<PackingListReadModel>, IEntityTypeConfiguration<PackingItemReadModel>
    {
        public void Configure(EntityTypeBuilder<PackingItemReadModel> builder)
        {
            builder.ToTable("PackingItems");

            
        }

        public void Configure(EntityTypeBuilder<PackingListReadModel> builder)
        {
            builder.ToTable("PackingList");
            builder.HasKey(h => h.Id);

            builder.Property(p => p.Localization)
                .HasConversion(l => l.ToString(), l => LocalizationReadModel.Create(l));

            builder
                .HasMany(pl => pl.Items)
                .WithOne(pi => pi.PackingList);
        }
    }
}
