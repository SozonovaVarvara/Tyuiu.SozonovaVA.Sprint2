using Tyuiu.SozonovaVA.Sprint2.Task0.V22.Lib;
namespace Tyuiu.SozonovaVA.Sprint2.Task0.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3105;
            int y = 77;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, true, true, true, true, false };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
