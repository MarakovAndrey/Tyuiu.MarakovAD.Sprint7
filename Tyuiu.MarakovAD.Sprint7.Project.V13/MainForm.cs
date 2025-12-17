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
            dataGridViewDataTable_MAD.DataSource = ds.Countries;
            dataGridViewDataTable_MAD.AutoGenerateColumns = true;
            dataGridViewDataTable_MAD.AllowUserToAddRows = false;
            dataGridViewDataTable_MAD.ReadOnly = false;
        }

        private void btnLoadCSVFile_MAD_Click(object sender, EventArgs e)
        {
            if (openFileDialogInputCSVFile_MAD.ShowDialog() == DialogResult.OK)
            {
                ds.LoadFromCsv(openFileDialogInputCSVFile_MAD.FileName);
                MessageBox.Show("Данные загружены!");
            }
        }

        private void btnAbout_MAD_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonSaveFile_MAD_Click(object sender, EventArgs e)
        {
            saveFileDialogOutputCSVFile_MAD.Filter = "Значения, разделенные точкой с запятой(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogOutputCSVFile_MAD.FileName = "*.csv";
            saveFileDialogOutputCSVFile_MAD.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogOutputCSVFile_MAD.ShowDialog();
        }
    }
}
