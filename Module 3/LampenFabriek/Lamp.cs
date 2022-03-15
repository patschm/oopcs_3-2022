using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LampenFabriek
{
    public abstract class Lamp
    {
        // Eigenschappen sla je op in fields
        private int intensiteit = 400;
        //private ConsoleColor kleur = ConsoleColor.Red;

        // Auto-generating property. Brengt zijn eigen private field mee
        public ConsoleColor Kleur { get; set; } = ConsoleColor.Green;

        public int Lumen
        {
            get
            {
                return intensiteit;
            }
            set
            {
                if (value >= 0 && value < 1000)
                {
                    intensiteit = value;
                }
            }
        }

        // Old school.
        //public int GetLumen()
        //{
        //    return intensiteit;
        //}
        //public void SetLumen(int val)
        //{
        //    if (val >=0 && val < 1000)
        //    {
        //        intensiteit = val;
        //    }
        //}

        // Gedrag. Leg je vast in functions of procedures (Methods)
        public abstract void Aan();
        //{
        //    Console.BackgroundColor = Kleur;
        //    Console.WriteLine($"De lamp brandt met {Lumen} lumen");
        //}
        public void Uit()
        {
            Console.WriteLine("De lamp gaat uit");
            Console.ResetColor();
        }

        // Constructors. Zijn bedoeld om _fields_ van een initiele waarde te voorzien.
        public Lamp(ConsoleColor col, int intens = 100)
        {
            Lumen = intens;
            this.Kleur = col;
        }
        public Lamp() : this(ConsoleColor.Blue, 200)
        { }
    }
}
