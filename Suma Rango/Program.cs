//  Diseñar un programa usando funciones, para sumar un rango de números 
// flotantes especificado por un inicio y un final

// Aqui se encuentran las funciones del programa
// Esta funcion suma los numeros comenzando desde el numero que queremos iniciar
// hasta el que queremos que pare dado por el usuario

float Suma(float begg, float end)
{
    float cont = 0;
    for (float i = begg; i < end; i++)
    {
        cont += i;
    }

    return cont;
}

// Aqui se encuentran las variables del programa
float begg, end;

do
{
    Console.Write("Dame el numero desde el cual iniciara el conteo: ");
    begg = float.Parse(Console.ReadLine());
    Console.Write("Dame el numero hasta el cual sumara: ");
    end = float.Parse(Console.ReadLine());
    if (end < begg)
    {
        Console.WriteLine("El numero del cual inicias no puede ser mayor que el que terminas");
    }
} while (end < begg);

Console.WriteLine($"La suma de la secuencia de los numeros es: {Suma(begg, end):n2}");