﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spaceships
{
    public class Ship : ScreenObject
    {
        public override int X { get; set; }
        public override int Y { get; set; }

        public override void Move(int dx, int dy)
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

    }
}
