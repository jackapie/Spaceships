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
            ship.x = 2;
            ship.y = -3;
            ship.Move(-2, 6);

            Assert.AreEqual(0, ship.x);
            Assert.AreEqual(3, ship.y);
            
        }
    }
}