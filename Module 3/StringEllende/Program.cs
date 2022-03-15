
using System.Diagnostics;
using System.Text;

int x = 10;
DoeIets(x);

StringBuilder s = new StringBuilder();
Stopwatch sw = new Stopwatch();
sw.Start();
for(int i = 0; i < 100000; i++)
{
    s.Append(i);
}
sw.Stop();
Console.WriteLine(sw.Elapsed);
Console.ReadLine();

DoeIets(42);


// Boxing
// xx = 42
void DoeIets(object xx)
{
    //int xxx = (int)xx;
    Console.WriteLine(xx);
}

