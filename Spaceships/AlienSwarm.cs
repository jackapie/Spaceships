using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceships
{
    public class AlienSwarm
    {
        public int x { get; set; }
        public int y { get; set; }

        public void Move(int dx, int dy)
        {
            x = x + dx;
            y = y + dy;

        }

        public List<Alien> aliens { get; set; }

        public AlienSwarm(int x, int y, int maxX, int maxY)
        {

            aliens = new List<Alien>();
            for (int Counter = 0; Counter < 10; Counter++)
            {
                var alienBlue = new BlueAlien();
                aliens.Add(alienBlue);
                alienBlue.y = maxY;
                alienBlue.x = Counter;
               

                var alienRed = new RedAlien();
                aliens.Add(alienRed);
                alienRed.y = maxY - 1;
                alienRed.x = Counter;
              

                var alienGreen = new GreenAlien();
                aliens.Add(alienGreen);
                alienGreen.y = maxY - 2;
                alienGreen.x = Counter;

            }

        }
    }
}
