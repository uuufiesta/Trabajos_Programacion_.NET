// Calcularemos el volumen de un cilindro

double radio, altura, volumen;

Console.WriteLine("Dame el valor del radio del cilindro: ");
radio = double.Parse(Console.ReadLine());
Console.WriteLine("Dame el valor de la altura del cilindro:");
altura = double.Parse(Console.ReadLine());

volumen = Math.PI*(radio*radio)*altura;

Console.WriteLine($"El volumen de nuestro cilindro es: {volumen}");