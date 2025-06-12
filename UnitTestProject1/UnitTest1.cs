using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyGame;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PointsLimitTest()
        {
            Points points = new Points();

            points.RythmPoints = 30;
            int expectedPoints = 0;

            Assert.AreEqual(expectedPoints, points.RythmPoints);
        }
    }
}
