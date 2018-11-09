using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shape[] shapesOfObjects = { new Hexagon(), new Circle(), new Hexagon("Suri"), new 
            //        Circle("Surendra")};

            //foreach(Shape shape in shapesOfObjects)
            //{
            //    shape.Draw();
            //}

            ThreeDCircle threeDCircle = new ThreeDCircle();

            threeDCircle.Draw();
        }
    }
}
