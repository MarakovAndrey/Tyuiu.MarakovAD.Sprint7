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
            SuspendLayout();
            // 
            // labelAbout_MAD
            // 
            labelAbout_MAD.Location = new Point(243, 19);
            labelAbout_MAD.Name = "labelAbout_MAD";
            labelAbout_MAD.Size = new Size(470, 276);
            labelAbout_MAD.TabIndex = 0;
            labelAbout_MAD.Text = resources.GetString("labelAbout_MAD.Text");
            // 
            // buttonOkToClose_MAD
            // 
            buttonOkToClose_MAD.Location = new Point(505, 207);
            buttonOkToClose_MAD.Name = "buttonOkToClose_MAD";
            buttonOkToClose_MAD.Size = new Size(75, 23);
            buttonOkToClose_MAD.TabIndex = 1;
            buttonOkToClose_MAD.Text = "OK";
            buttonOkToClose_MAD.UseVisualStyleBackColor = true;
            buttonOkToClose_MAD.Click += buttonOkToClose_MAD_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 242);
            Controls.Add(buttonOkToClose_MAD);
            Controls.Add(labelAbout_MAD);
            Name = "FormAbout";
            Text = "FormAbout";
            ResumeLayout(false);
        }

        #endregion

        private Label labelAbout_MAD;
        private Button buttonOkToClose_MAD;
    }
}