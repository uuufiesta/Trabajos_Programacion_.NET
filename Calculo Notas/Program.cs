// Se desea calcular el promedio de 5 calificaciones introducidas
// por el usuario, luego evaluar el resultado e imprimir 
// un mensaje de acuerdo con el promedio obtenido: 
// • >0 y <= 6 Quedas reprobado
// • >6 a <=7 Pasas de panzazo
// • >7 y <=8 Muy bien, pues mejorar
// • >8 y <=9 Excelente sigue así
// • >9 y <=10 Perfecto tu esfuerzo valió la pena

// Aqui estan las variables de nuestro programa

float[] calif = new float[5];
float prom, sum = 0;

// Aqui se solicitan los datos
Console.WriteLine("Bienvenido vamos a sacar tu promedio se te pediran tus 5 calificaciones");
for (int i = 0; i < calif.Length; i++)
{
    Console.WriteLine("Dame tu calificacion: ");
    calif[i] = float.Parse(Console.ReadLine());
    sum += calif[i];
}

// Aqui se saca el promedio y se evalua su caso
prom = sum / 5;

if (prom <= 6)
{
    Console.WriteLine("Quedas Reprobado");
}
else if (prom > 6 && prom <= 7)
{
    Console.WriteLine("Pasas de panzazo");
}
else if (prom > 7 && prom <= 8)
{
    Console.WriteLine("Muy bien, puedes mejorar");
}
else if (prom > 8 && prom <= 9)
{
    Console.WriteLine("Excelente sigue asi");
}
else
    Console.WriteLine("Perfecto tu esfuerzo valio la pena");