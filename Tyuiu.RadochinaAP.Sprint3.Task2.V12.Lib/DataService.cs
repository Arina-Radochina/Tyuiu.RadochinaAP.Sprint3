using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RadochinaAP.Sprint3.Task2.V12.Lib
{
    public class DataService : ISprint3Task2V12
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double product = 1;
            int i = startValue;

            do
            {
                // Формула: (300/(i + x^i))^i
                double term = 300.0 / (i + Math.Pow(value, i));
                product *= Math.Pow(term, i);
                i++;
            }
            while (i <= stopValue);

            return Math.Round(product, 3);
        }
    }
}
      