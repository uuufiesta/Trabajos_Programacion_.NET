// 

// Aqui inician las funciones del programa
// Funcion que se encarga de mostrar el menu y leer la opcion que necesitamos

int Menu()
{
    Console.Clear();
    Console.WriteLine("Mostrar elementos del arreglo.............. [1]");
    Console.WriteLine("Suma y promedio de elementos del arreglo... [2]");
    Console.WriteLine("Mayor y menor del arreglo.................. [3]");
    Console.WriteLine("Buscar elementos del arreglo............... [4]");
    Console.WriteLine("Salir...................................... [5]");
    Console.Write("\nQue opcion vas a elegir: ");

    return int.Parse(Console.ReadLine());
}

// Funcion se encarga de obtener datos para el arreglo
double[] LeerNums()
{
    // Variables de la funcion
    // op decide si se siguen introduciendo datos
    char op;
    const int max = 100;
    double[] arrayAssist = new double[max];
    // Variable de conteo para avanzar en las posiciones del arreglo
    int i = 0;

    // Ciclo para la introduccion indefinidad de datos hasta que el ususario decida
    do
    {
        Console.WriteLine("Estamos tomando elementos del arreglo\n" +
                          "Presiona una tecla para continuar");
        Console.ReadLine();
        Console.Clear();
        // Se solicita el numero a introducir al arreglo

        Console.Write("Dame el numero que quieras ingresar al arreglo: ");
        arrayAssist[i] = double.Parse(Console.ReadLine());

        // Se pregunta si se quiere seguir introduciendo datos
        Console.WriteLine("Quieres seguir añadiendo datos al arreglo\n" +
                          "[S]Si\n" +
                          "[N]No");
        op = char.ToUpper(char.Parse(Console.ReadLine()));

        // Aumenta la posicion del arreglo (i)
        i++;
    } while (op != 'N');

    return arrayAssist;
}

// Funcion para mostrar el contenido del arreglo
int MostrarArray(double[] arrayAssist)
{
    for (int i = 0; i < arrayAssist.Length; i++)
    {
        if (arrayAssist[i] == 0)
        {
            return i - 1;
        }
        else
            Console.Write($"[{arrayAssist[i]}]");
    }

    return 99;
}

// Funcion que suma los elementos del arreglo
double Suma(double[] arrayAssist, int n)
{
    double suma = 0;
    for (int i = 0; i < n; i++)
    {
        suma += arrayAssist[i];
    }

    return suma;
}

// Funcion para obtener el promedio de los numeros del arreglo
double Prom(double sum, int n)
{
    return sum / n;
}

// Encontraremos el numero maximo en el arreglo
double Maximo(double[] arrayAssist, int n)
{
    double max = arrayAssist[0];
    for (int i = 1; i <= n; i++)
    {
        if (arrayAssist[i] > max)
        {
            max = arrayAssist[i];
        }
    }

    return max;
}

// Funcion para encontrar el numero minimo en el arreglo
double Minimo(double[] arrayAssist, int n)
{
    double max = arrayAssist[0];
    for (int i = 1; i <= n; i++)
    {
        if (arrayAssist[i] < max)
        {
            max = arrayAssist[i];
        }
    }

    return max;
}

// Funcion para buscar un elemento en el arreglo
int Buscar(double[] arrayuAssist, double varx, int n)
{
    for (int i = 0; i < n; i++)
    {
        if (varx == arrayuAssist[i])
        {
            return i;
        }
    }

    return -1;
}

// Aqui terminan las funciones del programa
// --------------------------------------------
// Aqui inicia encuentra nuestro programa

// Aqui estan las variables de nuestro programa
int op, n = 0, posi;
double[] arrayBase;
double sum;

op = Menu();
Console.WriteLine("\nSe te va a solicitar llenar el arreglo a continuacion");
Console.WriteLine("Presione una tecla para continuar");
Console.ReadLine();


arrayBase = LeerNums();

do
{
    

    switch (op)
    {
        case 1:
            n = MostrarArray(arrayBase);
            break;
        case 2:
            sum = Suma(arrayBase, n);
            Console.WriteLine($"La suma de los elementos es: {sum}\n" +
                              $"Y el promedio es: {Prom(sum, n + 1)}");
            break;
        case 3:
            Console.WriteLine($"El valor maximo en el arreglo es: {Maximo(arrayBase,n)}\n" +
                              $"El valor minimo en el arreglo es: {Minimo(arrayBase,n)}");
            break;
        case 4:
            Console.Write("Dame el numero a buscar en el arreglo: ");
            posi = Buscar(arrayBase, double.Parse(Console.ReadLine()), n);
            if (posi == -1)
            {
                Console.WriteLine("No se encontro una coincidencia");
            }
            else
                Console.WriteLine($"El numero {arrayBase[posi]} se encontro en la posicion {posi}");

            break;
        case 5:
            Console.Clear();
            Console.WriteLine("Gracias por usar el programa, presiona una tecla");
            Console.ReadLine();
            break;
        default:
            Console.WriteLine("Opcion no valida");
            break;
    }
    
    Console.WriteLine("\nPresiona una tecla para continuar");
    Console.ReadLine();
    op = Menu();
} while (op != 5);