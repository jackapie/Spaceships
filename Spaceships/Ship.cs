using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceships
{
    public class Ship
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Move(int dx, int dy)
        {
            X = X + dx;
            Y = Y + dy;
            
        }

       

        public void ShipTurn()
        {

        }
    }
}
