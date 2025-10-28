using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RadochinaAP.Sprint3.Task7.V9.Lib
{
    public class DataService : ISprint3Task7V9
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = stopValue - startValue + 1;
            valueArray = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) - 2 * x;

                if (Math.Abs(denominator) < 0.000001)
                {
                    valueArray[count] = 0.00;
                }
                else
                {
                    double result = (2 * x - 3) / denominator + 5 * x - Math.Sin(x);
                    valueArray[count] = Math.Round(result, 2);
                }
                count++;
            }
            return valueArray;
        }
    }
}
