using System;
using System.Collections.Generic;

namespace IndivisibleArkansasStatistics.Models
{
    public class Contact
    {
        public string f_name { get; set; }
        public string m_name { get; set; }
        public string l_name { get; set; }
        public string email { get; set; }
        public string m_address { get; set; }
        public DateTime DOB { get; set; }
        public string p_aff { get; set; }
        public string precinct { get; set; }

        //primary
        public int cid { get; set; }

        //foreign
        public int lid { get; set; }
        public int intid { get; set; }

    }
}