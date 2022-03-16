using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioAmateur
{
    public static class OntvangsMethods
    {
        public static void Invokes(this MulticastDelegate o, string msg)
        {
            foreach (var del in o.GetInvocationList())
            {
                try
                {
                    //subscribers?.Invoke("Hallo luisteraars");
                    del.Method.Invoke(null, new object[] { msg });
                }
                catch (Exception ex)
                {

                }
            }
        }
        public static void ViaSms(string message)
        {
            Console.WriteLine($"Via SMS ontvangen: {message}");
        }
        public static void ViaEther(string message)
        {
            Console.WriteLine($"Via Ether ontvangen: {message}");
        }
        public static void ViaKabel(string message)
        {
            Console.WriteLine($"Via Kabel ontvangen: {message}");
            throw new Exception("Ooops");
        }
        public static void ViaPostduif(string message)
        {
            Console.WriteLine($"Via Postduif ontvangen: {message}");
        }
        public static void ViaInternet(string message)
        {
            Console.WriteLine($"Via Internet ontvangen: {message}");
        }
    }
}
