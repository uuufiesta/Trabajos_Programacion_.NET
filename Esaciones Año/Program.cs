// Dado un numero entero entre 1 y 4, se desea mostrar con letra la estación del año:

int op;

Console.WriteLine("Bienvenido, para elegir una estacion dame un numero del 1 al 4");
op = int.Parse(Console.ReadLine());

if (op == 1)
{
    Console.WriteLine("La opcion que elegiste es [Primavera]");
}
else
{
    if (op == 2)
    {
        Console.WriteLine("La opcion que elegiste es [Verano]");
    }
    else
    {
        if (op == 3)
        {
            Console.WriteLine("La opcion que elegiste es [Otoño]");
        }
        else
        {
            if (op == 4)
            {
                Console.WriteLine("La opcion que elegiste es [Invierno]");
            }
            else
            {
                Console.WriteLine($"La opcion no es valida... {op} es un numero no valido");
            }
        }
    }
}

