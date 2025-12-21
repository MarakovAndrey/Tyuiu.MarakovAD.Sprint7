namespace Tyuiu.MarakovAD.Sprint7.Project.V13
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridViewDataTable_MAD = new DataGridView();
            btnLoadCSVFile_MAD = new Button();
            buttonSaveFile_MAD = new Button();
            btnAbout_MAD = new Button();
            openFileDialogInputCSVFile_MAD = new OpenFileDialog();
            panel1 = new Panel();
            buttonGetStatistics_MAD = new Button();
            buttonDeleteRow_MAD = new Button();
            buttonAddRow_MAD = new Button();
            panel2 = new Panel();
            groupBoxDataTable_MAD = new GroupBox();
            splitter2 = new Splitter();
            panel3 = new Panel();
            groupBoxStatisics_MAD = new GroupBox();
            splitter1 = new Splitter();
            panel4 = new Panel();
            groupBoxGraph_MAD = new GroupBox();
            saveFileDialogOutputCSVFile_MAD = new SaveFileDialog();
            toolTip1 = new ToolTip(components);
            textBoxStatistics_MAD = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataTable_MAD).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxDataTable_MAD.SuspendLayout();
            panel3.SuspendLayout();
            groupBoxStatisics_MAD.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewDataTable_MAD
            // 
            dataGridViewDataTable_MAD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDataTable_MAD.Dock = DockStyle.Fill;
            dataGridViewDataTable_MAD.Location = new Point(7, 23);
            dataGridViewDataTable_MAD.Name = "dataGridViewDataTable_MAD";
            dataGridViewDataTable_MAD.Size = new Size(787, 342);
            dataGridViewDataTable_MAD.TabIndex = 0;
            // 
            // btnLoadCSVFile_MAD
            // 
            btnLoadCSVFile_MAD.Image = (Image)resources.GetObject("btnLoadCSVFile_MAD.Image");
            btnLoadCSVFile_MAD.Location = new Point(7, 12);
            btnLoadCSVFile_MAD.Name = "btnLoadCSVFile_MAD";
            btnLoadCSVFile_MAD.Size = new Size(52, 50);
            btnLoadCSVFile_MAD.TabIndex = 1;
            toolTip1.SetToolTip(btnLoadCSVFile_MAD, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            btnLoadCSVFile_MAD.UseVisualStyleBackColor = true;
            btnLoadCSVFile_MAD.Click += btnLoadCSVFile_MAD_Click;
            // 
            // buttonSaveFile_MAD
            // 
            buttonSaveFile_MAD.Image = (Image)resources.GetObject("buttonSaveFile_MAD.Image");
            buttonSaveFile_MAD.Location = new Point(65, 12);
            buttonSaveFile_MAD.Name = "buttonSaveFile_MAD";
            buttonSaveFile_MAD.Size = new Size(52, 50);
            buttonSaveFile_MAD.TabIndex = 1;
            toolTip1.SetToolTip(buttonSaveFile_MAD, "Сохранить файл\r\nВыберите место для сохранения файла\r\n");
            buttonSaveFile_MAD.UseVisualStyleBackColor = true;
            buttonSaveFile_MAD.Click += buttonSaveFile_MAD_Click;
            // 
            // btnAbout_MAD
            // 
            btnAbout_MAD.Image = (Image)resources.GetObject("btnAbout_MAD.Image");
            btnAbout_MAD.Location = new Point(742, 12);
            btnAbout_MAD.Name = "btnAbout_MAD";
            btnAbout_MAD.Size = new Size(52, 50);
            btnAbout_MAD.TabIndex = 1;
            toolTip1.SetToolTip(btnAbout_MAD, "Справка\r\nИнформация о создателе");
            btnAbout_MAD.UseVisualStyleBackColor = true;
            btnAbout_MAD.Click += btnAbout_MAD_Click;
            // 
            // openFileDialogInputCSVFile_MAD
            // 
            openFileDialogInputCSVFile_MAD.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(btnAbout_MAD);
            panel1.Controls.Add(btnLoadCSVFile_MAD);
            panel1.Controls.Add(buttonGetStatistics_MAD);
            panel1.Controls.Add(buttonDeleteRow_MAD);
            panel1.Controls.Add(buttonAddRow_MAD);
            panel1.Controls.Add(buttonSaveFile_MAD);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(801, 75);
            panel1.TabIndex = 2;
            // 
            // buttonGetStatistics_MAD
            // 
            buttonGetStatistics_MAD.Image = (Image)resources.GetObject("buttonGetStatistics_MAD.Image");
            buttonGetStatistics_MAD.Location = new Point(239, 12);
            buttonGetStatistics_MAD.Name = "buttonGetStatistics_MAD";
            buttonGetStatistics_MAD.Size = new Size(52, 50);
            buttonGetStatistics_MAD.TabIndex = 1;
            toolTip1.SetToolTip(buttonGetStatistics_MAD, "Обновить статистику\r\nОбновляет статистику до текущего состояния таблицы");
            buttonGetStatistics_MAD.UseVisualStyleBackColor = true;
            buttonGetStatistics_MAD.Click += buttonGetStatistics_MAD_Click;
            // 
            // buttonDeleteRow_MAD
            // 
            buttonDeleteRow_MAD.Image = (Image)resources.GetObject("buttonDeleteRow_MAD.Image");
            buttonDeleteRow_MAD.Location = new Point(181, 12);
            buttonDeleteRow_MAD.Name = "buttonDeleteRow_MAD";
            buttonDeleteRow_MAD.Size = new Size(52, 50);
            buttonDeleteRow_MAD.TabIndex = 1;
            toolTip1.SetToolTip(buttonDeleteRow_MAD, "Удалить строку\r\nУдаляет строку у текущей таблицы");
            buttonDeleteRow_MAD.UseVisualStyleBackColor = true;
            buttonDeleteRow_MAD.Click += buttonDeleteRow_MAD_Click;
            // 
            // buttonAddRow_MAD
            // 
            buttonAddRow_MAD.Image = (Image)resources.GetObject("buttonAddRow_MAD.Image");
            buttonAddRow_MAD.Location = new Point(123, 12);
            buttonAddRow_MAD.Name = "buttonAddRow_MAD";
            buttonAddRow_MAD.Size = new Size(52, 50);
            buttonAddRow_MAD.TabIndex = 1;
            toolTip1.SetToolTip(buttonAddRow_MAD, "Добавить строку\r\nДобавляет строку к текущей таблице");
            buttonAddRow_MAD.UseVisualStyleBackColor = true;
            buttonAddRow_MAD.Click += buttonAddRow_MAD_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(groupBoxDataTable_MAD);
            panel2.Controls.Add(splitter2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(801, 375);
            panel2.TabIndex = 3;
            // 
            // groupBoxDataTable_MAD
            // 
            groupBoxDataTable_MAD.BackColor = SystemColors.Control;
            groupBoxDataTable_MAD.Controls.Add(dataGridViewDataTable_MAD);
            groupBoxDataTable_MAD.Dock = DockStyle.Fill;
            groupBoxDataTable_MAD.Location = new Point(0, 0);
            groupBoxDataTable_MAD.Name = "groupBoxDataTable_MAD";
            groupBoxDataTable_MAD.Padding = new Padding(7);
            groupBoxDataTable_MAD.Size = new Size(801, 372);
            groupBoxDataTable_MAD.TabIndex = 7;
            groupBoxDataTable_MAD.TabStop = false;
            groupBoxDataTable_MAD.Text = "Таблица даных";
            // 
            // splitter2
            // 
            splitter2.Dock = DockStyle.Bottom;
            splitter2.Location = new Point(0, 372);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(801, 3);
            splitter2.TabIndex = 0;
            splitter2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Chocolate;
            panel3.Controls.Add(groupBoxStatisics_MAD);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 450);
            panel3.Name = "panel3";
            panel3.Size = new Size(395, 359);
            panel3.TabIndex = 4;
            // 
            // groupBoxStatisics_MAD
            // 
            groupBoxStatisics_MAD.BackColor = SystemColors.Control;
            groupBoxStatisics_MAD.Controls.Add(textBoxStatistics_MAD);
            groupBoxStatisics_MAD.Dock = DockStyle.Fill;
            groupBoxStatisics_MAD.Location = new Point(0, 0);
            groupBoxStatisics_MAD.Name = "groupBoxStatisics_MAD";
            groupBoxStatisics_MAD.Padding = new Padding(7);
            groupBoxStatisics_MAD.Size = new Size(395, 359);
            groupBoxStatisics_MAD.TabIndex = 0;
            groupBoxStatisics_MAD.TabStop = false;
            groupBoxStatisics_MAD.Text = "Статистика";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(395, 450);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 359);
            splitter1.TabIndex = 5;
            splitter1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(groupBoxGraph_MAD);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(398, 450);
            panel4.Name = "panel4";
            panel4.Size = new Size(403, 359);
            panel4.TabIndex = 6;
            // 
            // groupBoxGraph_MAD
            // 
            groupBoxGraph_MAD.BackColor = SystemColors.Control;
            groupBoxGraph_MAD.Dock = DockStyle.Fill;
            groupBoxGraph_MAD.Location = new Point(0, 0);
            groupBoxGraph_MAD.Name = "groupBoxGraph_MAD";
            groupBoxGraph_MAD.Size = new Size(403, 359);
            groupBoxGraph_MAD.TabIndex = 0;
            groupBoxGraph_MAD.TabStop = false;
            groupBoxGraph_MAD.Text = "График";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Подсказка";
            // 
            // textBoxStatistics_MAD
            // 
            textBoxStatistics_MAD.BackColor = SystemColors.Control;
            textBoxStatistics_MAD.Location = new Point(7, 17);
            textBoxStatistics_MAD.Multiline = true;
            textBoxStatistics_MAD.Name = "textBoxStatistics_MAD";
            textBoxStatistics_MAD.ReadOnly = true;
            textBoxStatistics_MAD.ScrollBars = ScrollBars.Vertical;
            textBoxStatistics_MAD.Size = new Size(378, 330);
            textBoxStatistics_MAD.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 809);
            Controls.Add(panel4);
            Controls.Add(splitter1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(817, 848);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "География";
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataTable_MAD).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBoxDataTable_MAD.ResumeLayout(false);
            panel3.ResumeLayout(false);
            groupBoxStatisics_MAD.ResumeLayout(false);
            groupBoxStatisics_MAD.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewDataTable_MAD;
        private Button btnLoadCSVFile_MAD;
        private Button buttonSaveFile_MAD;
        private Button btnAbout_MAD;
        private OpenFileDialog openFileDialogInputCSVFile_MAD;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Splitter splitter1;
        private Panel panel4;
        private GroupBox groupBoxDataTable_MAD;
        private GroupBox groupBoxStatisics_MAD;
        private GroupBox groupBoxGraph_MAD;
        private SaveFileDialog saveFileDialogOutputCSVFile_MAD;
        private Button buttonAddRow_MAD;
        private ToolTip toolTip1;
        private Splitter splitter2;
        private Button buttonDeleteRow_MAD;
        private Button buttonGetStatistics_MAD;
        private TextBox textBoxStatistics_MAD;
    }
}
