// Sistema de ventas para pizzeria

// Declaramos una funcion de tipo void para desplegar el menu de seleccion
void Menu()
{
    Console.Clear();
    Console.WriteLine("Elige como deseas el pedido de tu pizza");
    Console.WriteLine("Tamaño: [C]Chica - $5 [M]Mediana - $10 [G]Grande - $15");
    Console.WriteLine("Ingredientes: [E]Extra queso [C]Champiñones [P]Piña, unidos por + - $5 por cada ingrediente");
    Console.WriteLine("Cubierta: [D]Delgada [G]Gruesa");
    Console.WriteLine("Donde: [A]Aqui [L]Llevar");
}

// Declaramos las variables necesarias para nuestro programa
char tam, cub, don;
string[] ings;
string tamanio = "", ingredientes = "", cubierta = "", donde = "", cliente = "";
float subtot = 0, cant = 0, total = 0, desc = 0;

if (args.Length < 3)
{
    Menu();
    return 1;
}

// Aqui se hace la comparacion del tamaño de la pizza
tam = char.Parse(args[0].ToUpper());
if (tam == 'C')
{
    tamanio = "Chica";
    subtot += 5;
}
else if (tam == 'M')
{
    tamanio = "Mediana";
    subtot += 10;
}
else
{
    tamanio = "Grande";
    subtot += 15;
}

// Aqui se procesan los ingredientes
ings = args[1].Split("+");
foreach (string ing in ings)
{
    switch (char.Parse(ing.ToUpper()))
    {
        case 'E':
            ingredientes += "Extraqueso";
            break;
        case 'C':
            ingredientes += "Champiñones";
            break;
        case 'P':
            ingredientes += "Piña";
            break;
    }
    subtot += 5;
}

// Aqui se procesa la cubierta
cub = char.Parse(args[2].ToUpper());
cubierta = (cub == 'D' ? "Delgada" : "Gruesa");


// Aqui se procesa para donde seria el pedido
don = char.Parse(args[3].ToUpper());
donde = (don == 'A' ? "Aqui" : "Gruesa");

// Aqui se procesa la cantidad
cant = float.Parse(args[4]);
subtot = subtot * cant;

// Aqui se procesa el descuento
if (subtot < 1000)
{
    desc = 0.0f;
    cliente = "Platino";
}
else if(subtot<2000)
{
    desc = 0.10f;
    cliente = "Plata";
}
else
{
    desc = 0.20f;
    cliente = "Oro";
}
total = subtot - (subtot * desc);

    Console.WriteLine($"Tamaño: {tamanio}");
Console.WriteLine($"Ingredientes: {ingredientes}");
Console.WriteLine($"Cubierta: {cubierta}");
Console.WriteLine($"Donde: {donde}");
Console.WriteLine($"Cantidad: {cant}");
Console.WriteLine($"Subtotal: {subtot:C}");
Console.WriteLine($"Descuento: {desc:p2}");
Console.WriteLine($"Total: {total:C}");
    
return 0;
