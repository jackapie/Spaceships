using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceships
{
    public abstract class Alien
    {
        public int x { get; set; }
        public int y { get; set; }
        
        public void Move(int dx, int dy)
        {
            x = x + dx;
            y = y + dy;

        }

        public abstract string colour { get; }
    }
}
