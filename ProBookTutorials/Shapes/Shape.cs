﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shape
    {
        public string PetName { get; set; }

        public Shape(string name = "No Name")
        {
            PetName = name;
        }

        public abstract void Draw();

    }
}
