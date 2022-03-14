using EigenTypes;

int dag = 3;
Console.WriteLine(dag & (int)Weekdays.Wednesday);
Weekdays day = (Weekdays)Enum.Parse(typeof(Weekdays), "Monday");
Console.WriteLine(day);