using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShepiotkinIA.Sprint1.Task7.V21.Lib;

namespace Tyuiu.ShepiotkinIA.Sprint1.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            double wait = -7.984;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
