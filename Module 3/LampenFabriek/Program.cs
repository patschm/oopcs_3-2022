using LampenFabriek;
// Virtual world
// Big bang

Lamp tl = new Lamp(ConsoleColor.Green, 200);
//tl.kleur = ConsoleColor.Yellow;
//tl.intensiteit = 300;
tl.Aan();
Console.WriteLine("We kunnen lezen");
tl.Uit();

Console.WriteLine("Het is donker");


Lamp l2 = new Lamp { kleur = ConsoleColor.Cyan };
l2.Aan();

l2.Uit();
// Big crunch
