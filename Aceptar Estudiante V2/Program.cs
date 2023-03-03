// Dado el nombre del estudiante, sexo (h/m), su edad y tres calificaciones,
// decidir si el estudiante es aceptado. La Universidad Kitty Kat SA es solo
// para mujeres mayores de 21 años con un promedio de entre 8 y 9.5

// Aqui van las variables de nuestro programa

string nombre;
char sexo;
int edad;
float[] calif = new float[3];
float sum = 0, prom = 0;

// Aqui se piden los datos
Console.WriteLine("Bienvenido al sistema de La Universidad Kitty Kat SA");
Console.WriteLine("Por favor dame los siguientes datos: ");
Console.Write("Dame tu nombre por favor: ");
nombre = Console.ReadLine();
Console.Write("Dame tu sexo [H]Hombre [M]Mujer: ");
sexo = char.Parse(Console.ReadLine().ToUpper());
Console.Write("Dame tu edad: ");
edad = int.Parse(Console.ReadLine());
for (int i = 0; i < calif.Length; i++)
{
    Console.Write("Dame la calificacion: ");
    calif[i] = float.Parse(Console.ReadLine());
    sum += calif[i];
}

prom = sum / 3;

// Aqui se hace la verificacion
if (sexo == 'M')
{
    if (edad > 21)
    {
        if (prom >= 8 && prom <= 9.5)
        {
            Console.WriteLine("Felicidades haz sido aceptada");
        }
        else
        {
            Console.Write("No tienes el promedio suficiente o es mas del requerido");
        }
    }
    else
    {
        Console.Write("No tienes la edad suficiente para ingresar");
    }
}
else
    Console.WriteLine("Lo sentimos la universidad es solo para mujeres");