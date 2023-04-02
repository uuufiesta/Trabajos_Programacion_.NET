//  Imprimir las tablas de multiplicar desde la tabla del 1, hasta la tabla n
//  Imprimir cada una de esas tablas desde 1 hasta m

// Aqui estan las variables del programa

int n, m;
char op;

// Ciclo do while para la repeticion del programa
do
{
    // Se solicitan los datos n el numero de tablas m el maximo de tablas
    Console.Write("Bienvenido, dame hasta que tabla deseas que lleguen tus tablas de multiplicar: ");
    n = int.Parse(Console.ReadLine());
    Console.Write("Dame hasta que numero quieres que llegue cada tabla: ");
    m = int.Parse(Console.ReadLine());

    // 2 ciclos anidados para imprimir las tablas y hacer las multiplicaciones
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine("-------------------------");
        for (int j = 1; j <= m; j++)
        {
            Console.WriteLine($"{i} X {j} = {i * j}");
        }
    }

    // Se pregunta si se desea hacer otra consulta
    Console.WriteLine("Deseas hacer otra impresion de tablas [S]Si [N]No");
    op = char.ToUpper(char.Parse(Console.ReadLine()));
} while (op != 'N');