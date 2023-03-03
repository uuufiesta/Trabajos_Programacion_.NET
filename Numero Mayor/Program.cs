// Dados tres números enteros, verificar cual es el mayor

// Aqui estan las variables del programa
int n1, n2, n3;

// Aqui se solicitan los datos
Console.WriteLine("Bienvenido al programa que te dice cual de 3 numeros es mayor");
Console.WriteLine("Dame el valor del primer numero");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Dame el valor del segundo numero");
n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Dame el valor del tercer numero");
n3 = int.Parse(Console.ReadLine());

// Aqui se hace la comparacion de los numeros
if (n1 > n2 && n1 > n3)
{
    Console.WriteLine($"{n1} es el numero mas grande de los 3");
}
else if (n2 > n1 && n2 > n3)
{
    Console.WriteLine($"{n2} es el numero mas grande de los 3");
}
else
    Console.WriteLine($"{n3} es el numero mas grande de los 3");