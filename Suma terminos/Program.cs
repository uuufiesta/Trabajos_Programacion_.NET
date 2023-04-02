//   Dado un valor n que calcule la suma 
// • Usar dos ciclos for anidados.
// • El proceso debe poderse repetir hasta que el usuario lo decida.

// Aqui estan las variables del programa

int n;
float fact, r;
char op;

// Cilco para repetir el programa
do
{
    // Se inicializa r en 0
    r = 0;
    // Se pide hasta que numero encontrar su suma de terminos
    Console.Write("Bienvenido, dame hasta que numero quieres encontrar su suma de terminos: ");
    n = int.Parse(Console.ReadLine());

    // 2 Ciclos para calcular la suma de terminos
    for (int i = 1; i <= n; i++)
    {
        fact = 1;
        for (int j = 1; j <= i; j++)
        {
            fact *= j;
        }

        Console.Write($"1 / {fact} + ");
        r += (1 / fact);
    }

    Console.WriteLine($"= {r}");

    // Se pregunta si se desea hacer otra consulta
    Console.WriteLine("Deseas hacer otra impresion [S]Si [N]No");
    op = char.ToUpper(char.Parse(Console.ReadLine()));
} while (op != 'N');