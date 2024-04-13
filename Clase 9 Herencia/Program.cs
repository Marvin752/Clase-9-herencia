using Clase_9_Herencia.ClaseHija;

Nintendo sw = new Nintendo("Switch", 2018);
sw.EsPortatil = true;
string resultado = sw.MostratDetallesNintendo();
Console.WriteLine(resultado);

Console.WriteLine();

PlayStation pl = new PlayStation("Play 4",2013,"DualShock");
string resulps = pl.MOstrarDetallesPs();
Console.WriteLine(resulps);

Console.WriteLine();

XBOX xbo = new XBOX("Xbox One", 2013);
xbo.gamepass = true;
string sera = xbo.MostrarDetallesXbox();
Console.WriteLine(sera);