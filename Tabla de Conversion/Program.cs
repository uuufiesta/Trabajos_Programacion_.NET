// • Se establece un valor inicial para el tipo de cambio de peso a dólar.
// • El usuario indica un valor inicial y un valor final en pesos (validar que inicial>final)
// • El programa convierte los valores en pesos desde inicial hasta final en 
//   incrementos de uno a su correspondiente valor en dólares.
// • El proceso deberá poder repeCrse las veces que el usuario lo decida

// Imprime tabla de conversión de peso a dolar

int ini, fin, c;
float tc = 19.99f;
char resp;
do
{
    Console.Clear();
    Console.WriteLine("Imprime una tabla de conversion de peso a dolar\n");
    do
    {
        Console.Write("Inicio : ");
        ini = int.Parse(Console.ReadLine());
        Console.Write("Fin : ");
        fin = int.Parse(Console.ReadLine());
    } while (fin < ini);

    c = ini;
    Console.WriteLine(new string('-', 20));
    Console.WriteLine("Peso\tDolar");
    Console.WriteLine(new string('-', 20));
    while (c <= fin)
    {
        Console.WriteLine($"{c}\t{c / tc:f4}");
        c++;
    }

    Console.WriteLine(new string('-', 20));
    Console.Write("\nDeseas continuar (S/N) ? ");
    resp = char.ToUpper(Console.ReadLine()[0]);
} while (resp != 'N');

Console.WriteLine("\nGracias por utilizar este programa !");