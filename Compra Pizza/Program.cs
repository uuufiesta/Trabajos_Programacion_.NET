// Un usuario puede elegir un tamaño de pizza ( chica - $5, mediana $10, grande $20 ) ,
// luego elige la cantidad, si la compra es menor a 2000 no tiene descuento, mayor a
// 2000 tiene un descuento de 15%. Diseñe un programa que permita procesar la solicitud
// e imprimir: tamaño de la compra, cantidad comprada, total compra, descuento, total de 
// compra con descuento

// Aqui estan la variables de nuestro programa

char tam;
int cant;
string tipo = "";
float subtot, desc = 0, total;

// Aqui solicitaremos los datos
Console.WriteLine("Bienvenido a la pizzeria la jaiba recibiremos tu orden");
Console.WriteLine("Dame el tamaño de tu pizza [C]Chica [M]Mediana [G]Grande");
tam = char.Parse(Console.ReadLine().ToUpper());
Console.WriteLine("Dame la cantidad de pizzas que quieres: ");
cant = int.Parse(Console.ReadLine());

// Aqui se hace el proceso para determinar precios
switch (tam)
{
    case 'C':
        tipo = "Chica";
        subtot = 5.0f;
        break;
    case 'M':
        tipo = "Mediana";
        subtot = 10.0f;
        break;
    default:
        tipo = "Grande";
        subtot = 20.0f;
        break;
}

subtot = subtot * cant;

if (subtot > 2000)
{
    desc = subtot * 0.15f;
    total = subtot - desc;
}
else
    total = subtot;

Console.WriteLine($"Tamaño: {tipo}\n" +
                  $"Cantidad: {cant}\n" +
                  $"Subtotal: {subtot:C}\n" +
                  $"Descuento: {desc:p2}\n" +
                  $"Total: {total:C}");