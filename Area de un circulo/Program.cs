// Calcular el area de un circulo
double radio, area;

radio = double.Parse(Console.ReadLine());

area = Math.PI * Math.Pow(radio,2);

Console.WriteLine($"El circulo de radio {radio} tiene un area de {area}\n");

Console.WriteLine($"El tipo dato de la variable es {radio.GetType()} el del area es {area.GetType()}");