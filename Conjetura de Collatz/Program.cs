// • Esta conjetura dice que dado cualquier número 
// entero posiCvo (validar posiCvo),
// • y aplicando estas dos reglas, acaba siendo 
// siempre 1:
// • Si el número es par, se divide entre 2
// • Si el número es impar, se mul?plica por 3 y se suma 1

// Aqui se declara la variable de nuestro programa
int numero, ctrl;

// Aqui se solocita el numero para la conjetura y se convierte a positivo
Console.Write("Dame el numero positivo a validar en la conjetura: ");
numero = Math.Abs(int.Parse(Console.ReadLine()));

Console.WriteLine("La conjetura es la siguiente:");
while (numero != 1)
{
    ctrl = numero % 2;
    if (ctrl == 0)
    {
        numero /= 2;
        Console.Write($"{numero}, ");
    }
    else
    {
        numero *= 3;
        numero++;
        Console.Write($"{numero}, ");
    }
}

