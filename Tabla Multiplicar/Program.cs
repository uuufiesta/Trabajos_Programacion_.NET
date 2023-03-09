// Imprimir la tabla de multiplicar que el usuario pida hasta donde lo pida

int i = 0, tabla, numero;

Console.Write("Cual tabla de multiplicar quieres: ");
tabla = int.Parse(Console.ReadLine());
Console.Write("Hasta donde quieres la tabla: ");
numero = int.Parse(Console.ReadLine());

while (i < numero)
{
    Console.WriteLine($"{tabla,3} x {i,3} = {tabla * i,4}");
    i++;
}