using Infrac;
using Philips;
using Heras;
using DoomsdayPreppers;


DetectieLus lus = new DetectieLus();
Hek poort = new Hek();  
Valkuil kuil = new Valkuil();
Lamp tl = new Lamp();

lus.Detecting += poort.Open;
lus.Detecting += kuil.Opent;
lus.Detecting += tl.Aan;

lus.Connect(poort);
lus.Connect(kuil);
lus.Connect(tl);

lus.Detect();


