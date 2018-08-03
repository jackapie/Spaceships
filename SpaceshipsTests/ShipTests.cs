using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spaceships;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceships.Tests
{
    [TestClass()]
    public class ShipTests
    {
        [TestMethod()]
        public void MoveTest()
        {
            var ship = new Ship();
            ship.X = 2;
            ship.Y = -3;
            ship.Move(-2, 6);

            Assert.AreEqual(0, ship.X);
            Assert.AreEqual(3, ship.Y);

        }

        [TestMethod()]
        public void MoveTest1()
        {
            var ship = new Ship();
            ship.X = 2;
            ship.Y = -3;

            ship.Move(1000000, 1000000);

            Assert.IsTrue(ship.X <= GameArea.maxX);
            Assert.IsTrue(ship.Y <= GameArea.maxY);
        }

        [TestMethod()]
        public void MoveTest2()
        {
            var ship = new Ship();
            ship.X = 2;
            ship.Y = -3;

            ship.Move(-1000000, -1000000);

            Assert.IsTrue(ship.X >= 0);
            Assert.IsTrue(ship.Y >= 0);
        }
    }
}