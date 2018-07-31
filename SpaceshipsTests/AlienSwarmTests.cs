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
    public class AlienSwarmTests
    {
        [TestMethod()]
        public void AlienSwarmTest()
        {
            var swarm = new AlienSwarm(1,100,100,100);
            Assert.AreEqual(30, swarm.aliens.Count);
        }
    }
}