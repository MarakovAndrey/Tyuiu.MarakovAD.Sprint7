using Tyuiu.MarakovAD.Sprint7.Project.V13.Lib;
namespace Tyuiu.MarakovAD.Sprint7.Project.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {


        [TestMethod]
        public void LoadFromCSVTest()
        {
            DataService ds = new DataService();

            string tempFile = Path.GetTempFileName();

            File.WriteAllText(tempFile, "Название;Столица;Площадь;Население;Плотность;Национальность;Развитая\nРоссия;Москва;1000;100;1;Русские;true");

            try
            {
                ds.LoadFromCsv(tempFile);

                Assert.AreEqual(1, ds.Countries.Count);
                Assert.AreEqual("Россия", ds.Countries[0].Name);
            }
            finally { 
                File.Delete(tempFile);
            }
        }



        [TestMethod]
        public void GetStatistickAreaTest() {
            DataService ds = new DataService();

            ds.Countries.Add(new Country { Name = "Россия", Area = 1000 });
            ds.Countries.Add(new Country { Name = "Германия", Area = 200 });
            ds.Countries.Add(new Country { Name = "Бразилия", Area = 800 });

            string result = ds.GetStatisticsArea();

            Assert.IsTrue(result.Contains("Самая большая: Россия"));
            Assert.IsTrue(result.Contains("Самая маленькая: Германия"));
        }



        [TestMethod]
        public void GetStatisticsPopulationTest()
        {
            DataService ds = new DataService();

            ds.Countries.Add(new Country { Name = "Китай", Population = 1400000000 });
            ds.Countries.Add(new Country { Name = "Россия", Population = 40000 });

            string result = ds.GetStatisticsPopulation();

            Assert.IsTrue(result.Contains("Китай"));
            Assert.IsTrue(result.Contains("Россия"));
        }



        [TestMethod]
        public void GetStatisticsDeveloped_MixedCountries_ReturnsCorrectCount()
        {

            DataService ds = new DataService();
            ds.Countries.Add(new Country { Name = "Россия", IsDeveloped = true });
            ds.Countries.Add(new Country { Name = "Германия", IsDeveloped = true });
            ds.Countries.Add(new Country { Name = "Бразилия", IsDeveloped = false });

            string result = ds.GetStatisticsDeveloped();

            Assert.IsTrue(result.Contains("Развитых стран: 2 из 3"));
        }



        [TestMethod]
        public void SaveToCsv_OneCountry_SavesCorrectly()
        {
            DataService ds = new DataService();
            ds.Countries.Add(new Country
            {
                Name = "Россия",
                Capital = "Москва",
                Area = 100,
                Population = 1000,
                Population_density = 10,
                MainNationality = "Русские",
                IsDeveloped = true
            });

            string tempFile = Path.GetTempFileName();

            try
            {
                ds.SaveToCsv(tempFile);

                string content = File.ReadAllText(tempFile);
                Assert.IsTrue(content.Contains("Россия"));
                Assert.IsTrue(content.Contains("Москва"));
            }
            finally
            {
                File.Delete(tempFile);
            }
        }
    }
}
