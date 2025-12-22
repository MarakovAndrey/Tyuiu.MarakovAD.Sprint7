namespace Tyuiu.MarakovAD.Sprint7.Project.V13
{
    partial class SearchForm
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
            labelNameCountry_MAD = new Label();
            textBoxSearchNameCountry_MAD = new TextBox();
            buttonSearchOK_MAD = new Button();
            buttonSearchCancel_MAD = new Button();
            SuspendLayout();
            // 
            // labelNameCountry_MAD
            // 
            labelNameCountry_MAD.AutoSize = true;
            labelNameCountry_MAD.Location = new Point(12, 29);
            labelNameCountry_MAD.Name = "labelNameCountry_MAD";
            labelNameCountry_MAD.Size = new Size(146, 15);
            labelNameCountry_MAD.TabIndex = 0;
            labelNameCountry_MAD.Text = "Введите название страны";
            // 
            // textBoxSearchNameCountry_MAD
            // 
            textBoxSearchNameCountry_MAD.Location = new Point(12, 47);
            textBoxSearchNameCountry_MAD.Name = "textBoxSearchNameCountry_MAD";
            textBoxSearchNameCountry_MAD.Size = new Size(329, 23);
            textBoxSearchNameCountry_MAD.TabIndex = 1;
            // 
            // buttonSearchOK_MAD
            // 
            buttonSearchOK_MAD.Location = new Point(266, 112);
            buttonSearchOK_MAD.Name = "buttonSearchOK_MAD";
            buttonSearchOK_MAD.Size = new Size(75, 23);
            buttonSearchOK_MAD.TabIndex = 2;
            buttonSearchOK_MAD.Text = "OK";
            buttonSearchOK_MAD.UseVisualStyleBackColor = true;
            buttonSearchOK_MAD.Click += buttonSearchOK_MAD_Click;
            // 
            // buttonSearchCancel_MAD
            // 
            buttonSearchCancel_MAD.Location = new Point(185, 112);
            buttonSearchCancel_MAD.Name = "buttonSearchCancel_MAD";
            buttonSearchCancel_MAD.Size = new Size(75, 23);
            buttonSearchCancel_MAD.TabIndex = 2;
            buttonSearchCancel_MAD.Text = "Отмена";
            buttonSearchCancel_MAD.UseVisualStyleBackColor = true;
            buttonSearchCancel_MAD.Click += buttonSearchCancel_MAD_Click;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 147);
            Controls.Add(buttonSearchCancel_MAD);
            Controls.Add(buttonSearchOK_MAD);
            Controls.Add(textBoxSearchNameCountry_MAD);
            Controls.Add(labelNameCountry_MAD);
            MaximumSize = new Size(369, 186);
            MinimumSize = new Size(369, 186);
            Name = "SearchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Поиск";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNameCountry_MAD;
        private Button buttonSearchCancel_MAD;
        public TextBox textBoxSearchNameCountry_MAD;
        public Button buttonSearchOK_MAD;
    }
}