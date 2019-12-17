using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ForTheExam.Library
{
    public class Realization
    {
        public List<Information> GetInformation(string groupId)
        {
            List<Information> InfoSerialized = new List<Information>();
            Storage serialization = new Storage();
            InfoSerialized = serialization.Load();

            var result = InfoSerialized
                .Where(info => info.GroupID == groupId)
                .ToList() as List<Information>;

            return result;
        }

        public double GetAverageRatingForSubject(string lesson)
        {
            List<Information> InfoSerialezid = new List<Information>();
            Storage serialization = new Storage();
            InfoSerialezid = serialization.Load();

            var result = InfoSerialezid
                .Where(info => info.Lessons.Name == lesson)
                .SelectMany(l => l.Lessons.Mark)
                .Average();

            return result;
        }

        public double GetAverageRatingForGroup(string groupId)
        {
            List<Information> InfoSerialezid = new List<Information>();
            Storage serialization = new Storage();
            InfoSerialezid = serialization.Load();

            var result = InfoSerialezid
                .Where(info => info.GroupID == groupId)
                .SelectMany(l => l.Lessons.Mark)
                .Average();

            return result;
        }

        public List<Information> SortByAverageRatingForGroup()
        {
            Storage serialization = new Storage();
            List<Information> InfoSerialized = serialization.Load();

            var result = InfoSerialized.GroupBy(i => i.GroupID)
                .OrderBy(g => g.SelectMany(i => i.Lessons.Mark).Average())
                .SelectMany(g => g)
                .ToList();
            return result;
        }

        public IEnumerable<Information> TheRatioBetweenAverageMarkAndGroup(string lesson)
        {
            List<Information> InfoSerialized = new List<Information>();
            Storage serialization = new Storage();
            InfoSerialized = serialization.Load();

            var result = InfoSerialized
                .Where(info => info.Lessons.Name == lesson)
                .OrderBy(m => InfoSerialized
                .SelectMany(l => l.Lessons.Mark)
                .Average());       

            return result;
        }

        public IEnumerable<double> ShareOfAverageMarkForLesson(string lesson, string groupId)
        {
            List<Information> InfoSerialized = new List<Information>();
            Storage serialization = new Storage();
            InfoSerialized = serialization.Load();

            List<double> result = new List<double>();

            int cou = InfoSerialized
                .Where( i => i.GroupID == groupId)
                .Where(info => info.Lessons.Name == lesson)
                .SelectMany(l => l.Lessons.Mark)
                .Count();

            for (int mark = 1; mark <= 5; mark++)
            {
                var res = InfoSerialized
                    .Where(i => i.GroupID == groupId)
                    .Where(info => info.Lessons.Name == lesson)
                    .SelectMany(l => l.Lessons.Mark.Where(k => k == mark)).Count();

                result.Add((res*1.0 / cou)*100);
            }

            return result;
        }

        public IEnumerable<double> ShareOfdAverageMarkForSubject(string groupId)
        {
            List<Information> InfoSerialized = new List<Information>();
            Storage serialization = new Storage();
            InfoSerialized = serialization.Load();

            var result = InfoSerialized
                .Where(info => info.GroupID == groupId)
                .Select(y => y.Lessons.Mark.Average());

            return result;
        }

        public IEnumerable<int> ShareOfAmountOfStudents(string groupId)
        {
            List<Information> InfoSerialized = new List<Information>();
            Storage serialization = new Storage();
            InfoSerialized = serialization.Load();

            var result = InfoSerialized
                .Where(info => info.GroupID == groupId)
                .Select(m => m.AmountOfStudents);

            return result;
        }
    }
}
