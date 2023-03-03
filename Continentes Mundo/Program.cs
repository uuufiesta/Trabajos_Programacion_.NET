// Dado un número entero entre 1 y 6 que corresponde a un continente del mundo,
// escribir su nombre: 1 Asia, 2 África, 
// 3 América del Norte, 4 América del Sur, 5 Antártida, 6 Europa
// Si el número no está en el rango especificado, mostrar 
// un mensaje de error.

// Aqui estan las variables de nuestro programa
int op;

// Aqui se solicitan los datos
Console.WriteLine("Bienvenido al programa de los continentes dame un numero del 1 al 6");
op = int.Parse(Console.ReadLine());

// Aqui se hace la comparacion de los datos
switch (op)
{
    case 1:
        Console.WriteLine($"El numero {op} corresponde al continente: Asia");
        break;
    case 2:
        Console.WriteLine($"El numero {op} corresponde al continente: Africa");
        break;
    case 3:
        Console.WriteLine($"El numero {op} corresponde al continente: America del norte");
        break;
    case 4:
        Console.WriteLine($"El numero {op} corresponde al continente: America del sur");
        break;
    case 5:
        Console.WriteLine($"El numero {op} corresponde al continente: Antartida");
        break;
    case 6:
        Console.WriteLine($"El numero {op} corresponde al continente: Europa");
        break;
    default:
        Console.WriteLine("Tu opcion no es valida");
        break;
}