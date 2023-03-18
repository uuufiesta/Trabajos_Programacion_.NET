// Diseñe un programa que integre los dos anteriores mediante un menú debe 
// permitir al usuario:
// imprimir números de 1 a n
// imprimir los números de n a 1
// El proceso se debe repetir hasta que lo determine el usuario

// Aqui se encuentran las variables de nuestro programa

int n, i, op;
char op2;


// Aqui se realiza la ejecucion del programa
do
{
    // Aqui se pregunta por la opcion que se decea hacer
    Console.WriteLine("Bienvenido que opcion de las siguientes deseas hacer\n" +
                      "[1]Modo de conteo ascendente\n" +
                      "[2]Modo de conteo descendente");
    op = int.Parse(Console.ReadLine());
    // Se hace unswitch para validar las opciones
    switch (op)
    {
        case 1:
            // Aqui se solicita el numero maximo a imprimir
            Console.WriteLine("Hasta que numero quieres que se impriman los numeros de 1 en 1: ");
            n = int.Parse(Console.ReadLine());

            // Aqui se hace el ciclo para la impresion
            for (i = 0; i < n; i++)
            {
                Console.Write($"{i + 1}, ");
            }

            Console.WriteLine("");
            break;
        case 2:
            // Aqui se solicita el numero maximo a decrementar
            Console.WriteLine("Desde que numero quieres que se impriman los numeros de 1 en 1: ");
            n = int.Parse(Console.ReadLine());

            // Aqui se hace el ciclo para la impresion
            for (i = n; i >= 1; i--)
            {
                Console.Write($"{i}, ");
            }

            Console.WriteLine("");
            break;
        default:
            Console.WriteLine("Lo siento tu opcion no es valida");
            break;
    }

    // Se pregunta si se desea hacer una nueva seleccion
    Console.WriteLine("Deseas hacer otra seleccion?\n" +
                      "[Y]Si\n" +
                      "[N]No");
    op2 = char.ToUpper(char.Parse(Console.ReadLine()));
} while (op2 != 'N');

Console.WriteLine("Fin del programa");