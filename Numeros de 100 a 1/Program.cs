// Imprime numeros de 100 a 1

int c, n, p;

Console.WriteLine("Desde donde se va a contar: ");
n = int.Parse(Console.ReadLine());
Console.WriteLine("De cuantos será el decremento");
p = int.Parse(Console.ReadLine());
c = n;

while (c >= 1)
{
    Console.WriteLine($"{c}");
    c -= p;
}