using System;
using System.Collections.Generic;
using System.Linq;
using ForTheExam.Library;
using Newtonsoft.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ForTheExam.Tests
{
    [TestClass]
    public class RealizationTest
    {
        Realization realization = new Realization();

        [TestMethod]
        public void GetInformation_Test()
        {
            string groupId = "Ist18o-1";

            // Arrange

            var result = new List<Information>()
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
                },
            };

            // Action

            var group = realization.GetInformation(groupId);

            // Assert

            string expected = JsonConvert.SerializeObject(result);
            string actually = JsonConvert.SerializeObject(group);
            Assert.AreEqual(expected, actually);
        }

        [TestMethod]
        public void GetAverageRatingForSubject_Test()
        {
            string lesson = "Info";

            // Arrange

            var result = 4;

            // Action

            var rating = realization.GetAverageRatingForSubject(lesson);

            // Assert

            string expected = JsonConvert.SerializeObject(result);
            string actually = JsonConvert.SerializeObject(rating);
            Assert.AreEqual(result, rating);
        }

        [TestMethod]
        public void GetAverageRatingForGroup_Test()
        {
            string groupId = "In18o-1";

            // Action

            double result = 53*1.0 / 13*1.0;

            // Action

            var average = realization.GetAverageRatingForGroup(groupId);

            // Assert

            string expected = JsonConvert.SerializeObject(result);
            string actually = JsonConvert.SerializeObject(average);
            Assert.AreEqual(result, average);
        }

        [TestMethod]
        public void SortByAverageRatingForGroup_Test()
        {
            // Action

            var result = new List<Information>()
            {

                new Information
                {
                    GroupID = "In18o-1",
                    AmountOfStudents = 10,
                    Lessons = new Lesson
                    {
                        Name = "Math",
                        Mark = new List<int>
                        {
                            3, 4, 2, 2, 5
                        }
                    },
                },

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
                },

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
                },

                new Information
                {
                    GroupID = "In18o-1",
                    AmountOfStudents = 10,
                    Lessons = new Lesson
                    {
                        Name = "Info",
                        Mark = new List<int>
                        {
                            5, 5, 5, 5, 5, 5, 5, 2
                        }
                    },
                },
            };

            // Action

            var  sort = realization.SortByAverageRatingForGroup();

            // Assert

            string expected = JsonConvert.SerializeObject(result);
            string actually = JsonConvert.SerializeObject(sort);
            Assert.AreEqual(expected, actually);
        }
    }
}
