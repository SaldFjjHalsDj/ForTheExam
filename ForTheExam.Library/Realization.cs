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
            Serialization serialization = new Serialization();
            InfoSerialized = serialization.Load();

            var result = InfoSerialized
                .Where(info => info.GroupID == groupId)
                .ToList() as List<Information>;

            return result;
        }

        public IEnumerable<double> GetAverageRatingForSubject(string lesson)
        {
            List<Information> InfoSerialezid = new List<Information>();
            Serialization serialization = new Serialization();
            InfoSerialezid = serialization.Load();

            var infoCredit = InfoSerialezid
                .Where(info => info.FormOfAccomodation == "очная")
                .Where(x => x.Credits.Lesson == lesson)
                .Average(y => y.Credits.Mark);

            List<double> result = new List<double>
            {
                infoCredit
            };

            infoCredit = InfoSerialezid
                .Where(info => info.FormOfAccomodation == "заочная")
                .Where(x => x.Credits.Lesson == lesson)
                .Average(y => y.Credits.Mark);

            result.Add(infoCredit);

            return result;
        }

        public IEnumerable<Information> SortByAverageRatingForGroup(string groupId)
        {
            List<Information> InfoSerialized = new List<Information>();
            Serialization serialization = new Serialization();
            InfoSerialized = serialization.Load();

            var result = InfoSerialized
                .Where(info => info.GroupID == groupId)
                .OrderBy(inform => InfoSerialized.Average(n => n.Credits.Mark));

            return result;
        }

        public IEnumerable<Information> TheRatioBetweenAverageMarkAndGroup(string lesson, string groupId)
        {
            List<Information> InfoSerialized = new List<Information>();
            Serialization serialization = new Serialization();
            InfoSerialized = serialization.Load();

            var result = InfoSerialized
                .Where(info => info.GroupID == groupId)
                .Where(y => y.Credits.Lesson == lesson)
                .Where(n => n.Credits.Mark == InfoSerialized.Average(x => x.Credits.Mark))
                .ToList() as List<Information>;

            return result;
        }

        //public IEnumerable<double> ShareOfAverageMarkForLesson(string lesson)
        //{
        //    List<Information> InfoSerialized = new List<Information>();
        //    Serialization serialization = new Serialization();
        //    InfoSerialized = serialization.Load();

        //    double[] vs = new double[4];

        //    for (int mark = 1; mark <=5; mark++)
        //    {
        //        var res = InfoSerialized
        //            .Where(info => info.Credits.Lesson == lesson)
        //            .Where(y => y.Credits.Mark == mark)
        //            .Count();

        //        vs[mark - 1] = res;
        //    }

        //    double average = 0;
        //}

    }
}
