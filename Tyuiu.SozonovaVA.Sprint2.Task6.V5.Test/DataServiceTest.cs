using Tyuiu.SozonovaVA.Sprint2.Task6.V5.Lib;
namespace Tyuiu.SozonovaVA.Sprint2.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 14;
            string res = ds.FindCardValue(x);
            string wait = "туз";
            Assert.AreEqual(wait, res);
        }
    }
}
