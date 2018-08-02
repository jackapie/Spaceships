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
    }
}