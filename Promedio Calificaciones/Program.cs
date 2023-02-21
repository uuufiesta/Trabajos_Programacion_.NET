// Calcula el promedio de 3 calificaciones y la menor y la mayor

float cal1, cal2, cal3, suma, prom, mayor, menor;

Console.WriteLine("Calificacion 1");
cal1 = float.Parse(Console.ReadLine());
Console.WriteLine("Calificacion 2");
cal2 = float.Parse(Console.ReadLine());
Console.WriteLine("Calificacion 3");
cal3 = float.Parse(Console.ReadLine());

suma = cal1 + cal2 + cal3;
prom = suma / 3;
mayor = Math.Max(Math.Max(cal1, cal2), cal3);
menor = Math.Min(Math.Min(cal1, cal2), cal3);

Console.WriteLine($"Las calificaciones fueron: {cal1}, {cal2}, {cal3}");
Console.WriteLine($"El promedio es: {prom:f2}");
Console.WriteLine($"La calificación mayor es: {mayor:f2}");
Console.WriteLine($"La calificacion menor es: {menor:f2}");