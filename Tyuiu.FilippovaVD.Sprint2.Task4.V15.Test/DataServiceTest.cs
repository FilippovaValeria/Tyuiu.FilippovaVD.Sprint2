using Tyuiu.FilippovaVD.Sprint2.Task4.V15.Lib;

namespace Tyuiu.FilippovaVD.Sprint2.Task4.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition()
        {
            DataService ds = new DataService();

            int x = 4;
            int y = 1;

            double wait = 625.0;
            double res1 = ds.Calculate(4, 1);

            
            Assert.AreEqual(wait, res1);

            
            double res2 = ds.Calculate(1, 1000000);

            Assert.IsTrue(res2 > 0);
        }
    }
}
