using Tyuiu.NuryevAR.Sprint3.Task0.V16.Lib;

namespace Tyuiu.NuryevAR.Sprint3.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int value = 1;
            int startValue = 1;
            int stopValue = 13;
            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 7.5;
            Assert.AreEqual(wait, res);
        }
    }
}