using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceships
{
    //This class is "abstract", and so an object of this type cannot be created.
    //However, objects of classes that inherit from this one can be created (ie. RedAlien, GreenAlien, etc.)

    public abstract class Alien : ScreenObject
    {
        public override int X { get; set; }
        public override int Y { get; set; }
        
        public override void Move(int dx, int dy)
        {
            X = X + dx;
            Y = Y + dy;

        }


        //The value of this property is given in inheriting classes, such as RedAlien.
        public abstract string Colour { get; }
    }
}
