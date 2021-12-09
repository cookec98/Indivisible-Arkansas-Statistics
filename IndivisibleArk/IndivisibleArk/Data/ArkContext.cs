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
        public DbSet<Log> Logs { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Script> Scripts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().ToTable("Contacts");
            modelBuilder.Entity<Interest>().ToTable("Interests");
            modelBuilder.Entity<Location>().ToTable("Locations");
            modelBuilder.Entity<Log>().ToTable("Log");
            modelBuilder.Entity<Registration>().ToTable("Registrations");
            modelBuilder.Entity<Script>().ToTable("Scripts");
        }

        public DbSet<IndivisibleArk.Models.Log> Log_1 { get; set; }

        public DbSet<IndivisibleArk.Models.Registration> Registration_1 { get; set; }

        public DbSet<IndivisibleArk.Models.Script> Script_1 { get; set; }
    }
}
