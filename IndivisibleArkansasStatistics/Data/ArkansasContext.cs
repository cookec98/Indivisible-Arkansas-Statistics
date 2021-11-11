using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IndivisibleArkansasStatistics.Models;

namespace IndivisibleArkansasStatistics.Data
{
    public class ArkansasContext : DbContext
    {
        public ArkansasContext (DbContextOptions<ArkansasContext> options)
            : base(options)
        {
        }


        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().ToTable("Contacts");
        }


        public DbSet<IndivisibleArkansasStatistics.Models.Contact> Contact { get; set; }
    }
}
