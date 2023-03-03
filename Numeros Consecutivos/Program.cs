// Dados tres números enteros, verificar si son consecutivos (9,10,11)
// y mandar mensaje confirmándolo, si no lo son 
// (1,4,6) mandar mensaje de error.

// Declaramos las variables para nuestro programa
int n1, n2, n3;

// Aqui se solicitan los numeros que se van a comparar
Console.WriteLine("Bienvenido al programa que verifica si 3 numeros son consecutivos");
Console.WriteLine("Dame el valor del primer numero");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Dame el valor del segundo numero");
n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Dame el valor del tercer numero");
n3 = int.Parse(Console.ReadLine());

// Aqui se hace la comparacion de los 3 numeros
if (n1 == (n2 - 1) && n2 == (n3 - 1))
{
    Console.WriteLine($"Los numeros {n1}, {n2}, {n3} son consecutivos");
}
else
    Console.WriteLine($"Los numeros {n1}, {n2}, {n3} no son consecutivos");
