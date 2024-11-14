using Tyuiu.KrasyukME.Sprint4.Task7.V1.Lib;
namespace Tyuiu.KrasyukME.Sprint4.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            string value = "135792468";
            int expectedCount = 4; // Четные числа: 2, 4, 6, 8

            int result = ds.Calculate(3, 3, value);

            Assert.AreEqual(expectedCount, result);
        }
    }
}