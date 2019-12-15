using System;
using System.Collections.Generic;
using System.Text;

namespace ForTheExam.Library
{
    [Serializable]
    public class Information
    { 
        public string GroupID { get; set; }
        public int AmountOfStudents { get; set; }
        public Lesson Lessons { get; set; }
    }
}
