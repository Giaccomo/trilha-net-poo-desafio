using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456", "Modelo Prem","154654654444",64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
Console.WriteLine("");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Nokia("987654", "Modelo Regu","777774444",256);
iphone.Ligar();
iphone.InstalarAplicativo("Telegran");

