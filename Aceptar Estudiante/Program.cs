/* Se desea administrar el ingreso a la Universidad con las siguientes reglas:
• Se proporciona la edad y dos calificaciones del estudiante.
• Solo ingresan estudiantes mayores de 18 años
• Solo ingresan estudiantes cuyas calificaciones sean mayores que 8 
• Si cumple las condiciones enviar un mensaje de bienvenida
• De igual forma informar al estudiante si se le rechaza y por que
*/

//Se declaran las variables del programa
int edad, cal1, cal2; 

//Se crea un menu para la interaccion
Console.WriteLine("Bienvenido al sistema de registro de la Columbia University of Mexico");
Console.WriteLine("Necesitaremos tus datos para poder verificar si eres apto para el registro...");

//Se solicitan y leen los datos del aspirante
Console.WriteLine("Porfavor dame tu edad actual...");
edad = int.Parse(Console.ReadLine());
Console.WriteLine("Por favor dame tu primer calificacion...");
cal1 = int.Parse(Console.ReadLine());
Console.WriteLine("Por favor dame tu segunda calificacion...");
cal2 = int.Parse(Console.ReadLine());
Console.WriteLine("Gracias, procederemos a hacer la evaluacion de tus datos");

//Realizamos las comparaciones necesarias para nuestra problematica
if (edad > 18)
{
    if (cal1 > 8 && cal2 > 8)
    {
        Console.WriteLine("Felicidades tienes el perfil para poder realizar tu registro");
    }
    else
    {
        Console.WriteLine("Lo sentimos no es posible realizar tu registro, alguna o ambas calificaciones no son mayores a 8");
    }
}
else
{
    Console.WriteLine("Lo sentimos no es posible realizar tu registro, tu edad es menor a 18 años");
}
//Terminan las comparaciones