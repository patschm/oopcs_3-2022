using System.Collections;
using System.Text;

namespace Generieken
{
    class Program
    {
        static void Main()
        {
            Collections();

            Complex<float> complex = new Complex<float> { Real = 100, Imaginary = 200 };
            Complex<int> complex2 = new Complex<int> { Real = 100, Imaginary = 200 };

            

            decimal a = 10M;
            decimal b = 20M;
            Console.WriteLine($"a={a}, b={b}");
            Swap(ref a, ref b);
            Console.WriteLine($"a={a}, b={b}");

            StringBuilder bld = Create<StringBuilder>();
        }

        private static void Collections()
        {
            //ArrayList list = new ArrayList();
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            //list.Add("3");

            foreach(int i in list)
            {
               Console.WriteLine(i);
            }
        }

        static T Create<T>() where T : class, new()
        {
            return new T();
        }

        static void Swap<T>(ref T a, ref T b) where T : IFormattable
        {
            T tmp = a;
            a = b;
            b = tmp;
        }

        //static void Swap(ref float a, ref float b)
        //{
        //    float tmp = a;
        //    a = b;
        //    b = tmp;
        //}
        //static void Swap(ref long a, ref long b)
        //{
        //    long tmp = a;
        //    a = b;
        //    b = tmp;
        //}
        //static void Swap(ref int a, ref int b)
        //{
        //    int tmp = a;
        //    a = b;
        //    b = tmp;
        //}
    }
}
