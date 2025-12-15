using System.ComponentModel;

namespace Tyuiu.MarakovAD.Sprint7.Project.V13.Lib
{
    public class Country {
        public string Name { get; set; }
        public string Capital { get; set; }
        public double Area { get; set; }
        public bool IsDeveloped { get; set; }
        public long Population { get; set; }
        public string MainNationality { get; set; }
        public string Notes { get; set; }
    }
    public class DataService
    {
        public BindingList<Country> Countries { get; private set; }
        public DataService() {
            Countries = new BindingList<Country>();
        }

        public void LoadFromCsv(string filePath) { 
            Countries.Clear();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines.Skip(1))
            {
                var values = line.Split(';');
                var country = new Country
                {
                    Name = values[0],
                    Capital = values[1],
                    Area = double.Parse(values[2]),
                    IsDeveloped = bool.Parse(values[3]),
                    Population = long.Parse(values[4]),
                    MainNationality = values[5],
                    Notes = values[6]
                };
                Countries.Add(country);
            }
        }
    }
}
