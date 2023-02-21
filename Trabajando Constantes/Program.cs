// Trabajando con constantes

const double Descuento = 0.10;
const int VelocidadLuz = 30000;
const float Tasa = 0.5f;
const byte Separador = 254;
const sbyte Literal = 0x64;
const string Mensaje = "Error en el sistema";

Console.Clear();
Console.WriteLine("El valor de las constantes es:");
Console.WriteLine($"Descuento x 2: {Descuento*2}");
Console.WriteLine($"Velocidad / 2: {VelocidadLuz/2}");
Console.WriteLine($"Tasa: {Tasa:p}");

Console.WriteLine(Mensaje);
Console.WriteLine($"Separador - literal en formato hexadecimal: {Separador:X}, {Literal:X}");
Console.WriteLine($"Separador - Literal en formato binario: {Convert.ToString(Separador,2)}, {Convert.ToString(Literal,2)}");