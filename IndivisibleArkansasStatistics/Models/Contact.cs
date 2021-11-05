using System;
using System.Collections.Generic;

namespace IndivisibleArkansasStatistics.Models
{
    public class Contact
    {
        //mando
        public string f_name { get; set; }

        public string m_name { get; set; }

        //mando
        public string l_name { get; set; }

        public string email { get; set; }

        //at least 1 address is mando
        public string m_address { get; set; }

        public DateTime DOB { get; set; }

        public string p_aff { get; set; }

        public string precinct { get; set; }

        public int phone { get; set; }

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