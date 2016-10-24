using System;
using NUnit.Framework;
using MyGame;
using SwinGameSDK;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        Player p = new Player(10, 10, 10, 10, 1);
        EnemyCircular ec = new EnemyCircular(20, 20, 20, 20);
        EnemyLinear el = new EnemyLinear(30, 30, 30, 30);
        Controller c1 = new Controller();
        ItemFire i = new ItemFire(1, 1, 1);
        Explosion espl = new Explosion(1, 1, 1);
        Weapon wp = new Weapon(1, 1, 1, 1, BitmapKind.BulletA, 1);

        [Test]
        public void Test_IPatternLinear_MovePattern()
        {
            EnemyLinear el = new EnemyLinear(5, 5, 2, 5);
            el.MovePattern(2, 1);
            el.Move();
            Assert.AreEqual(el.XLocation, 7);
            Assert.AreNotEqual(el.XLocation, 8);
            el.Move();
            Assert.AreEqual(el.XLocation, 9);
            Assert.AreNotEqual(el.XLocation, 8);
            el.Move();
            Assert.AreEqual(el.XLocation, 7);
            Assert.AreNotEqual(el.XLocation, 8);
        }

        [Test]
        public void Test()
        {
            Assert.IsTrue(true);
        }

        [Test]
        public void Existence_Player()
        {
            Assert.IsNotNull(p);
        }

        [Test]
        public void Existence_EnemyCircular()
        {
            Assert.IsNotNull(ec);
        }

        [Test]
        public void Existence_EnemyLinear()
        {
            Assert.IsNotNull(el);
        }

        [Test]
        public void Initiation_Player()
        {
            Assert.AreEqual(p.XLocation, 10);
            Assert.AreEqual(p.YLocation, 10);
            Assert.AreEqual(p.Speed, 10);
            Assert.AreEqual(p.Hp, 10);
        }

        [Test]
        public void Initiation_EnemyCircular()
        {
            Assert.AreEqual(ec.XLocation, 20);
            Assert.AreEqual(ec.YLocation, 20);
            Assert.AreEqual(ec.Speed, 20);
            Assert.AreEqual(ec.Hp, 20);
        }

        [Test]
        public void Initiation_EnemyLinear()
        {
            Assert.AreEqual(el.XLocation, 30);
            Assert.AreEqual(el.YLocation, 30);
            Assert.AreEqual(el.Speed, 30);
            Assert.AreEqual(el.Hp, 30);
        }

        [Test]
        public void Initiation_EnemyLinear1()
        {
            Assert.AreEqual(el.XLocation, 30);
            Assert.AreEqual(el.YLocation, 30);
            Assert.AreEqual(el.Speed, 30);
            Assert.AreEqual(el.Hp, 30);
        }

        [Test]
        public void Initiation_controler()
        {
            Console.WriteLine("test");
            c1.CollisionPlayerVsBullet();
            
        }

        [Test]
        public void Initiation_InGameBullets()
        {
            InGameBullets.MoveBullet();
            InGameBullets.CleanBullet();
        }

    }
}
