// El usuario puede elegir mediante un menú
// Imprimir números pares de 2 a n y su suma
// Imprimir impares de n a 1 y su suma
// Además el proceso se repite hasta el usuario lo decide.

// Aqui estan las variables de nuestro programa

int n, op, suma, m;
char op2;

// Aqui empieza donde se realiza el procedimiento del programa
do
{
    // Se define la suma en 0 para poder reutilizar la variable siempre
    suma = 0;
    // Aqui se pide la opcion que quiere el usuario
    Console.WriteLine("Bienvenido dime que opcion deseas realizar\n" +
                      "[1]Numeros pares de 2 a n\n" +
                      "[2]Numeros impares de n a 1");
    op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            // Se pide el numero limite 
            Console.Write("Dame el numero hasta el que quieres tus numeros pares: ");
            n = int.Parse(Console.ReadLine());

            // Se hace el ciclo para imprimir los numeros y sumarlos
            for (int i = 2; i < n; i+=2)
            {
                Console.Write($"{i}, ");
                suma += i;
            }

            // Se imprime el resultado de la suma
            Console.WriteLine($"\nEl resultado de la suma de todos los numeros es: {suma}");
            break;
        case 2:
            // Se pide el numero limite 
            Console.Write("Dame el numero desde el que quieres tus numeros imapres: ");
            n = int.Parse(Console.ReadLine());

            // Si el numero es par se va a disminuir en 1 para que sea impar
            if ((m = n % 2) == 0)
            {
                n--;
            }

            // Se hace el ciclo para imprimir los numeros y sumarlos
            for (int i = n; i >= 1; i-=2)
            {
                Console.Write($"{i}, ");
                suma += i;
            }

            // Se imprime el resultado de la suma
            Console.WriteLine($"\nEl resultado de la suma de todos los numeros es: {suma}");
            break;
        default:
            Console.WriteLine("Lo siento tu opcion no es valida");
            break;
    }

    // Se pregunta si se desea hacer una nueva seleccion
    Console.WriteLine("Deseas hacer otra seleccion?\n" +
                      "[Y]Si\n" +
                      "[N]No");
    op2 = char.ToUpper(char.Parse(Console.ReadLine()));
} while (op2 != 'N');