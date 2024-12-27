using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NuryevAR.Sprint3.Task0.V16.Lib
{
    public class DataService : ISprint3Task0V16
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            int i = 1;
            int x = 5;
            double multSeries = 1;
            while (startValue <= stopValue)
            {
                multSeries = multSeries * Math.Pow((300 / (i + Math.Pow(x, i))), i);
                startValue++;
                i++;
                Console.WriteLine("i " + i);
            }
            return Math.Round(multSeries, 3);
        }
    }
}
