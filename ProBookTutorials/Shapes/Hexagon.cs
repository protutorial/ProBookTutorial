﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Hexagon : Shape
    {
        public Hexagon()
        {

        }

        public Hexagon(string name) : base(name)
        {}

        public override void Draw()
        {
            //base.Draw();
            Console.WriteLine($"Drawing {PetName} : The Hexagon");
        }
    }
}
