namespace Basics
{
    public class Program
    {
        public static void Main()
        {

            //
            int age = 42;
           // int result = age ?? 42;
            string? name = Console.ReadLine();

            Console.WriteLine(name!.Length);

            long age2 = age;
            short age3 = (short)age;

            int a = age + 3;

            float d = 3 / 2;

            Console.WriteLine($"Naam is {name}, age is {d}");
        }
    }
}
