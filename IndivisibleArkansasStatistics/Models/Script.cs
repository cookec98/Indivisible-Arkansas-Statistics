using System;
using System.ComponentModel.DataAnnotations;

namespace IndivisibleArkansasStatistics.Models
{
    public enum Type
    {
        Email, Text, Phone
    }
    public class Script
    {
       
        [Required]
        public string Topic { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public Type? Type { get; set; }

        //primary
        public int ScriptId { get; set; }

        //foreign
        public int InterestId { get; set; }
        public Interest Interest { get; set; }
    }
}
