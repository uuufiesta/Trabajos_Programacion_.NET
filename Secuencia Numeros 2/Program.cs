// Se desea imprimir la secuencia de números mostrados el número de renglones que el usuario desee

// Aqui estan las variables del programa

int n;
char op;

// Ciclo para repetir el programa
do
{
    Console.Clear();
    // Se solicita la longitud de la piramide
    Console.Write("Bienvenido, dame el numero de renglones de tu piramide: ");
    n = int.Parse(Console.ReadLine());

    // 2 ciclos for para la impresion de la piramide
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write($"{j}");
        }

        Console.WriteLine();
    }

    // Se pregunta si se desea hacer otra consulta
    Console.WriteLine("Deseas hacer otra impresion [S]Si [N]No");
    op = char.ToUpper(char.Parse(Console.ReadLine()));
} while (op != 'N');