using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RadochinaAP.Sprint3.Task1.V17.Lib
{
    public class DataService : ISprint3Task1V17
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double product = 1;
            int k = startValue;

            while (k <= stopValue)
            {
                product *= Math.Pow(2 / Math.Cos(value), k);
                k++;
            }

            return Math.Round(product, 8);
        }
    }
}

