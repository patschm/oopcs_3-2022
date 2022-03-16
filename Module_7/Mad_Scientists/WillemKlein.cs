using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mad_Scientists
{
    public delegate int MathDel(int x, int y);

    public class WillemKlein
    {
        public void Bereken(MathDel berekening, int a, int b)
        {
            Console.WriteLine("Willem Klein gaat rekenen...");
            int res = berekening(a, b);

            Console.WriteLine($"Willem kraait: het antwoord is {res}");
        }
    }
}
