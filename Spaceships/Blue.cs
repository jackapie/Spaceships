using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceships
{
    public class Blue : ScreenObjectDecorator
    {
        public Blue(ScreenObject screenObject)
        {
            this.screenObject = screenObject;
        }

        public override int X { get; set;}
        public override int Y { get; set;}

        public override void Move(int dx, int dy)
        {
            screenObject.Move(dx, dy);
        }
    }
}
