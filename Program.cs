using DesafioPOO.Models;


Console.WriteLine("SmartPhone Nokia:");
Smartphone nokia = new Nokia(numero:"6578-9999", modelo:"Modelo NK53-G" ,imei:"66678990",memoria:8);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n"); 

Console.WriteLine("SmartPhone Iphone:");
Smartphone iphone = new Iphone(numero:"9870-4567", modelo:"Modelo I1899" ,imei:"09876567", memoria:16);
iphone.Ligar();
iphone.InstalarAplicativo("Linkedin");