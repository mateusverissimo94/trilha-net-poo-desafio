using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero: "123456789", modelo: "Nokia 3310", imei: "IMEI123456", memoria: 16);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Iphone iphone = new Iphone(numero: "987654321", modelo: "iPhone 12", imei: "IMEI654321", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");
iphone.InstalarAplicativo("Facebook");