using Tyuiu.FilippovaVD.Sprint2.Task3.V15.Lib;

namespace Tyuiu.FilippovaVD.Sprint2.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition()
        {
            DataService ds = new DataService();

            Assert.AreEqual(11.0, ds.Calculate(2));
            
            Assert.AreEqual(0.75, ds.Calculate(0));
            
            Assert.AreEqual(256.0, ds.Calculate(-1));
            
            Assert.AreEqual(-219.95, ds.Calculate(-20));
        }
    }
}