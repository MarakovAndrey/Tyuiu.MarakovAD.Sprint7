using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.MarakovAD.Sprint7.Project.V13.Lib;
namespace Tyuiu.MarakovAD.Sprint7.Project.V13
{
    public partial class Form1 : Form
    {
        DataService ds = new DataService();
        public Form1()
        {
            InitializeComponent();
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

        private void SelectRow(int rowIndex)
        {
            if (rowIndex >= 0 && rowIndex < dataGridViewDataTable_MAD.Rows.Count)
            {
                dataGridViewDataTable_MAD.ClearSelection();
                dataGridViewDataTable_MAD.Rows[rowIndex].Selected = true;
            }
        }

        private void btnLoadCSVFile_MAD_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogInputCSVFile_MAD.Filter = "Значения, разделенные точкой с запятой(*.csv)|*.csv|Все файлы(*.*)|*.*";
                if (openFileDialogInputCSVFile_MAD.ShowDialog() == DialogResult.OK)
                {
                    ds.LoadFromCsv(openFileDialogInputCSVFile_MAD.FileName);
                    MessageBox.Show("Данные загружены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttonDeleteRow_MAD_Click(object sender, EventArgs e)
        {
            try
            {
                if (ds.Countries.Count == 0)
                {
                    MessageBox.Show("Таблица пуста", "Инфорация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int lastIndex = ds.Countries.Count - 1;
                var lastCountry = ds.Countries[lastIndex];
                ds.Countries.RemoveAt(lastIndex);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGetStatistics_MAD_Click(object sender, EventArgs e)
        {
            try
            {
                if (ds.Countries.Count != 0)
                {
                    string Statistics = ds.GetStatisticsArea() + ds.GetStatisticsPopulation() + ds.GetStatisticsDeveloped();
                    textBoxStatistics_MAD.Text = Statistics;
                }
                else
                {
                    textBoxStatistics_MAD.Text = "Данные не загружены!";
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdateChart_MAD_Click(object sender, EventArgs e)
        {
            try
            {
                chartAreaStatistics_MAD.Series.Clear();

                if (ds.Countries.Count == 0)
                {
                    chartAreaStatistics_MAD.Titles.Clear();
                    chartAreaStatistics_MAD.Titles.Add("Нет данных!");
                }

                Series dataSeries = new Series();
                dataSeries.ChartType = SeriesChartType.Pie;
                dataSeries.Name = "Площадь";

                foreach (Country country in ds.Countries)
                {
                    dataSeries.Points.AddXY(country.Name, country.Area);
                }

                chartAreaStatistics_MAD.Series.Add(dataSeries);
                chartAreaStatistics_MAD.Legends[0].Enabled = true;
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSortPopulationHighToLow_MAD_Click(object sender, EventArgs e)
        {
            try
            {
                ds.SortPopulationHighToLow();
                MessageBox.Show("Отсортировано по убыванию населения!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSortPopulationLowToHigh_MAD_Click(object sender, EventArgs e)
        {
            try
            {
                ds.SortPopulationLowToHigh();
                MessageBox.Show("Отсортировано по возрастанию населения!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void buttonSearch_MAD_Click(object sender, EventArgs e)
        {
            try
            {
                Form searchDialog = new Form
                {
                    Text = "Поиск страны",
                    Size = new Size(300, 150),
                    StartPosition = FormStartPosition.CenterParent,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    MaximizeBox = false,
                    MinimizeBox = false
                };

                TextBox txtSearch = new TextBox
                {
                    Location = new Point(20, 30),
                    Size = new Size(240, 30),
                    Font = new Font("Segoe UI", 9)
                };

                Button btnFind = new Button
                {
                    Text = "Найти",
                    Location = new Point(80, 70),
                    Size = new Size(80, 30),
                    DialogResult = DialogResult.OK
                };

                Button btnCancel = new Button
                {
                    Text = "Отмена",
                    Location = new Point(170, 70),
                    Size = new Size(80, 30),
                    DialogResult = DialogResult.Cancel
                };

                searchDialog.Controls.Add(txtSearch);
                searchDialog.Controls.Add(btnFind);
                searchDialog.Controls.Add(btnCancel);
                searchDialog.AcceptButton = btnFind;
                searchDialog.CancelButton = btnCancel;

                if (searchDialog.ShowDialog() == DialogResult.OK)
                {
                    string searchText = txtSearch.Text;

                    if (string.IsNullOrEmpty(searchText))
                    {
                        MessageBox.Show("Введите название страны для поиска", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int index = ds.FindCountryName(searchText);

                    if (index >= 0)
                    {
                        SelectRow(index);

                        MessageBox.Show($"Найдена страна: {ds.Countries[index].Name}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Страна '{searchText}' не найдена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBoxOnlyDeveloped_MAD_CheckedChanged(object sender, EventArgs e)
        {
            ds.DevelopedFilter(checkBoxOnlyDeveloped_MAD.Checked);
        }
    }
}
