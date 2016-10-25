using System;
using NUnit.Framework;
using MyGame;
using SwinGameSDK;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {

        [Test]
        public void TestAlive()
        {
            Controller testController = new Controller();
            testController.Player0.Add(new Player(100, 100, 2, 5, 0));
            testController.Player0[0].Hp = -1;

            testController.CheckAlive();

            Assert.AreEqual(testController.Player0.Count, 0);

        }

    }
}
