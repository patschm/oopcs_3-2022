using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestelling
{
    public delegate void Order();

    public class Walter
    {
        public void Execute(Order fn)
        {
            Console.WriteLine("Walter voert de volgende bestelling uit");
            fn();
        }
    }
}
