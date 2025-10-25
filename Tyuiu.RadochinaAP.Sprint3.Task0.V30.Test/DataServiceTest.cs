using Tyuiu.RadochinaAP.Sprint3.Task0.V30.Lib;
namespace Tyuiu.RadochinaAP.Sprint3.Task0.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();
            int startValue = 1;
            int stopValue = 5;
            
            double res = ds.GetMultiplySeries(1, 5);

            double wait = 0.021; 

            Assert.AreEqual(wait, res);

        }
    }
}
