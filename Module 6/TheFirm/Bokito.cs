using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFirm
{
    public class Bokito : IContract, IContract2
    {
        void IContract2.VoertUit()
        {
            Console.WriteLine("Doet iets anders");
        }
        public void VoertUit()
        {
            Werkt();
        }

        public  void Werkt()
        {
            Console.WriteLine($"Bokito ramt dames in elkaar");
        }
    }
}
