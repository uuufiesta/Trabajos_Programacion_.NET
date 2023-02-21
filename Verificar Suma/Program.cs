// Verificaremos que la suma de 2 numeros dados sea igual al tercer numero dado

int n1, n2, n3;

Console.WriteLine("Dame el valor del primer numero:");
n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Dame el valor del segundo numero:");
n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Dame el valor del tercer numero:");
n3 = int.Parse(Console.ReadLine());

if ((n1 + n2) == n3)
{
    Console.WriteLine($"El resultado de la suma de {n1} y {n2} si da como resultado {n3}");
}
else
{
    Console.WriteLine($"Los numeros {n1} y {n2} no dan como resultado {n3}");
}