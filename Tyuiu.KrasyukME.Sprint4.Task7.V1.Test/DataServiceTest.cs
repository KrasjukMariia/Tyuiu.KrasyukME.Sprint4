using Tyuiu.KrasyukME.Sprint4.Task7.V1.Lib;
namespace Tyuiu.KrasyukME.Sprint4.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string value = "135792468";

            Assert.AreEqual(20, ds.Calculate(3, 3, value));
        }
    }
}