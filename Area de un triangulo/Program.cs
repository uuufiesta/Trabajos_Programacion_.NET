// See https://aka.ms/new-console-template for more information

int B, A;
float Area;

Console.WriteLine("Calculando el area de un triangulo");
Console.WriteLine("Dame la base del triangulo");

B = int.Parse(Console.ReadLine());
Console.WriteLine("Dame la altura del triangulo");

A = int.Parse(Console.ReadLine());

Area = (B*A)/2;

Console.WriteLine($"El triangulo con base {B} y altura {A} tiene un area de {Area}");