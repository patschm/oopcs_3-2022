namespace EvolutieTheorieDerDelegates
{
    delegate int MathDel(int a, int b);

    class Program
    {
        static void Main()
        {
            // .NET 1.0/1.1
            MathDel m1 = new MathDel(Add);
            int result = m1(1, 2);

            // .NET 2.0
            MathDel m2 = Add;
            result = m2(2, 3);

            int c = 10;
            MathDel m3 = delegate(int a, int b)
            {
                return a + b + c;
            };
            result = m3(3, 4);

            // .NET 3.0 ev (2008)
            MathDel m4 = (a, b) =>a + b;
            result = m4(4,5);

            // Procedures
            // Action

            Action<string> a1 = Console.WriteLine;
            a1(result.ToString());

            // Functions
            // Func
            Func<int, int, int> a2 = Add;
            result = a2(6,7);

            //Predicate<int>
            result = Add2(8, 9);

            int Add2(int a, int b)
            {
                return a + b;
            }

            Console.WriteLine(result);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}

