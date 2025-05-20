using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("31 987455441", "SId2d46WWD6ds6cjlk", "1100", 64);
Iphone iphone = new Iphone("11 998745544", "gId2d46jAXAds6cWlk", "15", 512);

Console.WriteLine("\n");
Console.WriteLine("Número do Nokia: " + nokia.Numero);
nokia.InstalarAplicativo("DIO");

Console.WriteLine("\n");

Console.WriteLine("Número do Iphone: " + iphone.Numero);
iphone.InstalarAplicativo("DIO");
Console.WriteLine("\n");
