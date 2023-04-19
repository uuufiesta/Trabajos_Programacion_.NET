// Se desea imprimir la secuencia de términos, el número de renglones que el usuario desee y su suma

// Aqui estan las variables del programa

int n, sum = 1, cons = 1, sum2 = 0;
char op;

// Ciclo para repetir el programa
do
{
    Console.Clear();

    // Pedimos la longitud de la sucecion a sumar
    Console.Write("Bienvenido, cuantas veces quieres que se sume la sucesion de 1's: ");
    n = int.Parse(Console.ReadLine());
    
    // Ciclo for para imprimir y hacer la sucesion
    for (int i = 1; i <= n; i++)
    {
        Console.Write($"{sum} + ");
        cons *= 10;
        sum += cons;
        sum2 += sum;
    }
    Console.WriteLine();
    Console.WriteLine($"La suma es: {sum2}");

    // Se pregunta si se desea hacer otra consulta
    Console.WriteLine("Deseas hacer otra impresion [S]Si [N]No");
    op = char.ToUpper(char.Parse(Console.ReadLine()));
} while (op != 'N');