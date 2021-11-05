using System;
namespace IndivisibleArkansasStatistics.Models
{
    public class Scripts
    {
        public string text { get; set; }
        public string type { get; set; }

        //primary
        public int sid { get; set; }

        //foreign
        public int intid { get; set; }
    }
}
