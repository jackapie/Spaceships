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
    public class AlienTests
    {
        [TestMethod()]
        public void MoveTest()
        {
            var alien = new RedAlien(5, 20);
            alien.Move(2, -15);
            Assert.AreEqual(7, alien.X);
            Assert.AreEqual(5, alien.Y);
            
        }
    }
}