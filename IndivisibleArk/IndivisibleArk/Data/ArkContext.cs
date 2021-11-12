using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IndivisibleArk.Models;

namespace IndivisibleArk.Data
{
    public class ArkContext : DbContext
    {
        public ArkContext (DbContextOptions<ArkContext> options)
            : base(options)
        {
        }

        public DbSet<IndivisibleArk.Models.Contact> Contact { get; set; }


        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Location> Log { get; set; }
        public DbSet<Location> Registration { get; set; }
        public DbSet<Location> Script { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().ToTable("Contacts");
            modelBuilder.Entity<Interest>().ToTable("Interests");
            modelBuilder.Entity<Location>().ToTable("Locations");
            modelBuilder.Entity<Log>().ToTable("Log");
            modelBuilder.Entity<Registration>().ToTable("Registrations");
            modelBuilder.Entity<Script>().ToTable("Scripts");
        }
    }
}
