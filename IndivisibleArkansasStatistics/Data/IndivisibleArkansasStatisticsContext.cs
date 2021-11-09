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

        public DbSet<IndivisibleArkansasStatistics.Models.Contact> Contact { get; set; }
    }
}
