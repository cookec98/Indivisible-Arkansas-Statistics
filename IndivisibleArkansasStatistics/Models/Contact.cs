using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IndivisibleArkansasStatistics.Models
{
    public class Contact
    {
        //first name
        [Required]
        [Display(Name = "First Name")]
        public string F_name { get; set; }

        //middle name
        [Display(Name = "Middle Name")]
        public string M_name { get; set; }

        //last name
        [Required]
        [Display(Name = "Last Name")]
        public string L_name { get; set; }

        //email
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        //Not required, only needed if different
        //mailing address
        [Display(Name = "Mailing Address")]
        public string M_address { get; set; }

        //apartment or lot #
        [Display(Name = "Apartment Number")]
        public string Apt_lot_no { get; set; }

        [Required]
        //city/town
        public string City { get; set; }

        [Required]
        //county
        public string County { get; set; }

        //state
        public string State { get; set; }

        //date of birth
        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }

        //party affiliation
        [Display(Name = "Party Affiliation")]
        public string P_aff { get; set; }

        //voting precinct
        public string Precinct { get; set; }

        //phone number
        public int Phone { get; set; }

        //zip code
        [Display(Name = "Zip Code")]
        public int Zip { get; set; }


        //primary
        public int ContactId { get; set; }

        //foreign
        public int LocationId { get; set; }
        public int InterestId { get; set; }
        public Location Location { get; set; }
        public Interest Interest { get; set; }
    }
}