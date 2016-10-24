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
        public void Test_New_Player_X()
        {
            Assert.AreEqual(p.XLocation, 10);
            Assert.AreNotEqual(p.XLocation, 11);
        }

        [Test]
        public void Test_New_Player_Y()
        {
            Assert.AreEqual(p.YLocation, 10);
            Assert.AreNotEqual(p.YLocation, 11);
        }

        [Test]
        public void Test_New_Player_Speed()
        {
            Assert.AreEqual(p.Speed, 10);
            Assert.AreNotEqual(p.Speed, 11);
        }

        [Test]
        public void Test_New_Player_Hp()
        {
            Assert.AreEqual(p.Hp, 10);
            Assert.AreNotEqual(p.Hp, 11);
        }

        [Test]
        public void Test_EnemyCircular_Move_X()
        {
            EnemyCircular ec = new EnemyCircular(20, 20, 2, 20);
            ec.MovePattern(2, 2, 2, 2, 2, 2);
            ec.Move();
            Assert.AreEqual(ec.XLocation, 2 + 2 * 2 * Math.Sin(0) * 2);
            Assert.AreNotEqual(ec.XLocation, 2 + 2 * 2 * Math.Sin(1) * 2);
        }

        [Test]
        public void Test_EnemyCircular_Move_Y()
        {
            EnemyCircular ec = new EnemyCircular(20, 20, 2, 20);
            ec.MovePattern(2, 2, 2, 2, 2, 2);
            ec.Move();
            Assert.AreEqual(ec.YLocation, 2 + 2 * 2 * Math.Cos(0) * 2);
            Assert.AreNotEqual(ec.YLocation, 2 + 2 * 2 * Math.Cos(1) * 2);
        }

        [Test]
        public void Test_New_EnemyCircular_X()
        {
            Assert.AreEqual(ec.XLocation, 20);
            Assert.AreNotEqual(ec.XLocation, 21);
        }

        [Test]
        public void Test_New_EnemyCircular_Y()
        {
            Assert.AreEqual(ec.YLocation, 20);
            Assert.AreNotEqual(ec.YLocation, 21);
        }

        [Test]
        public void Test_New_EnemyCircular_Speed()
        {
            Assert.AreEqual(ec.Speed, 20);
            Assert.AreNotEqual(ec.Speed, 21);
        }

        [Test]
        public void Test_New_EnemyCircular_Hp()
        {
            Assert.AreEqual(ec.Speed, 20);
            Assert.AreNotEqual(ec.Hp, 21);
        }

        [Test]
        public void Test_EnemyLinear_Move_X()
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
        public void Test_EnemyLinear_Move_Y()
        {
            EnemyLinear el = new EnemyLinear(5, 5, 2, 5);
            el.MovePattern(2, 1);
            el.Move();
            Assert.AreEqual(el.YLocation, 7);
            Assert.AreNotEqual(el.YLocation, 8);
            el.Move();
            Assert.AreEqual(el.YLocation, 9);
            Assert.AreNotEqual(el.YLocation, 8);
            el.Move();
            Assert.AreEqual(el.YLocation, 7);
            Assert.AreNotEqual(el.YLocation, 8);
        }

        [Test]
        public void Test_New_EnemyLinear_X()
        {
            Assert.AreEqual(el.XLocation, 30);
            Assert.AreNotEqual(el.XLocation, 31);
        }

        [Test]
        public void Test_New_EnemyLinear_Y()
        {
            Assert.AreEqual(el.YLocation, 30);
            Assert.AreNotEqual(el.YLocation, 31);
        }

        [Test]
        public void Test_New_EnemyLinear_Speed()
        {
            Assert.AreEqual(el.Speed, 30);
            Assert.AreNotEqual(el.Speed, 31);
        }

        [Test]
        public void Test_New_EnemyLinear_Hp()
        {
            Assert.AreEqual(el.Hp, 30);
            Assert.AreNotEqual(el.Hp, 31);
        }

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
