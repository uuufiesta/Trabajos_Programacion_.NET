// Utiliza los operadores de asignacion para efectuar diversas operaciones

Console.Clear();
Console.WriteLine("Dame un numero");

float num = float.Parse(Console.ReadLine());

Console.WriteLine($"El numero es: {num}");
Console.WriteLine($"Incrementar en 1: {++num}");
Console.WriteLine($"Sumar 50: {num+=50}");
Console.WriteLine($"Restar 35: {num-=35}");
Console.WriteLine($"Multiplicar por 15: {num*=15}");
Console.WriteLine($"Dividir entre 4: {num/=4}");
Console.WriteLine($"Decrementar en 1: {--num}");
