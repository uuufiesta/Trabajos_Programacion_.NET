// El usuario introduce n numeros
// Se desea obtener:
// Cuantos numeros se introdujeron
// La suma de los numeros
// Cuantos fueron positivos
// Cuantos fueron negativos
// Cuantos fueron cero

// Aqui se declaran las variables del programa

int n = 0, ntot = 0, suma = 0, sump = 0, sumn = 0, sumc = 0;

// Se da un anuncio de bienvenida y la instruccion para finalizar
Console.WriteLine("Bienvenido enseguida te solicitare bastantes numeros para finalizar introduce 999");

do
{
    Console.Write("Dame un numero: ");
    n = int.Parse(Console.ReadLine());
    if (n != 999)
    {
        suma += n;
        ntot++;
        if (n > 0)
        {
            sump++;
        }
        else if (n < 0)
        {
            sumn++;
        }
        else
        {
            sumc++;
        }
    }
} while (n != 999);

Console.WriteLine($"La suma de los numeros que diste es: {suma}\n" +
                  $"El numero total de numeros fue: {ntot}\n" +
                  $"El numero total de positivos fue: {sump}\n" +
                  $"El numero total de negativos fue: {sumn}\n" +
                  $"El numero total de ceros fue: {sumc}");