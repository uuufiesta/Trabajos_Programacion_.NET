// Aqui esta el programa para el examen 2

// Funcion menu que nos permite hacer una eleccion

int Menu()
{
    Console.Clear();
    Console.WriteLine("Mostrar elementos del arreglo.............. [1]");
    Console.WriteLine("Promedio y mayores calificaciones.......... [2]");
    Console.WriteLine("Complemento a 100 de cada calificacion..... [3]");
    Console.WriteLine("Contar las calificaciones.................. [4]");
    Console.WriteLine("Salir...................................... [5]");
    Console.Write("\nQue opcion vas a elegir: ");

    return int.Parse(Console.ReadLine());
}

// Funcion se encarga de obtener datos para el arreglo
double[] LeerNums(int delim)
{
    // Variables de la funcion
    const int max = 100;
    double[] arrayAssist = new double[max];
    
    // Ciclo para la introduccion indefinidad de datos hasta que el ususario decida
    for (int i = 0; i < delim; i++)
    {
        // Se solicita el numero a introducir al arreglo

        Console.Write($"Dame la {i} calificacion: ");
        arrayAssist[i] = double.Parse(Console.ReadLine());
        
    }

    return arrayAssist;
}

// Funcion para mostrar el contenido del arreglo
void MostrarArray(double[] arrayAssist, int delim)
{
    for (int i = 0; i < delim; i++)
    {
        Console.Write($"[{arrayAssist[i]}]");
    }
}

// Funcion que suma los elementos del arreglo
double Promedio(double[] arrayAssist, int delim)
{
    double suma = 0;
    for (int i = 0; i < delim; i++)
    {
        suma += arrayAssist[i];
    }

    return suma / delim;
}

void Mayo(double[] arrayAssist, double varx,int delim)
{
    for (int i = 0; i < delim; i++)
    {
        if (arrayAssist[i] > varx)
        {
            Console.Write($"{arrayAssist[i]} ");
        }
    }
}

// Funcion para imprimir el complemento a 100 del arreglo
void Complemento(double[] arrayAssist, int delim)
{
    
    for (int i = 0; i < delim; i++)
    {
        Console.Write($"{100 - arrayAssist[i]} ");
    }
    Console.WriteLine();
}

// Funcion para buscar un elemento en el arreglo
int Buscar(double[] arrayuAssist, double varx, int delim)
{
    int cont = 0;
    for (int i = 0; i < delim; i++)
    {
        if (varx == arrayuAssist[i])
        {
            cont++;
        }
    }

    return cont;
}


// Aqui terminan las funciones del programa
// --------------------------------------------
// Aqui inicia encuentra nuestro programa

// Aqui estan las variables de nuestro programa
int op, posi;
double[] arrayBase;
double calif;
int delim;

op = Menu();
Console.WriteLine("\nSe te va a solicitar las calificaciones");
Console.WriteLine("Presione una tecla para continuar");
Console.ReadLine();

Console.Write("Dame el total de calificaciones a introducir: ");
delim = int.Parse(Console.ReadLine());
arrayBase = LeerNums(delim);

do
{
    
    switch (op)
    {
        case 1:
            Console.WriteLine("Los elementos del arreglo son: ");
            MostrarArray(arrayBase, delim);
            break;
        case 2:
            Console.WriteLine($"El promedio de las calificaciones es:\n{Promedio(arrayBase,delim)}");
            Console.WriteLine("Las calificaciones mayores al promedio son: ");
            Mayo(arrayBase,Promedio(arrayBase,delim),delim);
            break;
        case 3:
            Console.WriteLine("El complemento a 100 es: ");
            Complemento(arrayBase,delim);
            break;
        case 4:
            Console.Write("Dame la calificacion a buscar: ");
            calif = double.Parse(Console.ReadLine());
            posi = Buscar(arrayBase, calif, delim);
            if (posi == 0)
            {
                Console.WriteLine("No se encontro una coincidencia");
            }
            else
                Console.WriteLine($"El la calificacion {calif} se encontro {posi} veces");

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