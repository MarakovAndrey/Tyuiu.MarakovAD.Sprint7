using System.ComponentModel;

namespace Tyuiu.MarakovAD.Sprint7.Project.V13.Lib
{
    public class Country {
        public string Name { get; set; }
        public string Capital { get; set; }
        public double Area { get; set; }
        public int Population { get; set; }
        public double Population_density { get; set; }
        public string MainNationality { get; set; }
        public bool IsDeveloped { get; set; }
    }
    public class DataService
    {
        public BindingList<Country> Countries { get; private set; }
        public DataService() {
            Countries = new BindingList<Country>();
        }


        public void LoadFromCsv(string filePath) { 
            Countries.Clear();
            var lines = File.ReadAllLines(filePath, System.Text.Encoding.UTF8);
            foreach (var line in lines.Skip(1))
            {
                var values = line.Split(';');
                var country = new Country
                {
                    Name = values[0],
                    Capital = values[1],
                    Area = double.Parse(values[2]),
                    Population = int.Parse(values[3]),
                    Population_density = double.Parse(values[4]),
                    MainNationality = values[5],
                    IsDeveloped = bool.Parse(values[6]),
                };
                Countries.Add(country);
            }
        }

        public void SaveToCsv(string filePath) {
            var lines = new List<string> {
                "Название;Столица;Площадь;Население;Плотность населения;Преобладающая национальность;Развитая"
            };

            foreach (var country in Countries) {
                lines.Add($"{country.Name};{country.Capital};{country.Area};" +
                    $"{country.Population};{country.Population_density};{country.MainNationality};" +
                    $"{country.IsDeveloped};");
            }

            File.WriteAllLines(filePath, lines, System.Text.Encoding.UTF8);
        }
    }
}
