using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackIt.Infrastructure.Models;
using PackIt.Infrastructure.EF.Config;

namespace PackIt.Infrastructure.EF.Context
{
    public sealed class ReadDbContext:DbContext
    {
        public DbSet<PackingListReadModel> PackingList { get; set; }

        public ReadDbContext(DbContextOptions<ReadDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("packing");

            var configuration = new ReadConfiguration();
            modelBuilder.ApplyConfiguration<PackingListReadModel>(configuration);
            modelBuilder.ApplyConfiguration<PackingItemReadModel>(configuration);


        }
    }
}
