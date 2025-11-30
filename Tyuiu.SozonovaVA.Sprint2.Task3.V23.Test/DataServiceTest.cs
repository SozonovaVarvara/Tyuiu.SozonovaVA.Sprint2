using Tyuiu.SozonovaVA.Sprint2.Task3.V23.Lib;
namespace Tyuiu.SozonovaVA.Sprint2.Task3.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 18;
            Assert.AreEqual(wait, res);
        }
    }
}
