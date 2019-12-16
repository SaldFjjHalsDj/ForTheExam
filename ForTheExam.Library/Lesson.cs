using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ForTheExam.Library
{
    public class Lesson
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public List<int> Mark { get; set; }
    }
}
