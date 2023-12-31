using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia tijolao = new Nokia("90028922", "tijolao", "1111111", 1000);
tijolao.Ligar();
tijolao.ReceberLigacao();
tijolao.InstalarAplicativo("Instagram");

Iphone iphone15 = new Iphone("99387236", "Iphone 15", "12323", 128);
iphone15.Ligar();
iphone15.ReceberLigacao();
iphone15.InstalarAplicativo("Google");
