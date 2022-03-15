using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    public class ACME
    {
        public IContract[] werknemers = new IContract[10];

        public void Hire(IContract wn)
        {
            for(int i = 0; i < werknemers.Length; i++)
            {
                if (werknemers[i] == null)
                {
                    werknemers[i] = wn;
                    return;
                }
            }
        }

        public void Start()
        {
            Console.WriteLine("ACME gaat iets maken");
            foreach(IContract iemand in werknemers)
                iemand?.VoertUit();
        }
    }
}
