namespace Tyuiu.MarakovAD.Sprint7.Project.V13
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            labelAbout_MAD = new Label();
            buttonOkToClose_MAD = new Button();
            groupBoxAboutCreator_MAD = new GroupBox();
            pictureBoxCreator = new PictureBox();
            groupBoxInstructions_MAD = new GroupBox();
            label1 = new Label();
            groupBoxAboutCreator_MAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCreator).BeginInit();
            groupBoxInstructions_MAD.SuspendLayout();
            SuspendLayout();
            // 
            // labelAbout_MAD
            // 
            labelAbout_MAD.Location = new Point(267, 19);
            labelAbout_MAD.Name = "labelAbout_MAD";
            labelAbout_MAD.Size = new Size(306, 223);
            labelAbout_MAD.TabIndex = 0;
            labelAbout_MAD.Text = resources.GetString("labelAbout_MAD.Text");
            // 
            // buttonOkToClose_MAD
            // 
            buttonOkToClose_MAD.Location = new Point(510, 521);
            buttonOkToClose_MAD.Name = "buttonOkToClose_MAD";
            buttonOkToClose_MAD.Size = new Size(75, 23);
            buttonOkToClose_MAD.TabIndex = 1;
            buttonOkToClose_MAD.Text = "OK";
            buttonOkToClose_MAD.UseVisualStyleBackColor = true;
            buttonOkToClose_MAD.Click += buttonOkToClose_MAD_Click;
            // 
            // groupBoxAboutCreator_MAD
            // 
            groupBoxAboutCreator_MAD.Controls.Add(pictureBoxCreator);
            groupBoxAboutCreator_MAD.Controls.Add(labelAbout_MAD);
            groupBoxAboutCreator_MAD.Location = new Point(12, 250);
            groupBoxAboutCreator_MAD.Name = "groupBoxAboutCreator_MAD";
            groupBoxAboutCreator_MAD.Size = new Size(573, 257);
            groupBoxAboutCreator_MAD.TabIndex = 2;
            groupBoxAboutCreator_MAD.TabStop = false;
            groupBoxAboutCreator_MAD.Text = "Об авторе приложения";
            // 
            // pictureBoxCreator
            // 
            pictureBoxCreator.ErrorImage = (Image)resources.GetObject("pictureBoxCreator.ErrorImage");
            pictureBoxCreator.Image = (Image)resources.GetObject("pictureBoxCreator.Image");
            pictureBoxCreator.Location = new Point(6, 22);
            pictureBoxCreator.Name = "pictureBoxCreator";
            pictureBoxCreator.Size = new Size(243, 220);
            pictureBoxCreator.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCreator.TabIndex = 1;
            pictureBoxCreator.TabStop = false;
            // 
            // groupBoxInstructions_MAD
            // 
            groupBoxInstructions_MAD.Controls.Add(label1);
            groupBoxInstructions_MAD.Location = new Point(12, 12);
            groupBoxInstructions_MAD.Name = "groupBoxInstructions_MAD";
            groupBoxInstructions_MAD.Size = new Size(573, 232);
            groupBoxInstructions_MAD.TabIndex = 3;
            groupBoxInstructions_MAD.TabStop = false;
            groupBoxInstructions_MAD.Text = "Руководство пользователя";
            // 
            // label1
            // 
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(556, 209);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 556);
            Controls.Add(groupBoxInstructions_MAD);
            Controls.Add(groupBoxAboutCreator_MAD);
            Controls.Add(buttonOkToClose_MAD);
            MinimumSize = new Size(613, 541);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAbout";
            groupBoxAboutCreator_MAD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCreator).EndInit();
            groupBoxInstructions_MAD.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labelAbout_MAD;
        private Button buttonOkToClose_MAD;
        private GroupBox groupBoxAboutCreator_MAD;
        private PictureBox pictureBoxCreator;
        private GroupBox groupBoxInstructions_MAD;
        private Label label1;
    }
}