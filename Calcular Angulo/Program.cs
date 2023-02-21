// Calcularemos el tercer angulo de un triangulo

double ang1, ang2, ang3;

Console.WriteLine("Dame el valor del primer angulo");
ang1 = double.Parse(Console.ReadLine());
Console.WriteLine("Dame el valor del segundo angulo");
ang2 = double.Parse(Console.ReadLine());

ang3 = 180 - (ang1 + ang2);

Console.WriteLine($"El valor del angulo faltante del triangulo es: {ang3}");