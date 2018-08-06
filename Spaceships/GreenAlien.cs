using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceships
{
     class GreenAlien : Alien
    {
        public override string Colour
        {
            get { return "green"; }
        }

        public GreenAlien(int startX, int startY)
        {
            X = startX;
            Y = startY;
        }
    }
}
