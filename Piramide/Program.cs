// Imprimir una pirámide de asteriscos usando ciclos for anidados
// El primer ciclo controla la cantidad de renglones
// El segundo ciclo controla la cantidad de asteriscos por renglón

// Aqui estan las variables del programa

int n;
char op, tipo;

// Ciclo do while para la repeticion del programa
do
{
    // Se solicitan los datos n el numero de renglones, tipo el caracter a imprimir
    Console.Write("Bienvenido, de cuantos renglones quieres tu piramide: ");
    n = int.Parse(Console.ReadLine());
    Console.Write("Cual caracter es el que quieres para tu piramide: ");
    tipo = char.Parse(Console.ReadLine());

    // 2 ciclos anidados para imprimir la piramide
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write($"{tipo}");
        }
        Console.WriteLine();
    }

    // Se pregunta si se desea hacer otra consulta
    Console.WriteLine("Deseas hacer otra impresion [S]Si [N]No");
    op = char.ToUpper(char.Parse(Console.ReadLine()));
} while (op != 'N');