namespace FoutenGedoe
{
    public static class Program
    {
        static void Main()
        {
            foreach(int i in GetNumbers())
            {
                Console.WriteLine(i);
            }

            try
            {
                int nr = GetNumber();
                Console.WriteLine(nr);
                //return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("ALTIJD!!!!");
            }

            Console.ReadLine();
        }

        static IEnumerable<int> GetNumbers()
        {
            yield return 1;
            Console.WriteLine("een");
            yield return 2;
            Console.WriteLine("twee");
            yield return 3;
        }

        private static int GetNumber()
        {
            do
            {
                Console.WriteLine("Geef een getal");
                string snr = Console.ReadLine();
                try
                {
                   // throw new Exception("Ooops");
                    int nr = int.Parse(snr);
                    int data = 3 / nr;
                    return nr;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Geen geldig nummer.");
                }
                catch(OverflowException)
                {
                    Console.WriteLine($"Getal te groot of  te klein ({int.MinValue}, {int.MaxValue})");
                }
                catch(ArgumentNullException)
                {
                    Console.WriteLine("Ook niet goed");
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Oei!");
                    //Console.WriteLine(ex);
                    throw;
                }
            }
            while (true);
        }
    }
}
