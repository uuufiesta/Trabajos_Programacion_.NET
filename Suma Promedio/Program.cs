//  El usuario introduce una cantidad n de números.
// • Se calcula y muestra la suma y promedio de estos números.
// • Además el proceso se repite hasta el usuario lo decide

// Aqui estn las variables del programa
int n;
float suma, prom;
char op;

do
{
    // Aqui se establece suma u promedio al valor inicial 0
    suma = prom = 0;
    Console.Write("Bienvenido cuantas calificaciones deseas ingresar: ");
    n = int.Parse(Console.ReadLine());

    // Aqui se registran las calificaciones
    for (int i = 0; i < n; i++)
    {
        Console.Write("Dame la calificacion a ingresar: ");
        suma += float.Parse(Console.ReadLine());
    }
    // Se saca el promedio
    prom = suma / n;
    
    // Se imprimen resultados
    Console.WriteLine($"De acuerdo con el numero de calificaciones: {n}\n" +
                      $"La suma de las calificaciones es: {suma}\n" +
                      $"El promedio resultante es: {prom}");
    
    // Se pregunta por otra consulta
    Console.WriteLine("Deseas hacer otra consulta?\n" +
                      "[Y]Si\n" +
                      "[N]No");
    op = char.ToUpper(char.Parse(Console.ReadLine()));
} while (op != 'N');