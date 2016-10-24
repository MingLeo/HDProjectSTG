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
        public void Test_New_Explosion_X()
        {
            Assert.AreEqual(1, espl.XLocation);
            Assert.AreNotEqual(0, espl.XLocation);
        }

        [Test]
        public void Test_New_Explosion_Y()
        {
            Assert.AreEqual(1, espl.YLocation);
            Assert.AreNotEqual(0, espl.YLocation);
        }

        [Test]
        public void Test_New_Explosion_Time()
        {
            Assert.AreEqual(1, espl.Time);
            Assert.AreNotEqual(0, espl.Time);
        }

        [Test]
        public void Test_New_Explosion_ElapsedTime()
        {
            Assert.AreEqual(0, espl.ElapsedTime);
            Assert.AreNotEqual(1, espl.ElapsedTime);
        }

        [Test]
        public void Test_IPatternCurve_MovePattern()
        {
            EnemyCircular ec = new EnemyCircular(20, 20, 2, 20);
            ec.MovePattern(2, 2, 2, 2, 2, 2);
            ec.Move();
            Assert.AreEqual(ec.XLocation, 2 + 2 * 2 * Math.Sin(0) * 2);
            Assert.AreNotEqual(ec.XLocation, 2 + 2 * 2 * Math.Sin(1) * 2);
        }

        [Test]
        public void Test_New_ItemFire_X()
        {
            Assert.AreEqual(i.XLocation, 1);
            Assert.AreNotEqual(i.XLocation, 2);
        }

        [Test]
        public void Test_New_ItemFire_Y()
        {
            Assert.AreEqual(i.YLocation, 1);
            Assert.AreNotEqual(i.YLocation, 2);
        }

        [Test]
        public void Test_New_ItemFire_Type()
        {
            Assert.AreEqual(i.Type, 1);
            Assert.AreNotEqual(i.Type, 2);
        }

        [Test]
        public void Test_Weapon_Move()
        {
            Weapon wpn = new Weapon(3, 3, 1, 1, BitmapKind.BulletA, 1);
            wpn.Move();
            Assert.AreEqual(wpn.XLocation, 2);
            Assert.AreNotEqual(wpn.XLocation, 3);
        }

        [Test]
        public void Test_New_Weapon_X()
        {
            Assert.AreEqual(wp.XLocation, 1);
            Assert.AreNotEqual(wp.XLocation, 2);
        }

        [Test]
        public void Test_New_Weapon_Y()
        {
            Assert.AreEqual(wp.YLocation, 1);
            Assert.AreNotEqual(wp.YLocation, 2);
        }

        [Test]
        public void Test_New_Weapon_BulletKind()
        {
            Assert.AreEqual(wp.BulletKind, BitmapKind.BulletA);
            Assert.AreNotEqual(wp.BulletKind, BitmapKind.BulletB);
            Assert.AreNotEqual(wp.BulletKind, BitmapKind.BulletC);
            Assert.AreNotEqual(wp.BulletKind, BitmapKind.EnemyCir);
            Assert.AreNotEqual(wp.BulletKind, BitmapKind.EnemyLin);
            Assert.AreNotEqual(wp.BulletKind, BitmapKind.Explosion);
            Assert.AreNotEqual(wp.BulletKind, BitmapKind.ItemFire1);
            Assert.AreNotEqual(wp.BulletKind, BitmapKind.ItemFire2);
            Assert.AreNotEqual(wp.BulletKind, BitmapKind.ItemFire3);
            Assert.AreNotEqual(wp.BulletKind, BitmapKind.Player0);
            Assert.AreNotEqual(wp.BulletKind, BitmapKind.Player1);
        }

        [Test]
        public void Test_New_Weapon_BulletPower()
        {
            Assert.AreEqual(wp.BulletPower, 1);
            Assert.AreNotEqual(wp.BulletPower, 2);
        }

        [Test]
        public void Test_New_Weapon_BelongTo()
        {
            Assert.AreEqual(wp.BelongTo, 1);
            Assert.AreNotEqual(wp.BelongTo, 2);
        }

        [Test]
        public void Test_Player_Fire()
        {
            Assert.AreEqual(InGameBullets.GamePlayerWeapon.Count, 0);
            Assert.AreNotEqual(InGameBullets.GamePlayerWeapon.Count, 1);
            Player p1 = new Player(10, 10, 1, 10, 1);
            p1.Equip(0, 1, 1, 1);
            p1.Fire(1);
            Assert.AreEqual(InGameBullets.GamePlayerWeapon.Count, 0);
            Assert.AreNotEqual(InGameBullets.GamePlayerWeapon.Count, 1);
            InGameBullets.GameEnemyWeapon.Clear();
            InGameBullets.GamePlayerWeapon.Clear();
        }

        [Test]
        public void Test_Player_MoveLeft()
        {
            Player p1 = new Player(10, 10, 1, 10, 1);
            p1.ControlDirection = 1;
            p1.Move();
            Assert.AreEqual(p1.XLocation, 9);
            Assert.AreNotEqual(p1.XLocation, 10);

        }

        [Test]
        public void Test_Player_MoveRight()
        {
            Player p1 = new Player(10, 10, 1, 10, 1);
            p1.ControlDirection = 2;
            p1.Move();
            Assert.AreEqual(p1.XLocation, 11);
            Assert.AreNotEqual(p1.XLocation, 10);
        }

        [Test]
        public void Test_Player_MoveUp()
        {
            Player p1 = new Player(10, 10, 1, 10, 1);
            p1.ControlDirection = 3;
            p1.Move();
            Assert.AreEqual(p1.YLocation, 9);
            Assert.AreNotEqual(p1.YLocation, 10);
        }

        [Test]
        public void Test_Player_MoveDown()
        {
            Player p1 = new Player(10, 10, 1, 10, 1);
            p1.ControlDirection = 4;
            p1.Move();
            Assert.AreEqual(p1.YLocation, 11);
            Assert.AreNotEqual(p1.YLocation, 10);
        }

        [Test]
        public void Test_Player_Equip_BulletSpeed()
        {
            Player p1 = new Player(10, 10, 1, 10, 1);
            p1.Equip(0, 1, 1, 1);
            Assert.AreEqual(p1.BulletSpeed, 1);
            Assert.AreNotEqual(p1.BulletSpeed, 0);
        }

        [Test]
        public void Test_Player_Equip_FirePower()
        {
            Player p = new Player(5, 5, 5, 5, 1);
            p.Equip(1, 1, 1, 1);
            Assert.AreEqual(p.FirePower, 1);
            Assert.AreNotEqual(p.FirePower, 0);
        }

        [Test]
        public void Test_Player_Equip_FireRate()
        {
            Player p = new Player(5, 5, 5, 5, 1);
            p.Equip(1, 1, 1, 1);
            Assert.AreEqual(p.FireRate, 1);
            Assert.AreNotEqual(p.FireRate, 0);
        }

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

    }
}
