using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceships
{
    public class GameArea
    {
        public Ship ship { get; set; }
        public AlienSwarm AlienSwarm { get; set; }

        int maxX = 100;
        int maxY = 100;

        public GameArea()
        {
            ship = new Ship();
            ship.x = maxX;
            ship.y = 1;

            AlienSwarm = new AlienSwarm(0,maxY,maxX,maxY);
            
        
        }
        
    }
}
