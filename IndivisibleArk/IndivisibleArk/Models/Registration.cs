using System;
using Microsoft.EntityFrameworkCore;

namespace IndivisibleArk.Models
{
    [Keyless]
    public class Registration
    {
        //foreign
        public int LocationId { get; set; }
        public int ContactId { get; set; }
        public Location Location { get; set; }
        public Contact Contact { get; set; }

    }
}
