// Crearemos una calculadora que podra realizar las operaciones basicas con 2 numeros

// Declaramos las variables que usaremos en nuestro programa
double n1, n2;
char op;

// Haremos la solicitud de los numeros y la operacion a realizar
Console.WriteLine("Realiza operaciones matematicas basicas con 2 numeros");
Console.WriteLine("Dame el primer numero:");
n1 = double.Parse(Console.ReadLine());
Console.WriteLine("Dame el primer numero:");
n2 = double.Parse(Console.ReadLine());

Console.WriteLine("Dame la operacion a realizar [+ - * / $(Potencia)]");
op = Console.ReadLine()[0];

// Se hara la comparacion de la operacion que se quiere realizar, se hara dicha operacion
// y se mostrara el resultado en pantalla    
switch (op)
{
    case '+':
        Console.WriteLine($"{n1} + {n2} = {n1 + n2}");
        break;
    case '-':
        Console.WriteLine($"{n1} - {n2} = {n1 - n2}");
        break;
    case '*':
        Console.WriteLine($"{n1} * {n2} = {n1 * n2}");
        break;
    case '/':
        Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
        break;
    case '$':
        Console.WriteLine($"{n1} $ {n2} = {Math.Pow(n1,n2)}");
        break;
    default:
        Console.WriteLine("Operacion no valida");
        break;
}