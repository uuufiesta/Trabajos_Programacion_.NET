// Se desea imprimir la secuencia de términos armónicos el número de renglones que el usuario desee y su suma

// Aqui estan las variables del programa

int n;
float sum = 0;
char op;

// Ciclo para repetir el programa
do
{
    Console.Clear();

    // Se pide hasta que termino armonico se sumara
    Console.Write("Bienvenido, cuantas veces quieres que se haga la suma de terminos armonicos: ");
    n = int.Parse(Console.ReadLine());
    
    // Ciclo for para hacer la sucecion y suma
    for (int i = 1; i <= n; i++)
    {
        Console.Write($"1/{i} + ");
        sum += (float)1 / i;
    }

    Console.WriteLine();
    Console.WriteLine($"La suma es: {sum}");
    
    // Se pregunta si se desea hacer otra consulta
    Console.WriteLine("Deseas hacer otra impresion [S]Si [N]No");
    op = char.ToUpper(char.Parse(Console.ReadLine()));
} while (op != 'N');