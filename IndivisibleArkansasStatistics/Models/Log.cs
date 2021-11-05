using System;
namespace IndivisibleArkansasStatistics.Models
{
    public class Log
    {
        public DateTime timestamp { get; set; }

        // foreign 
        public int cid { get; set; }
        public int sid { get; set; }
    }
}
