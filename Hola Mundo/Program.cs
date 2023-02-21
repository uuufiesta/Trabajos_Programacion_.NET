// Envia un saludo a la pantalla

string amigo = "Juan",hermano = "Pablo";

Console.WriteLine(amigo);
amigo = "Miguel";
Console.WriteLine(amigo);
Console.WriteLine($"Hola {amigo} bienvenido a C#");
Console.WriteLine($"\nMi amigo {amigo} mi hermano {hermano}");
Console.WriteLine($"{amigo.ToUpper()} {hermano.ToUpper()}");