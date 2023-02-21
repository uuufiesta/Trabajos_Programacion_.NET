// Trabajando con numeros enteros

int num1 = 42, num2 = 0x2A, num3 = 0b101010;

Console.Clear();
Console.WriteLine($"Decimal {num1} {num2} {num3}");
Console.WriteLine($"Numero en base 10: {num1}");
Console.WriteLine($"Numero en base 08: {Convert.ToString(num1,8)}");
Console.WriteLine($"Numero en base 16: {Convert.ToString(num1,16)}");
Console.WriteLine($"Numero en base 02: {Convert.ToString(num1,2)}");

sbyte edad = 95;
byte val1 = 230, val2 = 254;
short horas = 24, dias = 12345;
long ganancia = 321321321321;
ulong añoluz = 12312312321232132132;

Console.WriteLine($"La ganancia anual: {ganancia:C}");
Console.WriteLine($"Años luz a la luna: {añoluz:E}");
Console.WriteLine($"num2 base dec, hex: {num2:D}, {num2:X}");
Console.WriteLine($"sbyte: {sbyte.MinValue}, {sbyte.MaxValue}");
Console.WriteLine($"byte: {byte.MinValue}, {byte.MaxValue}");
Console.WriteLine($"int: {int.MinValue}, {int.MaxValue}");
Console.WriteLine($"short: {short.MinValue}, {short.MaxValue}");
Console.WriteLine($"long: {long.MinValue}, {long.MaxValue}");
Console.WriteLine($"ulong: {ulong.MinValue}, {ulong.MaxValue}");

Console.WriteLine($"bytes int : {sizeof(int)}");
Console.WriteLine($"bytes ulong : {sizeof(ulong)}");