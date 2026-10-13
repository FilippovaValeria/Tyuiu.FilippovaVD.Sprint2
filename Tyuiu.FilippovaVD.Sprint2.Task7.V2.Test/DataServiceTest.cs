using Tyuiu.FilippovaVD.Sprint2.Task7.V2.Lib;

namespace Tyuiu.FilippovaVD.Sprint2.Task7.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckPoint()
        {
            DataService ds = new DataService();

            Assert.IsTrue(ds.CheckDotInShadedArea(0.5, -0.2));

            Assert.IsFalse(ds.CheckDotInShadedArea(1.5, -0.5));

            Assert.IsFalse(ds.CheckDotInShadedArea(0.5, -0.5));
        }
    }
}
