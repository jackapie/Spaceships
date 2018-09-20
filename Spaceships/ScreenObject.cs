using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceships
{
    public abstract class ScreenObject
    {
        public abstract int X { get; set; }
        public abstract int Y { get; set; }

        public abstract void Move(int dx, int dy);
    }
}
