using RadioAmateur;


RadioStation r538 = new RadioStation();

r538.subscribers += OntvangsMethods.ViaPostduif;
r538.subscribers += OntvangsMethods.ViaKabel;
r538.subscribers += OntvangsMethods.ViaInternet;
r538.subscribers += OntvangsMethods.ViaEther;
r538.subscribers += OntvangsMethods.ViaSms;
r538.subscribers += OntvangsMethods.ViaPostduif;
r538.subscribers += OntvangsMethods.ViaKabel;
r538.subscribers += OntvangsMethods.ViaInternet;
r538.subscribers += OntvangsMethods.ViaEther;
r538.subscribers += OntvangsMethods.ViaSms;
r538.subscribers += OntvangsMethods.ViaPostduif;
r538.subscribers += OntvangsMethods.ViaKabel;
r538.subscribers += OntvangsMethods.ViaInternet;
r538.subscribers += OntvangsMethods.ViaEther;
r538.subscribers += OntvangsMethods.ViaSms;


//r538.subscribers("Hahaha. Gehackt");

r538.Broadcast();