using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using ForTheExam.Library;

namespace ForTheExam
{
    public partial class Form1 : Form
    {
        CultureInfo CultureInfo = new CultureInfo("ru-RU");
        Storage storage = new Storage();
        Realization Realization = new Realization();
        List<Information> Information = new List<Information>();

        public Form1()
        {
            InitializeComponent();
            ScreenSaver screensaver = new ScreenSaver();
            screensaver.ShowDialog();

            var saved = storage.Load();

            var groupId = saved.Select(y => y.GroupID)
                .Distinct()
                .ToList();

            comboBoxForGroupId.DataSource = groupId;

            DataView.DataSource = saved;

            DataAV.DataSource = saved
                .Select(info => info.Lessons)
                .ToList();
            

            DataView.AutoResizeColumns();

            //for ( int i = 0; i < storage.Load().Count; i++)
            //{
            //    var param = DataView[1, i].Tag;
            //}

        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PiePanel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxForGroupId = new System.Windows.Forms.ComboBox();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.groupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountOfStudentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.PieInfo = new LiveCharts.WinForms.PieChart();
            this.DataAV = new System.Windows.Forms.DataGridView();
            this.lessonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PiePanel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataAV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PiePanel
            // 
            this.PiePanel.Controls.Add(this.tabPage1);
            this.PiePanel.Controls.Add(this.tabPage2);
            this.PiePanel.Controls.Add(this.tabPage3);
            this.PiePanel.Location = new System.Drawing.Point(0, 0);
            this.PiePanel.Name = "PiePanel";
            this.PiePanel.SelectedIndex = 0;
            this.PiePanel.Size = new System.Drawing.Size(736, 445);
            this.PiePanel.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DataAV);
            this.tabPage1.Controls.Add(this.comboBoxForGroupId);
            this.tabPage1.Controls.Add(this.DataView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(728, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Данные";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBoxForGroupId
            // 
            this.comboBoxForGroupId.FormattingEnabled = true;
            this.comboBoxForGroupId.Location = new System.Drawing.Point(575, 8);
            this.comboBoxForGroupId.Name = "comboBoxForGroupId";
            this.comboBoxForGroupId.Size = new System.Drawing.Size(121, 21);
            this.comboBoxForGroupId.TabIndex = 1;
            // 
            // DataView
            // 
            this.DataView.AutoGenerateColumns = false;
            this.DataView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupIDDataGridViewTextBoxColumn,
            this.amountOfStudentsDataGridViewTextBoxColumn});
            this.DataView.DataSource = this.informationBindingSource;
            this.DataView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DataView.Location = new System.Drawing.Point(6, 6);
            this.DataView.Name = "DataView";
            this.DataView.Size = new System.Drawing.Size(249, 407);
            this.DataView.TabIndex = 0;
            this.DataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataView_CellContentClick);
            // 
            // groupIDDataGridViewTextBoxColumn
            // 
            this.groupIDDataGridViewTextBoxColumn.DataPropertyName = "GroupID";
            this.groupIDDataGridViewTextBoxColumn.HeaderText = "GroupID";
            this.groupIDDataGridViewTextBoxColumn.Name = "groupIDDataGridViewTextBoxColumn";
            // 
            // amountOfStudentsDataGridViewTextBoxColumn
            // 
            this.amountOfStudentsDataGridViewTextBoxColumn.DataPropertyName = "AmountOfStudents";
            this.amountOfStudentsDataGridViewTextBoxColumn.HeaderText = "AmountOfStudents";
            this.amountOfStudentsDataGridViewTextBoxColumn.Name = "amountOfStudentsDataGridViewTextBoxColumn";
            // 
            // informationBindingSource
            // 
            this.informationBindingSource.DataSource = typeof(ForTheExam.Library.Information);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(728, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "График";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.PieInfo);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(728, 419);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Круговая диаграмма";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // PieInfo
            // 
            this.PieInfo.Location = new System.Drawing.Point(6, 6);
            this.PieInfo.Name = "PieInfo";
            this.PieInfo.Size = new System.Drawing.Size(447, 409);
            this.PieInfo.TabIndex = 0;
            this.PieInfo.Text = "pieChart1";
            // 
            // DataAV
            // 
            this.DataAV.AutoGenerateColumns = false;
            this.DataAV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DataAV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataAV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.DataAV.DataSource = this.lessonBindingSource;
            this.DataAV.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DataAV.Location = new System.Drawing.Point(261, 6);
            this.DataAV.Name = "DataAV";
            this.DataAV.Size = new System.Drawing.Size(241, 407);
            this.DataAV.TabIndex = 2;
            // 
            // lessonBindingSource
            // 
            this.lessonBindingSource.DataSource = typeof(ForTheExam.Library.Lesson);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(736, 449);
            this.Controls.Add(this.PiePanel);
            this.Name = "Form1";
            this.Text = "ForTheExam";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PiePanel.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataAV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lessonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
