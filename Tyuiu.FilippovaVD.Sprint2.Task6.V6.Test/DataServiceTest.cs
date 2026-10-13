using Tyuiu.FilippovaVD.Sprint2.Task6.V6.Lib;

namespace Tyuiu.FilippovaVD.Sprint2.Task6.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCardName()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Дама пик", ds.FindCardNameAndValue(1, 12));

            Assert.AreEqual("Шестерка бубен", ds.FindCardNameAndValue(3, 6));

            Assert.AreEqual("Туз червей", ds.FindCardNameAndValue(4, 14));
        }
    }
}
