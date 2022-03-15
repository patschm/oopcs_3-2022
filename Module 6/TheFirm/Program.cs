

using TheFirm;

ACME acme = new ACME();
Wik wk = new Wik();
Johan jh = new Johan();
Bokito bok = new Bokito();

acme.Hire(wk);
acme.Hire(jh);
acme.Hire(bok);


acme.Start();