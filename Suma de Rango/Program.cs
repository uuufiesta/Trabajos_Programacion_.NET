// ? Diseñar un programa usando funciones, para sumar un rango de números 
// ? flotantes especificado por un inicio y un final

// * Empiezan las funciones del programa

float Rango(float beg, float end)
{
    float sum = 0;
    for (float i = beg; i <= end; i++)
    {
        sum += i;
    }

    return sum;
}

// ! Finalizan las funciones
// * Se declaran las variables del programa
float beg, end;

// * Ciclo para solicitar los datos y evitar errores
do
{
    Console.Write("Dame el inicio del rango: ");
    beg = float.Parse(Console.ReadLine());
    Console.Write("Dame el fin del rango: ");
    end = float.Parse(Console.ReadLine());
} while (beg > end);

// * Se llama la funcion e imprime el resultado
Console.WriteLine($"La suma del rango es {Rango(beg, end)}");