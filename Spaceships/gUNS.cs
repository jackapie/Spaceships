using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceships
{
    public class Guns

    {
        

        
        public int StartX { get; set; }
        public int StartY { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }


        public void Move(int maxY)
        {
            PositionX = StartX;
            for(int counter = StartY; counter < maxY; counter++)
            {
                PositionY = counter;
            }
        }
    }
}
