using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceships
{
    public class GameArea
    {
        //Properties
        public Ship ship { get; set; }
        public AlienSwarm AlienSwarm { get; set; }

        //Fields
        int maxX = 100;
        int maxY = 100;

        //Constructor function. This shares the name of the class and its type is not defined here.
        public GameArea()
        {
            ship = new Ship();
            ship.X = maxX;
            ship.Y = 1;

            AlienSwarm = new AlienSwarm(maxX,maxY);
            
        
        }
        
    }
}
