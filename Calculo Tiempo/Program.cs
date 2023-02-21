// Calcularemos el equivalente de una cantidad en horas sus equivalentes en dias segundos etc

int horas, dias, minutos, segundos;

Console.WriteLine("Dame la cantidad de horas a calcular su equivalencia:");
horas = int.Parse(Console.ReadLine());

dias = horas / 24;
minutos = horas * 60;
segundos = minutos * 60;

Console.WriteLine($"El valor de {horas} horas es:\n" +
                  $"En Dias: {dias}\n" +
                  $"En minutos: {minutos}\n" +
                  $"En segundos: {segundos}");