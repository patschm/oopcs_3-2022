using IEEE;

namespace DoomsdayPreppers
{
    public class Valkuil : IDetector
    {
        public void Activate()
        {
            Opent();
        }

        public void Opent()
        {
            Console.WriteLine("De valkuil opent. Spiezen komen nu dreigend in beeld");
        }
    }
}