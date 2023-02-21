// Dividir un numero de 3 cifras en CDU

Console.Clear();
double centenas, decenas, unidades, num=125;

centenas = Math.Truncate(num/100);
decenas = Math.Truncate((num - (centenas * 100))/10);
unidades = ((num - (centenas*100) - (decenas * 10)));

Console.WriteLine($"Centenas: {centenas}");
Console.WriteLine($"Decenas: {decenas}");
Console.WriteLine($"Unidades: {unidades}");