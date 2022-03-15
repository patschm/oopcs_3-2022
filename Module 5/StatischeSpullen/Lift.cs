namespace StatischeSpullen
{
    internal class Lift
    {
        public int CurrentFloor { get; set; }

        public void Call(int etageNummer)
        {
            Console.WriteLine($"De lif spoedt zich naar de {etageNummer}e verdieping");
            CurrentFloor = etageNummer;
        }
    }
}