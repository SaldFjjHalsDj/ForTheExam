using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForTheExam
{
    public partial class ScreenSaver : Form
    {
        public ScreenSaver()
        {
            InitializeComponent();
            label1.Text = "Мурманский государственный технический университет"
                           + "\n Кафедра математики; информационных систем и программного обеспечения"
                           + "\n Курсовая работа №2 по дисциплине \"Технологии программирования\""
                           + "\n Разработка информационной подсистемы анализов результатов сессии"
                           + "\n Семенчук Алексей Дмитриевич, ИСТб18о-1."
                           + "\n\n\n Для продолжения нажмите на экран.";
        }   

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScreenSaver_Load(object sender, EventArgs e)
        {

        }
    }
}
