namespace Empleado_Class;

public class Empleado
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Empleado()
    {
    }

    public Empleado(string nombre) => Nombre = nombre;
    public Empleado(string nombre, int edad) => (Nombre, Edad) = (nombre, edad);

    public void ImprimirDato()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad}");
    }
}