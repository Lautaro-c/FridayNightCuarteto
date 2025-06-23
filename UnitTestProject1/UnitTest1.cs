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

        [TestMethod]
        public void ArrowImageTest()
        {
            Image expectedImage = Engine.LoadImage("assets/LeftArrowU.png");
            Transform transform = new Transform(628, 0, 0, 0, 0, 0);
            ChoseArrowImage choseArrowImage = new ChoseArrowImage(transform, false);
            Assert.AreNotEqual(expectedImage, choseArrowImage.GetImage());
        }
        [TestMethod]
        public void ColliderTest()
        {
            Collider collider = new Collider();
            Transform transform1 = new Transform(10, 10, 5, 5, 0, 0);
            Transform transform2 = new Transform(7, 7, 5, 5, 0, 0);
            Assert.IsTrue(collider.BoxCollider(transform1, transform2));
        }
    }
}
