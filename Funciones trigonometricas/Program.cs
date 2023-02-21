// Calcula las funciones trigonometricas basicas de un angulo en radianes

Console.Clear();
Console.WriteLine("Dame un angulo en raidanes: ");
double angulo = double.Parse(Console.ReadLine());

Console.WriteLine($"El angulo {angulo} tiene las siguientes funciones trigonometricas:");
Console.WriteLine("Seno {0:f4}, Coseno {1:f4}, Tangente {2:f4}",Math.Sin(angulo), Math.Cos(angulo), Math.Tan(angulo));