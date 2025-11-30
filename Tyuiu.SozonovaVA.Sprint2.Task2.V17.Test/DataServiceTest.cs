using Tyuiu.SozonovaVA.Sprint2.Task2.V17.Lib;
namespace Tyuiu.SozonovaVA.Sprint2.Task2.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 14;
            int y = 7;
            Assert.AreEqual(false, ds.CheckDotInShadedArea(x, y));
        }
    }
}
