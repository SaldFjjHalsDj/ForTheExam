using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ForTheExam.Library
{
    [Serializable]
    public class Information
    { 
        [DataMember]
        public string GroupID { get; set; }
        
        [DataMember]
        public int AmountOfStudents { get; set; }

        [DataMember]
        public Lesson Lessons { get; set; }
    }
}
