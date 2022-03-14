// Jump back
int x = 0;
// Nul of meer keer uitgevoerd
while(x < 10)
{

}

// Een of meer keer uitgevoerd
do
{

}
while (x < 10);

// Gebruik de for-loop als je exact weet hoe vaak je iets moet herhalen
for (Console.WriteLine("Hoi");; Console.WriteLine("Zwaai zwaai") )
{

    if (x++ > 10) break;
    if (x == 5) continue;
    Console.WriteLine(x);
}


// Jump forward
if (true)
{

}
else if (false)
{

}

int a = 3;
switch (a)
{
    case 1:
    case 2:
        Console.WriteLine("Twee");
        break;

    default: 
        Console.WriteLine("def"); 
        break;
}