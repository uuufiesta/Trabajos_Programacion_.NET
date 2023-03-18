// Imprimir los números de 1 a n usando un ciclo for

// Aqui estan las variables de nuestro programa
int n;

// Aqui se solicita el numero maximo a imprimir
Console.WriteLine("Hasta que numero quieres que se impriman los numeros de 1 en 1: ");
n = int.Parse(Console.ReadLine());

// Aqui se hace el ciclo para la impresion
for (int i = 0; i < n; i++)
{
    Console.Write($"{i+1}, ");
}