using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ForTheExam.Library;

namespace ForTheExam
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Storage storage = new Storage();
            List<Information> info = new List<Information>();

            var data = new List<Information>()
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
            };
            storage.Save(data);
        }
    }
}
