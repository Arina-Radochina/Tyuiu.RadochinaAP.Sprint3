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
                valueArray[count] = Math.Round(Math.Sin(x), 2);
                count++;
            }
            return valueArray;
        }
    }
}
