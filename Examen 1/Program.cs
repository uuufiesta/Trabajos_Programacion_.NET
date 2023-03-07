// Aqui se va a realizar el elxamen numero 1

void Menu()
{
    Console.WriteLine(
        "Bienvenido al enevento de la universidad patito se muestran las opciones para la compra de tu entrada:");
    Console.WriteLine("Estos son los precios segun tu posicion en la universidad\n" +
                      "[1]Alumno $100\n" +
                      "[2]Trabajador $200\n" +
                      "[3]Docente $500");
    Console.WriteLine("Estos son los precios de los paquetes\n" +
                      "[1]Solo conferencias $600\n" +
                      "[2]Con eventos sociales $800\n" +
                      "[3]Con kit de acceso $900");
    Console.WriteLine("Se aplicara un descuento a partir de los 5000 en tu compra\n" +
                      "Alumno 20%\n" +
                      "Trabajador 10%\n" +
                      "Docente 5%\n\n\n");
}

// Aqui se encuentran las variables de nuestro programa
int user, pack, cantidad;
float total = 0, costouser = 0, costopack = 0, subtot;
string tipou="", tipop="";

// Aqui se solicitan los datos al usuario
Menu();
Console.WriteLine("Cual es tu posicion dentro de la universidad\n" +
                  "[1]Alumno $100\n" +
                  "[2]Trabajador $200\n" +
                  "[3]Docente $500\n");
user = int.Parse(Console.ReadLine());
switch (user)
{
    case 1:
        costouser = 100;
        tipou = "Alumno";
        break;
    case 2:
        costouser = 200;
        tipou = "Trabajador";
        break;
    case 3:
        costouser = 500;
        tipou = "Docente";
        break;
    default:
        Console.WriteLine("Tu opcion no es valida");
        break;
}
Console.WriteLine("Cual es el paquete que deseas para el evento\n" +
                  "[1]Solo conferencias $600\n" +
                  "[2]Con eventos sociales $800\n" +
                  "[3]Con kit de acceso $900\n");
pack = int.Parse(Console.ReadLine());
switch (pack)
{
    case 1:
        costopack = 600;
        tipop = "Solo conferencias";
        break;
    case 2:
        costopack = 800;
        tipop = "Con eventos sociales";
        break;
    case 3:
        costopack = 900;
        tipop = "Con kit de acceso";
        break;
    default:
        Console.WriteLine("Tu opcion no es valida");
        break;
}

Console.WriteLine("Cual es el numero de cantidad de entradas que vas a comprar: ");
cantidad = int.Parse(Console.ReadLine());

// Aqui se calcula el precio de todo el paquete
subtot = (costouser + costopack) * cantidad;
if (subtot > 5000)
{
    switch (user)
    {
        case 1:
            total = subtot - (subtot * 0.20f);
            break;
        case 2:
            total = subtot - (subtot * 0.10f);
            break;
        case 3:
            total = subtot - (subtot * 0.05f);
            break;
        default:
            Console.WriteLine("Tu opcion no es valida por lo que no se aplica ningun descuento");
            break;
    }
}
else
{
    Console.WriteLine("No se esta aplicando ningun descuento");
    total = subtot;
}

Console.WriteLine($"El tipo de boleto que compraste fue {tipou} y con el paquete {tipop}, compraste {cantidad} boletos\n" +
                  $"Donde el precio fue {subtot:C} y el total con el descuento es {total:C}");