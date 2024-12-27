using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.NuryevAR.Sprint3.Task0.V16.Lib
{
    public class DataService : ISprint3Task0V16
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double MulSeries0 = 0;
            double MulSeries1 = 1;
            double i;
            for (i = startValue; i <= stopValue; i++)
            {
                MulSeries0 = Math.Pow(value, i) + (1 / (i + 1));
                MulSeries1 *= MulSeries0;
            }
            return Math.Round(MulSeries1, 3);
        }
    }
}
