using Tyuiu.FilippovaVD.Sprint2.Task2.V11.Lib;
namespace Tyuiu.FilippovaVD.Sprint2.Task2.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x1 = 4;
            int y1 = 3;

            bool res1 = ds.CheckDotInShadedArea(x1, y1);
            bool wait1 = true;

            Assert.AreEqual(wait1, res1);
            int x2 = 1;
            int y2 = 1;

            bool res2 = ds.CheckDotInShadedArea(x2, y2);
            bool wait2 = false;

            Assert.AreEqual(wait2, res2);
        }
    }
}
