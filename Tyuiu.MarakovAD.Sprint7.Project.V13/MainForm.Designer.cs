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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            btnLoad = new Button();
            button2 = new Button();
            btnAbout_MAD = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 304);
            dataGridView1.TabIndex = 0;
            // 
            // btnLoad
            // 
            btnLoad.Image = (Image)resources.GetObject("btnLoad.Image");
            btnLoad.Location = new Point(23, 32);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(52, 50);
            btnLoad.TabIndex = 1;
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(104, 32);
            button2.Name = "button2";
            button2.Size = new Size(52, 50);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // btnAbout_MAD
            // 
            btnAbout_MAD.Image = (Image)resources.GetObject("btnAbout_MAD.Image");
            btnAbout_MAD.Location = new Point(185, 32);
            btnAbout_MAD.Name = "btnAbout_MAD";
            btnAbout_MAD.Size = new Size(52, 50);
            btnAbout_MAD.TabIndex = 1;
            btnAbout_MAD.UseVisualStyleBackColor = true;
            btnAbout_MAD.Click += btnAbout_MAD_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAbout_MAD);
            Controls.Add(button2);
            Controls.Add(btnLoad);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "География";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnLoad;
        private Button button2;
        private Button btnAbout_MAD;
    }
}
