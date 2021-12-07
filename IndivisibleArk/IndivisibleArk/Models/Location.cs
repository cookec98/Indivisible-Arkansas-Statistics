using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IndivisibleArk.Models
{
    public class Location
    {
        [Display(Name = "Location")]
        public string Loc { get; set; }

        //primary
        public int LocationId { get; set; }
    }
}
