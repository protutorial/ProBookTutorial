using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    class Radio
    {
        public void TurnOn(bool on_off)
        {
            Console.WriteLine(on_off ? "Jamming.." : "Quite TIming");
        }
    }
}
