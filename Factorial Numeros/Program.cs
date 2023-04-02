//  Calcular el factorial de n números
//  Usar dos ciclos for anidados.
//  El proceso debe poderse repetir hasta que el usuario lo decida.

// Aqui estan las variables del programa
int n, fact;
char op;

// Cilco para repetir el programa
do
{
    // Se pide hasta que numero encontrar su factorial
    Console.Write("Bienvenido, dame hasta que numero quieres encontrar su factorial: ");
    n = int.Parse(Console.ReadLine());

    // 2 Ciclos para calcular el factorial
    for (int i = 1; i <= n; i++)
    {
        fact = 1;
        Console.Write($"{i}! = ");
        
        for (int j = 1; j <= i; j++)
        {
            fact *= j;
        }
        Console.WriteLine($"{fact}");
    }
    // Se pregunta si se desea hacer otra consulta
    Console.WriteLine("Deseas hacer otra impresion [S]Si [N]No");
    op = char.ToUpper(char.Parse(Console.ReadLine()));
} while (op != 'N');