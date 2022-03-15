using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    public class Wik: Werknemer
    {
        public void Bouwt()
        {
            Console.WriteLine("Wik bouwt iets in elkaar");
        }

        public override void Werkt()
        {
            Bouwt();
        }
    }
}
