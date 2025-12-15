using Tyuiu.MarakovAD.Sprint7.Project.V13.Lib;
namespace Tyuiu.MarakovAD.Sprint7.Project.V13
{
    public partial class Form1 : Form
    {
        DataService ds = new DataService();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = ds.Countries;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog()) {
                dialog.Filter = "CSV files (*.csv)|*.csv";
                if (dialog.ShowDialog() == DialogResult.OK) { 
                    ds.LoadFromCsv(dialog.FileName);
                    MessageBox.Show("Данные загружены!");
                }
            }
        }
    }
}
