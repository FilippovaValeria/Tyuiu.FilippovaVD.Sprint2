using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FilippovaVD.Sprint2.Task5.V3.Lib;

namespace Tyuiu.FilippovaVD.Sprint2.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();

            Assert.AreEqual("Понедельник", ds.FindDayName(1));
            Assert.AreEqual("Среда", ds.FindDayName(3));
            Assert.AreEqual("Воскресенье", ds.FindDayName(7));

            Assert.AreEqual("Некорректный номер дня недели", ds.FindDayName(0));
            Assert.AreEqual("Некорректный номер дня недели", ds.FindDayName(8));
        }
    }
}
