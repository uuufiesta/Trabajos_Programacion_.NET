// ?  Diseñar un programa usando funciones, para imprimir la tabla de mulIplicar que 
// ?  el usuario decida, hasta donde lo decida

// * Empiezan las funciones del programa

void TablasM(int n, int m)
{
    for (int i = 1; i <= n; i++)
    {
        for (int j = 1; j <= m; j++)
        {
            Console.WriteLine($"{i} X {j} = {i * j}");
        }

        Console.WriteLine("\n");
    }
}

// ! Terminan las funciones del programa
// * Variables del programa
int n, m;

// * Se solicitan los datos
Console.WriteLine("Hasta que numero quieres que sean tus tablas de multiplicar: ");
m = int.Parse(Console.ReadLine());
Console.WriteLine("Cuantas tablas quieres: ");
n = int.Parse(Console.ReadLine());

// * Se llama la funcion de tipo void y se imprimen las tablas
TablasM(n, m);

Console.WriteLine("Gracias por usar el programa");