using System;
using Microsoft.EntityFrameworkCore;

namespace IndivisibleArkansasStatistics.Models
{
    [Keyless]
    public class Log
    {
        public DateTime Timestamp { get; set; }

        // foreign 
        public int ContactId { get; set; }
        public int ScriptId { get; set; }
        public Contact Contact { get; set; }
        public Scripts Script { get; set; }
    }
}
