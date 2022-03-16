using IEEE;

namespace Heras
{
    public class Hek : IDetector
    {
        public void Activate()
        {
            Open();
        }

        public void Open()
        {
            Console.WriteLine("Het hek gaat open");
        }
    }
}