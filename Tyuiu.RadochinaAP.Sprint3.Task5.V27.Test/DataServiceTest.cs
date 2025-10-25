using Tyuiu.RadochinaAP.Sprint3.Task5.V27.Lib;
namespace Tyuiu.RadochinaAP.Sprint3.Task5.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 5;
            int startValue2 = 1;
            int stopValue2 = 10;

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);
            double wait = -1848380.055;

            Assert.AreEqual(wait, res, 0.001);
        }
    }
}
