using System;
using System.Collections.Generic;
using System.Text;

namespace ForTheExam.Library
{
    [Serializable]
    public class Information
    {
        public string Surname { get; set; }
        public string Initials { get; set;}
        public string GroupID { get; set; }
        public string FormOfAccomodation { get; set; }
        public CreditsForms Credits { get; set; }
    }
}
