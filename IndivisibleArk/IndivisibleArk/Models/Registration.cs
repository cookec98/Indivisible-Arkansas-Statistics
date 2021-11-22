using System;
using Microsoft.EntityFrameworkCore;

namespace IndivisibleArk.Models
{
    public class Registration
    {
        public int RegistrationID { get; set; }

        //foreign
        public int LocationId { get; set; }
        public int ContactId { get; set; }
        public Location Location { get; set; }
        public Contact Contact { get; set; }

    }
}
