// • Se desean imprimir los impares de forma descendente de n a 1
// • Se desea al mismo tiempo calcular la suma de esos números
// • El proceso deberá repetirse hasta que el usuario lo decida

// Aqui declaramos las variables de nuestro programa

int suma, n2, ctrl;
char op = 'Y';


// Aqui hacemos el proceso de nuestro programa contando la repeticion
while (op == 'Y')
{
    // Se van a poner en 0 las variables de conteo para cuando se desea hacer otra sucesion vuelvan al valor original
    n2 = 0;
    suma = 0;
    // Se solicita el numero a hacerle sucesion
    Console.Clear();
    Console.Write("Bienvenido, hasta que numero deseas que se impriman los numeros impares: ");
    n2 = int.Parse(Console.ReadLine());
    // Se hace el ciclo para que imprima los numeros
    while (n2 >= 1)
    {
        // Se obtiene el residuo si es cero significa que es par
        ctrl = n2 % 2;
        if (n2 == 0)
        {
            
        }
        else if (ctrl != 0)
        {
            suma += n2;
            Console.Write($"{n2}, ");
        }

        n2--;
    }
    Console.WriteLine($"La suma de todos los impares es: {suma}");
    // Se pregunta si se hara otra sucesion para repetir el programa o no
    Console.WriteLine("Deseas hacer otra sucesion\n" +
                      "[Y]Si\n" +
                      "[N]No");
    op = Char.ToUpper(char.Parse(Console.ReadLine()));
}

Console.WriteLine("El programa ha finalizado...");