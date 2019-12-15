using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForTheExam.Library;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace ForTheExam.Tests
{
    [TestClass]
    public class StorageTest
    {
        Storage storage = new Storage();
        
        [TestMethod]
        public void Storage_Test()
        {
            var data = new List<Information>();
            {
                new Information
                {
                    GroupID = "Ist18o-1",
                    AmountOfStudents = 12,
                    Lessons =
                    new Lesson
                    {
                        Name = "Math",
                        Mark = new List<int>
                        {
                            1, 2, 5, 5, 5,
                        },
                    },
                };

                new Information
                {
                    GroupID = "Ivt18o-1",
                    AmountOfStudents = 19,
                    Lessons = new Lesson
                    {
                        Name = "Info",
                        Mark = new List<int>
                        {
                            4, 3, 2, 5, 5, 5, 2, 3, 2,
                        },
                    },
                };
            };
        }
    }
}
