using System.Windows.Forms;
using Tyuiu.MarakovAD.Sprint7.Project.V13.Lib;
namespace Tyuiu.MarakovAD.Sprint7.Project.V13
{
    public partial class Form1 : Form
    {
        DataService ds = new DataService();
        public Form1()
        {
            InitializeComponent();
            openFileDialogInputCSVFile_MAD.Filter = "Значения, разделенные точкой с запятой(*.csv)|*.csv|Все файлы(*.*)|*.*";
            SetupDataGridView();
            dataGridViewDataTable_MAD.AutoGenerateColumns = true;
            dataGridViewDataTable_MAD.AllowUserToAddRows = false;
            dataGridViewDataTable_MAD.ReadOnly = false;
        }

        private void SetupDataGridView()
        {
            dataGridViewDataTable_MAD.DataSource = ds.Countries;
            dataGridViewDataTable_MAD.Columns["Name"].HeaderText = "Название страны";
            dataGridViewDataTable_MAD.Columns["Capital"].HeaderText = "Столица";
            dataGridViewDataTable_MAD.Columns["Area"].HeaderText = "Площадь (км²)";
            dataGridViewDataTable_MAD.Columns["Population"].HeaderText = "Население";
            dataGridViewDataTable_MAD.Columns["Population_density"].HeaderText = "Плотность населения";
            dataGridViewDataTable_MAD.Columns["MainNationality"].HeaderText = "Преобладающая национальность";
            dataGridViewDataTable_MAD.Columns["IsDeveloped"].HeaderText = "Развитая";
        }

        private void btnLoadCSVFile_MAD_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialogInputCSVFile_MAD.ShowDialog() == DialogResult.OK)
                {
                    ds.LoadFromCsv(openFileDialogInputCSVFile_MAD.FileName);
                    MessageBox.Show("Данные загружены!");
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbout_MAD_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonSaveFile_MAD_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogOutputCSVFile_MAD.Filter = "Значения, разделенные точкой с запятой(*.csv)|*.csv|Все файлы(*.*)|*.*";
                saveFileDialogOutputCSVFile_MAD.FileName = "*.csv";
                saveFileDialogOutputCSVFile_MAD.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialogOutputCSVFile_MAD.ShowDialog();
                ds.SaveToCsv(saveFileDialogOutputCSVFile_MAD.FileName);
                MessageBox.Show("Данные сохранены");
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddRow_MAD_Click(object sender, EventArgs e)
        {
            try
            {
                var newCountry = new Country
                {
                    Name = "Новая страна",
                    Capital = "",
                    Area = 0,
                    Population = 0,
                    Population_density = 0,
                    MainNationality = "",
                    IsDeveloped = false
                };
                ds.Countries.Add(newCountry);
                int newRowIndex = dataGridViewDataTable_MAD.Rows.Count - 1;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
