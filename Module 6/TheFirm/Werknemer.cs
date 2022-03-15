using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    public abstract class Werknemer : Person, IContract
    {
        public void VoertUit()
        {
            Werkt();
        }

        public abstract void Werkt();
    }
}
