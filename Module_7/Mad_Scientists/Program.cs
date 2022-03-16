

using Mad_Scientists;

WillemKlein wk = new WillemKlein();
SimonVDMeer simon  = new SimonVDMeer();

//wk.Bereken(simon.Add, 20, 22);
//wk.Bereken(simon.Subtract, 20, 22);


MathDel berekening = simon.Add;
berekening += simon.Subtract;
berekening += simon.Add;
berekening += simon.Add;
berekening += simon.Subtract;

foreach(var del in berekening.GetInvocationList())
{
    Console.WriteLine(del.Method.Name);
}


int result = berekening(1, 2);


Console.WriteLine(result);

