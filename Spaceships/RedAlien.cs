using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceships
{
     class RedAlien : Alien
    {

        
        public override string Colour { get { return "red"; } }

        public RedAlien(int startX, int startY)
        {
            X = startX;
            Y = startY;
        } 

       
    }
}
