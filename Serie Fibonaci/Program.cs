// Se desean imprimir los primeros n números de la serie de fibbonaci. El proceso debe de poder repetirse hasta que 
// el usuario lo decida.

// Aqui se encuentran las variables del programa

int n1, n2, lim, n3;
char op;

// Aqui se hace la ejecucion del programa
do
{
    // Se establecen las variables para que se reinicien cada vez que hagamos uso del programa
    Console.Clear();
    n1 = 0;
    n2 = 1;
    Console.WriteLine("Bienvenido hasta que numero quieres que se realice la serie de fibonacci");
    lim = int.Parse(Console.ReadLine());
    // Se imprimen las variables en su estado original ya que siempre serán ese valor inicial
    Console.Write($"{n1}, {n2}, ");
    // Se realiza el ciclo donde se hace uso del algoritmo de la sucesion fibonacci
    do
    {
        n3 = n2;
        n2 += n1;
        n1 = n3;
        Console.Write($"{n2}, ");
    } while (n2 < lim);

    // Se pregunta si se desea hacer otra serie
    Console.WriteLine("Deseas hacer otra serie?\n" +
                      "[Y]Si\n" +
                      "[N]No");
    op = char.ToUpper(char.Parse(Console.ReadLine()));
} while (op != 'N');