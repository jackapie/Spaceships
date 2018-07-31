using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceships
{
    public class Ship
    {
        public int x { get; set; }
        public int y { get; set; }

        public void Move(int dx, int dy)
        {
            x = x + dx;
            y = y + dy;
            
        }
    }
}
