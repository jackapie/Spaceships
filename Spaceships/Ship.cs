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
            if(X > GameArea.maxX)
            {
                X = GameArea.maxX;
            }
            if(X < 0)
            {
                X = 0;
            }
            Y = Y + dy;
            if (Y > GameArea.maxY)
            {
                Y = GameArea.maxY;
            }
            if (Y < 0)
            {
                Y = 0;
            }

        }

       

        public void ShipTurn()
        {

        }
    }
}
