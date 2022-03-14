using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampenFabriek
{
    public class Lamp
    {
        // Eigenschappen sla je op in fields
        public int intensiteit = 400;
        public ConsoleColor kleur = ConsoleColor.Red;

        // Gedrag. Leg je vast in functions of procedures (Methods)
        public void Aan()
        {
            Console.BackgroundColor = kleur;
            Console.WriteLine($"De lamp brandt met {intensiteit} lumen");
        }
        public void Uit()
        {
            Console.WriteLine("De lamp gaat uit");
            Console.ResetColor();
        }

        // Constructors. Zijn bedoeld om _fields_ van een initiele waarde te voorzien.
        public Lamp(ConsoleColor col, int intens = 100)
        {
            this.intensiteit = intens;
            this.kleur = col;
        }
        public Lamp() : this(ConsoleColor.Blue, 200)
        { }
    }
}
