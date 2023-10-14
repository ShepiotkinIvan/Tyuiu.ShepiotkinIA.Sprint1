using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShepiotkinIA.Sprint1.Task3.V19.Lib;

namespace Tyuiu.ShepiotkinIA.Sprint1.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 2;
            double x2 = 3;
            double y1 = 2;
            double y2 = 3;
            bool wait = true;
            var res = ds.ElephCanMove(x1, x2, y1, y2);
            Assert.AreEqual(wait, res);
        }
    }
}
