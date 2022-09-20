using Microsoft.EntityFrameworkCore;
using PackIt.Domain.Entities;
using PackIt.Domain.ValueObjects;
using PackIt.Infrastructure.EF.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIt.Infrastructure.EF.Context
{
    public sealed class WriteDbContext:DbContext
    {
        public DbSet<PackingList> packingList { get; set; }


        public WriteDbContext(DbContextOptions<WriteDbContext> options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("packing");
            var configuration = new WriteConfiguration();
            modelBuilder.ApplyConfiguration<PackingList>(configuration);
            modelBuilder.ApplyConfiguration<PackingItem>(configuration);
        }

    }
}
