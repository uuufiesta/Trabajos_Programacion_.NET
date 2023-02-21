// Covertiremos una temperatura en grados farenheit a grados celcius

double temperatura;

Console.WriteLine("Dame la temperatura en farenheit a convertir a grados celcius:");
temperatura = double.Parse(Console.ReadLine());
temperatura = (temperatura - 32) * (5 / 9);

Console.WriteLine($"La temperatura en grados celcius es: {temperatura}");