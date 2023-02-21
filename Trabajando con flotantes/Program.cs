// Trabajando con flotantes

float num1 = 423.45f, num2 = 123f, num3 = 1.94e-8f;
double num4 = 123123123.454545d, num5 = .3456;
decimal val1 = .10m;
decimal val2 = 56565.77e23m;

Console.Clear();
Console.WriteLine($"num1 y num2 en formato normal: {num1}, {num2}");
Console.WriteLine($"num4 en formato exponencial: {num4:E}");
Console.WriteLine($"num4 y num5 en formato con 2 decimales: {num4:f2}, {num5:f2}");
Console.WriteLine($"val1 en formato exponencial: {val1:p2}");
Console.WriteLine($"val2 en formato numerico: {val1:n2}");
Console.WriteLine($"val2 en formato numerico: {val1:C}");

Console.WriteLine($"float: {float.MinValue}, {float.MaxValue}, {sizeof(float)}");
Console.WriteLine($"double: {double.MinValue}, {double.MaxValue}, {sizeof(double)}");
Console.WriteLine($"decimal: {decimal.MinValue}, {decimal.MaxValue}, {sizeof(decimal)}");