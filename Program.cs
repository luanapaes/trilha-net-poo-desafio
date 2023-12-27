using DesafioPOO.Models;
using Trilha_Net_Poo_Desafio.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

// Iphone
Console.WriteLine("--- Iphone ---");
Iphone i = new Iphone("998980000", "Iphone X", "123456", 128);

i.Ligar();
i.ReceberLigacao();
i.InstalarAplicativo("WhatsApp");

Console.WriteLine("--------------------------------------");

//Nokia
Console.WriteLine("--- Nokia ---");
Nokia n = new Nokia("921216776", "Nokia Lumia", "987654", 60);

n.Ligar();
n.ReceberLigacao();
n.InstalarAplicativo("Facebook");