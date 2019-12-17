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

        public Form1()
        {
            InitializeComponent();
            ScreenSaver screensaver = new ScreenSaver();
            screensaver.ShowDialog();

            var DataComboBox = storage.Load();

            var groupId = DataComboBox.Select(y => y.GroupID)
                .Distinct()
                .ToList();

            comboBoxForGroupId.DataSource = groupId;

            DataView.DataSource = storage.Load();
            

            //DataView.AutoResizeColumns();

            //for ( int i = 0; i < storage.Load().Count; i++)
            //{
            //    var param = DataView[1, i].Tag;
            //}

        }

        private void InitializeComponent()
        {
            this.ControlPanel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DataView = new System.Windows.Forms.DataGridView();
            this.comboBoxForGroupId = new System.Windows.Forms.ComboBox();
            this.ControlPanel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            this.SuspendLayout();
            // 
            // ControlPanel
            // 
            this.ControlPanel.Controls.Add(this.tabPage1);
            this.ControlPanel.Controls.Add(this.tabPage2);
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.SelectedIndex = 0;
            this.ControlPanel.Size = new System.Drawing.Size(736, 445);
            this.ControlPanel.TabIndex = 0;
            // 
            // tabPage1
            // 
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
            // DataView
            // 
            this.DataView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DataView.Location = new System.Drawing.Point(8, 8);
            this.DataView.Name = "DataView";
            this.DataView.Size = new System.Drawing.Size(550, 407);
            this.DataView.TabIndex = 0;
            // 
            // comboBoxForGroupId
            // 
            this.comboBoxForGroupId.FormattingEnabled = true;
            this.comboBoxForGroupId.Location = new System.Drawing.Point(575, 8);
            this.comboBoxForGroupId.Name = "comboBoxForGroupId";
            this.comboBoxForGroupId.Size = new System.Drawing.Size(121, 21);
            this.comboBoxForGroupId.TabIndex = 1;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(736, 449);
            this.Controls.Add(this.ControlPanel);
            this.Name = "Form1";
            this.Text = "ForTheExam";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ControlPanel.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
