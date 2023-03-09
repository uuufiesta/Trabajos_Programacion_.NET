// Imprime numeros de 1 a 100

int c, n, p;

Console.WriteLine("Hasta donde se va a contar: ");
n = int.Parse(Console.ReadLine());
Console.WriteLine("De cuantos será el aumento");
p = int.Parse(Console.ReadLine());
c = n;

while (c <= 100)
{
    Console.WriteLine($"{c}");
    c += p;
}