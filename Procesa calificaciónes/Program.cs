// Procesamos calificaciones
// El usuario introduce n calificaciones
// Se obtendra la suma y el promedio

int totcal, i = 0;
float suma = 0, promedio, calif;

Console.Write("Bienvenido cuantas calificaciones deseas ingresar: ");
totcal = int.Parse(Console.ReadLine());

while (i < totcal)
{
    Console.WriteLine($"Calificacion {i++}");
    calif = float.Parse(Console.ReadLine());
    suma += calif;
}

promedio = suma / totcal;

Console.WriteLine($"La suma de las calificaciones es {suma:f2} y el promedio es {promedio:f2}");