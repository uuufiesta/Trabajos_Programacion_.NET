// Calcularemos la hipotenusa de un triangulo

double lad1, lad2, hipo;

Console.WriteLine("Dame el primer lado del triangulo:");
lad1 = double.Parse(Console.ReadLine());
Console.WriteLine("Dame el segundo lado del triaungulo");
lad2 = double.Parse(Console.ReadLine());

hipo = Math.Sqrt((lad1*lad1)+(lad2*lad2));

Console.WriteLine($"El valor de la hipotenusa del triangulo de lados {lad1} y {lad2} es: {hipo}");