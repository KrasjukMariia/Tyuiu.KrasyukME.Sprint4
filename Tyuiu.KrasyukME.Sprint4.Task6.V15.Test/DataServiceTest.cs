using Tyuiu.KrasyukME.Sprint4.Task6.V15.Lib;
namespace Tyuiu.KrasyukME.Sprint4.Task6.V15.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var city = new string[] { "Чикаго", "Хьюстон", "Феникс", "Филадельфия", "Сан-Антонио", "Сан-Диего", "Даллас" };
            int res = ds.Calculate(city);
            int wait = 3;
            Assert.AreEqual(wait, res);
        }
    }
}