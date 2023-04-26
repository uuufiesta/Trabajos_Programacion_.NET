//  ? Realizar un algoritmo que reciba una calificación y me regrese una letra, usando 
// ? una función
/*  $ > 90 <= 100 A Excelente
    $ > 80 <= 90  B Bien
    $ > 70 <= 80  C Suficiente
    $ > 60 <= 70  D Deficiente
    $ > 50 <= 60  F Reprobado
    $ */

// * Empiezan las funciones del programa

char CalifLet(float cal)
{
    if (cal > 90 && cal <= 100)
    {
        return 'A';
    }
    else if (cal > 80 && cal <= 90)
    {
        return 'B';
    }
    else if (cal > 70 && cal <= 80)
    {
        return 'C';
    }
    else if (cal > 60 && cal <= 70)
    {
        return 'D';
    }
    else
    {
        return 'F';
    }
}

// ! Terminan las funciones del programa
// * Variables del programa
float cal;

// * Se solicita la calificacion
Console.Write("Dame tu calificacion: ");
cal = float.Parse(Console.ReadLine());

// * Se llama la funcion e imprime su resultado
Console.WriteLine($"Tu nota en letra es: {CalifLet(cal)}");

Console.WriteLine("Gracias por usar el programa");