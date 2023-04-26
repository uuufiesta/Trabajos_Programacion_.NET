// ?  Obtener el promedio de tres números, usando una función

// * Aqui se encuentran las funciones

float Promedio(float n1, float n2, float n3)
{
    float sum;

    sum = n1 + n2 + n3;
    return sum / 3;
}

// * Aqui se encuentran las variables
string[] num;

// * Se piden los datos
Console.Write("Dame 3 numeros separados por espacio: ");
// * Se asigna a un arreglo de string donde cada palabra separada por espacio quedara en una posicion del arreglo
num = Console.ReadLine().Split();

// * Se imprime el valor de la funcion que mandamos cada valor por posicion transformado a su version float para ser procesado por la funcion
Console.WriteLine($"El promedio de tus calificaciones es: {Promedio(float.Parse(num[0]), float.Parse(num[1]), float.Parse(num[2])):f2}");