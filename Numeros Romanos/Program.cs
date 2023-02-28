// Covierte un numero entero de entre 1 y 10 a numeros romanos

// Declaramos la variable de nuestro programa
int num;

// Solicitamos el numero que se mostrara en su version en romano
Console.Write("Dame el numero entre 1 y 10 a representar en romano: ");
num = int.Parse(Console.ReadLine());

// Hacemos la comparacion de la opcion y mostramos su equivalente en numero romano
switch (num)
{
    case 1:
        Console.WriteLine("I");
        break;
    case 2:
        Console.WriteLine("II");
        break;
    case 3:
        Console.WriteLine("III");
        break;
    case 4:
        Console.WriteLine("IV");
        break;
    case 5:
        Console.WriteLine("V");
        break;
    case 6:
        Console.WriteLine("VI");
        break;
    case 7:
        Console.WriteLine("VII");
        break;
    case 8:
        Console.WriteLine("VIII");
        break;
    case 9:
        Console.WriteLine("IX");
        break;
    case 10:
        Console.WriteLine("X");
        break;
    default:
        Console.WriteLine("Tu numero no es valido");
        break;
}