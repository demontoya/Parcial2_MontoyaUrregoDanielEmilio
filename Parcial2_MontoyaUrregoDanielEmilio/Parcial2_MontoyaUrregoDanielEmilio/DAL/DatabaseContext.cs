using Microsoft.EntityFrameworkCore;
using Parcial2_MontoyaUrregoDanielEmilio.DAL.Entities;
using System.Diagnostics.Metrics;

namespace Parcial2_MontoyaUrregoDanielEmilio.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Ticket>().HasKey(c => new {c.Id});
        }
    }
}
