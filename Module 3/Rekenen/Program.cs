using Rekenen;

Complex c1 = new Complex { Real = 100, Imaginary=200 };

Console.WriteLine(c1);
DoeIets(c1);
Console.WriteLine(c1);
 
    
    
 void DoeIets(Complex ha)
{
    ha.Real = 1000;
    ha.Imaginary = 2000;
}