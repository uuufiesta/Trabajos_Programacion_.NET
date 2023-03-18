// Imprimir los números de n a 1 usando un ciclo for

// Aqui estan las variables de nuestro programa
int n = 0, i;

// Aqui se solicita el numero maximo a decrementar
Console.WriteLine("Desde que numero quieres que se impriman los numeros de 1 en 1: ");
n = int.Parse(Console.ReadLine());

// Aqui se hace el ciclo para la impresion
for(i = n ; i >= 1; i--)
{
    Console.Write($"{i}, ");
}