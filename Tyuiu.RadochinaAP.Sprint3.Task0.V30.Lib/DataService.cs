using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RadochinaAP.Sprint3.Task0.V30.Lib
{
    public class DataService : ISprint3Task0V30
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double product = 1.0;
            double constant = Math.Pow(Math.Sin(1), 10);

            for (int k = startValue; k <= stopValue; k++)
            {
                product *= k * constant;
            }

            return Math.Round(product, 3);
        }
    }
    
}
