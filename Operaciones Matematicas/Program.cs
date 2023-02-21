// Este programa usaremos las operaciones basicas

double sum, res, mul, div, resi, pot;
double x, y;

Console.Clear();
Console.WriteLine("Dame el primer numero para hacer las operaciones:");
x = Double.Parse(Console.ReadLine());
Console.WriteLine("Dame el segundo numero para hacer las operaciones:");
y = Double.Parse(Console.ReadLine());

sum = x + y;
res = x - y;
mul = x * y;
div = x / y;
resi = x % y;
pot = Math.Pow(x,y);

Console.WriteLine($"Los numeros son {x}, {y} y los resultados de las operaciones son:");
Console.WriteLine($"Suma: {sum}");
Console.WriteLine($"Resta: {res}");
Console.WriteLine($"Multiplicación: {mul}");
Console.WriteLine($"Divición: {div}");
Console.WriteLine($"Residuo: {resi}");
Console.WriteLine($"Potencia: {pot}");