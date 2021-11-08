using System;
using System.Collections.Generic;

namespace IndivisibleArkansasStatistics.Models
{
    public class Contact
    {
        //mando
        //first name
        public string f_name { get; set; }

        //middle name
        public string m_name { get; set; }

        //mando
        //last name
        public string l_name { get; set; }

        //email
        public string email { get; set; }

        //at least 1 address is mando
        //mailing address
        public string m_address { get; set; }

        //apartment or lot #
        public string apt_lot_no { get; set; }

        //mando
        //city/town
        public string city { get; set; }

        //mando
        //county
        public string county { get; set; }

        //state
        public string state { get; set; }

        //date of birth
        public DateTime DOB { get; set; }

        //part affiliation
        public string p_aff { get; set; }

        //voting precinct
        public string precinct { get; set; }

        //phone number
        public int phone { get; set; }

        //zip code
        public int zip { get; set; }



        //primary
        public int cid { get; set; }

        //foreign
        public int lid { get; set; }
        public int intid { get; set; }

        public Registration Registration { get; set; }
        public Log Log { get; set; }
        public Interest Interest { get; set; }
    }
}