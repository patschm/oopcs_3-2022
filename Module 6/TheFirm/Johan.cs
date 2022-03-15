using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    public class Johan : Werknemer
    {
        public void Pascalt()
        {
            Console.WriteLine("Johan Pascalt de code eruit");
        }

        public override void Werkt()
        {
            Pascalt();
        }
    }
}
