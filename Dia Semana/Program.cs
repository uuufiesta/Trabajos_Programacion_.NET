// Dado un numero entre 1 y 7 imprime el dia de la semana

// Declaramos la variable de nuestro programa
int dia;

// Solicitamos el numero de dia al usuario
Console.WriteLine("Dado un numero entre 1 y 7 imprime el dia de la semana");
Console.Write("Dame el dia con numero: ");
dia = int.Parse(Console.ReadLine());

// Hacemos la comparacion de la opcion que se selecciono y se mostrara el dia correspondiente
switch (dia)
{
    case 1:
        Console.WriteLine("Lunes");
        break;
    case 2:
        Console.WriteLine("Martes");
        break;
    case 3:
        Console.WriteLine("Miercoles");
        break;
    case 4:
        Console.WriteLine("Jueves");
        break;
    case 5:
        Console.WriteLine("Viernes");
        break;
    case 6:
        Console.WriteLine("Sabado");
        break;
    case 7:
        Console.WriteLine("Domingo");
        break;
    default:
        Console.WriteLine("No es un dia valido");
        break;
}