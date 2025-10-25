using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RadochinaAP.Sprint3.Task6.V8.Lib
{
    public class DataService : ISprint3Task6V8
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int totalSum = 0;

            for (int num = startValue; num <= stopValue; num++)
            {
                for (int divisor = 12; divisor <= num; divisor++) // Делители больше 11
                {
                    if (num % divisor == 0)
                    {
                        totalSum += divisor;
                    }
                }
            }

            return totalSum;
        }
    }
}
