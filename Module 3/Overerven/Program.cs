using LampenFabriek;
using Overerven;

Lamp tl = new TL { StartCount = 4, Kleur=ConsoleColor.Green };
tl.Kleur = ConsoleColor.Red;
//(tl as TL).StartCount = 7;
tl.Aan();

tl.Uit();
