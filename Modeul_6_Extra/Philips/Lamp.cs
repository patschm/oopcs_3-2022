using IEEE;

namespace Philips
{
    public class Lamp : IDetector
    {
        public void Aan()
        {
            Console.WriteLine("De lamp gaat branden");
        }

        public void Activate()
        {
            Aan();
        }
    }
}