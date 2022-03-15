using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delen
{
    public partial class Lamp
    {
        private int intensiteit = 400;
        public ConsoleColor Kleur { get; set; } = ConsoleColor.Green;

        public int Lumen
        {
            get
            {
                DoeIets();
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

        partial void DoeIets();

    }
}
