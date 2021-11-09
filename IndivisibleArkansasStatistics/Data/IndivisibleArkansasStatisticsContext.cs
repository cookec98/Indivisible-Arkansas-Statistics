using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IndivisibleArkansasStatistics.Models;

namespace IndivisibleArkansasStatistics.Data
{
    public class IndivisibleArkansasStatisticsContext : DbContext
    {
        public IndivisibleArkansasStatisticsContext (DbContextOptions<IndivisibleArkansasStatisticsContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Script> Scripts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().ToTable("Contact");
            modelBuilder.Entity<Interest>().ToTable("Interest");
            modelBuilder.Entity<Location>().ToTable("Location");
            modelBuilder.Entity<Log>().ToTable("Log");
            modelBuilder.Entity<Registration>().ToTable("Registration");
            modelBuilder.Entity<Script>().ToTable("Script");
        }

        public DbSet<IndivisibleArkansasStatistics.Models.Contact> Contact { get; set; }
    }
}
