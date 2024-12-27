using Tyuiu.NuryevAR.Sprint3.Task0.V16.Lib;

namespace Tyuiu.NuryevAR.Sprint3.Task0.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetMultiplySeries()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 5;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 0.033;

            Assert.AreEqual(wait, res);


        }
    }
}