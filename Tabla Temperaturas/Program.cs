// Se desea calcular la temperatura convertida de grados centígrados a grados farenheit de un rango de valores 
// introducidos por el usuario, es decir el usuario introduce la temperatura inicial y la temperatura final en grados 
// centígrados y el programa realiza la conversión a farenheit incrementando el valor inicial en 1, hasta llegar al 
// valor final. Se deberá validar el rango, es decir Final no puede ser menor a Inicial. El proceso debe de poder 
// repetirse hasta que el usuario lo decida

// Aqui se declaran las variables de nuestro programa

int inicio, fin, count;
char op;

// Aqui inicia la ejecucion del programa
do
{
    Console.Clear();
    Console.WriteLine("Imprime una tabla de conversion de temperatura de celcius a farenheit\n");
    // Se pide la temperatura inicial y final y se verifica que la final sea mas grande que la inicial
    do
    {
        Console.Write("Temperatura inicial : ");
        inicio = int.Parse(Console.ReadLine());
        Console.Write("Temperatura final : ");
        fin = int.Parse(Console.ReadLine());
    } while (fin < inicio);

    // Se imprime el titulo de la tabla
    count = inicio;
    Console.WriteLine(new string('-', 20));
    Console.WriteLine("Celcius\tFarenheit");
    Console.WriteLine(new string('-', 20));
    // Se imprimen los valores de la tabla y se lleva un conteo
    while (count <= fin)
    {
        Console.WriteLine($"{count}\t{(count * 1.8) + 32:f4}");
        count++;
    }

    // Se imprime el final de la tabla y se pregunta si se desea imprimir una nueva
    Console.WriteLine(new string('-', 20));
    Console.Write("\nDeseas continuar (S/N) ? ");
    op = char.ToUpper(Console.ReadLine()[0]);
} while (op != 'N');