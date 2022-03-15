using StatischeSpullen;

string x = "Hallo";
string res = x.SponsoredBy();
Console.WriteLine(res);


Point a = new Point { X = 10, Y = 20 };
Point b = new Point { X = 100, Y = 200 };

Point c = a + b;
c.Display();



Etage[] flat = new Etage[40];
for (int i = 0; i < flat.Length; i++)
{
    flat[i] = new Etage { Nummer = i};
}

flat[30].RoepLift();

foreach (Etage e in flat)
{
   // e.ShowStatus();
}