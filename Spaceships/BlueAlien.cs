using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceships
{
    public class BlueAlien : Alien
    {
        public override string Colour { get { return "blue"; } }

        public BlueAlien(int startX, int startY)
        {
            
            X = startX;
            Y = startY;
        }
    }
}
