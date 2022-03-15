using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatischeSpullen
{
    internal class Etage
    {
        private static Lift elevator = new Lift();
        public int Nummer { get; set; }

        public void RoepLift()
        {
            Etage.elevator.Call(Nummer);
        }
        public void ShowStatus()
        {
            Console.WriteLine($"De lift staat op de {elevator.CurrentFloor}e verdieping");
        }
    }
}
