/* • Dado un ángulo entre 0 y 360 grados,
• Mostrar el tipo de ángulo, en base a lo siguiente:
    • < 90 agudo, 
    • = 90 recto, 
    • > 90 y < 180 obtuso, 
    • = 180 llano, 
    • > 180 y < 360 concavo
*/

double ang;

Console.WriteLine("Bienvenido, dame el valor de angulo que tienes en grados");
ang = double.Parse(Console.ReadLine());

while (ang > 360)
{
    Console.WriteLine($"Tu angulo original es de {ang} grados y esta siendo convertido");
    ang -= 360;
}

if (ang < 90)
{
    Console.WriteLine($"El angulo de {ang} grados es un angulo agudo");
}
if (ang == 90)
{
    Console.WriteLine($"El angulo de {ang} grados es un angulo recto");
}
if (ang > 90 && ang < 180)
{
    Console.WriteLine($"El angulo de {ang} grados es un angulo obtuso");   
}
if (ang == 180 || ang == 360 || ang == 0)
{
    Console.WriteLine($"El angulo de {ang} grados es un angulo llano");
}
if (ang > 180 && ang < 360)
{
    Console.WriteLine($"El angulo de {ang} grados es un angulo concavo");   
}