using Tyuiu.RadochinaAP.Sprint3.Task3.V11.Lib;
namespace Tyuiu.RadochinaAP.Sprint3.Task3.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharOnNum()
        {
            DataService ds = new DataService();

            string str = "sqwreq vqwqq q";
            string res = ds.ReplaceCharOnNum(str, 'q', '7');

            string wait = "s7wre7 v7w77 7";

            Assert.AreEqual(wait, res);
        }
    }
}
