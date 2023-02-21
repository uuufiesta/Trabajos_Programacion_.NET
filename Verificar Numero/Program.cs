// Verificaremos un numero

int n;

Console.WriteLine("Dame un numero negativo, positivo o cero, tiene que ser entero");
n = int.Parse(Console.ReadLine());
if (n < 0)
{
    Console.WriteLine($"El numero {n} es negativo");
}
else
{
    if (n > 0)
    {
        Console.WriteLine($"El numero {n} es positivo");
    }
    else
    {
        Console.WriteLine($"El numero {n} es cero");
    }
}