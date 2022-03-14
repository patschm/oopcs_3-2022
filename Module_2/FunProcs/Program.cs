namespace FuncProcs
{
    class Program
    {
        static void Main()
        {
            int x;
            Vulling(out x);
            Console.WriteLine(x);
            int a = 10;
            int b = 20;
            Console.WriteLine($"a={a}, b={b}");
            Swap(ref a, ref b);
            Console.WriteLine($"a={a}, b={b}");

            //int[] getallen = new int[5];
            //var key = ConsoleKey.Enter;
            //int nr = 0;
            //do
            //{
            //    getallen[nr++] = GeefGetal();
            //    Console.WriteLine("Nog een getal? (Esc voor geen getal meer)");
            //    key = Console.ReadKey().Key;
            //}
            //while (key != ConsoleKey.Escape);
            //var getalA = GeefGetal();
            //var getalB = GeefGetal();
            var result = TelOp(1, 2, 3, 4, 5);
            ToonGetal(result);

            DoeIets(y:"hallo");
        }

        static void DoeIets(int x = 42, string y = "Ha", long z = 100)
        {
            Console.WriteLine($"Z={z}");
        }

        static void Vulling(out int x)
        {
            x = 100;
        }

        static void Swap(ref int aa, ref int bb)
        {
            int tmp = aa;
            aa = bb;
            bb = tmp;
        }

        static long TelOp(params int[] getallen)
        {
            return getallen.Sum();
        }
        static long TelOp(long getalA, long getalB)
        {
            return getalA + getalB;
        }
        static int TelOp(int getalA, int getalB)
        {
            return getalA + getalB;
        }

        // Procedure
        static void ToonGetal(int nr)
        {
            Console.WriteLine($"Het getal is {nr}");
        }
        static void ToonGetal(long nr)
        {
            Console.WriteLine($"Het getal is {nr}");
        }
        // Function
        static int GeefGetal()
        {
            Console.WriteLine("Geef een getal");
            string? s = Console.ReadLine();
            return int.Parse(s!);
        }
    }
}
