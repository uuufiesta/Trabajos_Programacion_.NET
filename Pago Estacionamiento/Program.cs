// Administra el pago por estacionamiento de acuerdo a la zona

// Declaramos las variables para nuestro programa

int op;
float tasa, pago, impuesto, total;

// Desplegamos un menu y leemos la opcion del ususario
Console.WriteLine("1 - Estacionamiento Tacuba 3%");
Console.WriteLine("2 - Estacionamiento Portales 5%");
Console.WriteLine("3 - Estacionamiento Conquistadores 10%");
Console.WriteLine("4 - Estacionamiento Pajaros Caidos 15%");
Console.Write("Dame tu opcion: ");
op = int.Parse(Console.ReadLine());
Console.Write("Cual es el pago: ");
pago = float.Parse(Console.ReadLine());

// Hacemos la comparacion de la opcion y se modifica la tasa segun lo seleccionado
switch (op)
{
    case 1:
        tasa = 0.03f;
        break;
    case 2:
        tasa = 0.05f;
        break;
    case 3:
        tasa = 0.10f;
        break;
    case 4:
        tasa = 0.15f;
        break;
    default:
        Console.WriteLine("Estacionamiento no valido se cobrara el 100% extra");
        tasa = 1.00f;
        break;
}

// Realizamos las operaciones para calcular el total a pagar
impuesto = pago * tasa;
total = pago + impuesto;

string salida = string.Format($"Elegiste el estacionamiento {op}\n" +
                              $"Pagaste: {pago} por el tiempo de uso\n" +
                              $"Corresponde u  impuesto de: {impuesto}\n" +
                              $"El pago total es de: {total}");
Console.WriteLine(salida);