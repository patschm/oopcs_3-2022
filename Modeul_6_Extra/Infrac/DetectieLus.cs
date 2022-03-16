using IEEE;

namespace Infrac
{
    public class DetectieLus
    {
        private IDetector[] devices = new IDetector[10];
        public event Detector Detecting;

        public void Connect(IDetector device)
        {
            for (int i = 0; i < devices.Length; i++)
            {
                if (devices[i] == null)
                {
                    devices[i] = device;
                    return;
                }
            }
        }
        public void Detect()
        {
            Console.WriteLine("De detectielus ziet pissed students");
            Detecting?.Invoke();

            foreach(IDetector device in devices)
            {
                device?.Activate();
            }
        }
    }
}