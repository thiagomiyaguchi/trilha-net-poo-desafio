using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia");
Smartphone nokia = new Nokia("123","Tijolão", "321", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Tinder");

Console.WriteLine("Iphone");
Smartphone iPhone = new Iphone("456","5S", "888", 128);
iPhone.Ligar();
iPhone.InstalarAplicativo("Tinder");