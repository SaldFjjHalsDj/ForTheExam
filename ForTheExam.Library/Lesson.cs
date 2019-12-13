using System;
using System.Collections.Generic;
using System.Text;

namespace ForTheExam.Library
{
    public class Lesson
    {
        public string Name { get; set; }

        public AttestationType AttestationType { get; set; }

        public bool IsPassed { get; set; }
        public int Mark { get; set; }

    }
}
