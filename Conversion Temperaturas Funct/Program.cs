// ? Diseñar un programa para converIr grados Celsius a Farenheit y viceversa

// * Aqui se encuentran las funciones

// * Esta funcion convierte grados farenheit a celcius

float Celcius(float t)
{
    return (t - 32) * 5 / 9;
}

// * Esta funcion convierte grados celcius a farenheit
float Farenheit(float t)
{
    return (t * 9 / 5) + 32;
}

// * Aqui se declaran las variables del programa
int op;
float temp;

// * Se solicita la opcion y la temperatura a convertir
Console.WriteLine("Bienvenido elige una opcion de las siguientes:\n" +
                  "[1] Celcius a Farenheit\n" +
                  "[2] Farenheit a Celcius");
op = int.Parse(Console.ReadLine());
Console.Write("Dame la temperatura a convertir: ");
temp = float.Parse(Console.ReadLine());

// * Se compara la opcion y se imprime el valor segun corresponda
if (op == 1)
{
    // * Se ejecuta la funcion directamente al imprimir
    Console.WriteLine($"Los grados {temp} celcius en farenheit equivalen a {Farenheit(temp):f2} grados");
}
else if (op == 2)
{
    Console.WriteLine($"Los grados {temp} farenheit en celcius equivalen a {Celcius(temp):f2} grados");
}
else
    Console.WriteLine("Opcion no valida");