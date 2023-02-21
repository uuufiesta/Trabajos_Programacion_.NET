// Se convertira una temperatura en grados celcius a farenheit o vicevesa

char eleccion;
double temperatura;

Console.WriteLine("Bienvenido al programa para hacer converciones de temperatura");
Console.WriteLine("Para elegir convertir de celcius a farenheit teclea [C]");
Console.WriteLine("Para elegir convertir de farenheit a celcius teclea [F]");
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("Dame tu eleccion...");
eleccion = char.ToUpper(Convert.ToChar(Console.ReadLine()));

if (eleccion == 'C')
{
    Console.WriteLine("Se ha seleccionado convertir de celcius a farenheit...");
    Console.WriteLine("Dame tu temperatura en grados calcius");
    temperatura = double.Parse(Console.ReadLine());
    temperatura = (temperatura * 9 / 5) + 32;
    Console.WriteLine($"El valor en grados farenheit es: {temperatura}");
}
else
{
    Console.WriteLine("Se ha seleccionado convertir de farenheit a celcius...");
    Console.WriteLine("Dame tu temperatura en grados farenheit");
    temperatura = double.Parse(Console.ReadLine());
    temperatura = (temperatura - 32) * 5 / 9;
    Console.WriteLine($"El valor en grados celcius es: {temperatura}");
}