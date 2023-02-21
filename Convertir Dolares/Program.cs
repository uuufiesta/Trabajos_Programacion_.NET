// Obtendremos el equivalente en dolares de una cantidad en pesos mexicanos 18.44 por dolar

double peso, dolar;

Console.WriteLine("Dame la cantidad de pesos que deseas convertir:");
peso = double.Parse(Console.ReadLine());

dolar = peso / 18.44;

Console.WriteLine($"La conversion dem {peso} pesos a dolares es: {dolar} dolares");