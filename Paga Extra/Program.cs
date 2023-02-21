// Calcularemos la paga total de un trabajador

string nombre;
int horas, extra;
float paga, total;

Console.WriteLine("Dame tu nombre:");
nombre = Console.ReadLine();
Console.WriteLine("Cuantas horas trabajaste");
horas = int.Parse(Console.ReadLine());
Console.WriteLine("A cuanto te pagaron la hora");
paga = float.Parse(Console.ReadLine());

if (horas > 40)
{
    extra = horas - 40;
    total = 40 * paga + (extra * paga * 2);
}
else
{
    total = horas * paga;
}

Console.WriteLine($"El pago de {nombre} por trabajar {horas} horas sera: {total}");