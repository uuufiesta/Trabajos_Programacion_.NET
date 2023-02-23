/*
Calcular la fuerza, masa o aceleración, según lo elija el usuario, de acuerdo a la 
2da ley de newton
*/

// Se declaran las variables para nuestro programa

float fuerza, masa, aceleracion;
int op;

//Se crea un menu para la interaccion
Console.WriteLine("Bienvenido al programa para la segunda ley de newton");
Console.WriteLine("Para obtener fuerza teclea [1]");
Console.WriteLine("Para obtener masa teclea [2]");
Console.WriteLine("Para obtener aceleracion teclea [3]");

//Se obtiene la opcion del usuario
op = int.Parse(Console.ReadLine());

//Se hace la comparacion de la opcion, se piden los datos necesarios y se realiza la operacion correspondiente
if (op == 1)
{
    Console.WriteLine("Seleccionaste la opcion para obtener fuerza");
    Console.WriteLine("Dame el valor de la masa:");
    masa = float.Parse(Console.ReadLine());
    Console.WriteLine("Dame el calor de la aceleracion");
    aceleracion = float.Parse(Console.ReadLine());

    fuerza = masa * aceleracion;
    Console.WriteLine($"El valor de la fuerza de un objeto de masa: {masa}\n" +
                      $"Que tiene una aceleracion de: {aceleracion}\n" +
                      $"Es: {fuerza}");
}

if (op == 2)
{
    Console.WriteLine("Seleccionaste la opcion para obtener masa");
    Console.WriteLine("Dame el valor de la fuerza:");
    fuerza = float.Parse(Console.ReadLine());
    Console.WriteLine("Dame el calor de la aceleracion");
    aceleracion = float.Parse(Console.ReadLine());

    masa = fuerza / aceleracion;
    Console.WriteLine($"El valor de la masa de un objeto con fuerza: {fuerza}\n" +
                      $"Que tiene una aceleracion de: {aceleracion}\n" +
                      $"Es: {masa}");
}

if (op == 3)
{
    Console.WriteLine("Seleccionaste la opcion para obtener aceleracion");
    Console.WriteLine("Dame el valor de la masa:");
    masa = float.Parse(Console.ReadLine());
    Console.WriteLine("Dame el valor de la fuerza:");
    fuerza = float.Parse(Console.ReadLine());

    aceleracion = fuerza / masa;
    Console.WriteLine($"El valor de la aceleracion de un objeto de masa: {masa}\n" +
                      $"Que tiene una fuerza de: {fuerza}\n" +
                      $"Es: {aceleracion}");
}

if (op < 1 || op > 3)
{
    Console.WriteLine($"La opcion: {op} no es una opcion valida");
}