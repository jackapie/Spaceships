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
            var swarm = new AlienSwarm(100, 100);
            Assert.AreEqual(30, swarm.Aliens.Count);
        }

        [TestMethod()]
        public void AlienSwarmMoveTest()
        {
            var swarm = new AlienSwarm(100, 100);
            while (swarm.Aliens.First().Y > 0)
            {
                swarm.AlienSwarmMove(100);
            }

        }
    }
}