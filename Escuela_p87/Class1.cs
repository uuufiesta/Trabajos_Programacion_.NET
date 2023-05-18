using Profesor_p87;

namespace Escuela_p87;

public class Escuela
{
    public string Nombre { get; set; }
    public string Encargado { get; set; }
    public string Domicilio { get; set; }
    public List<Profesor> Profesores { get; set; }

    public Escuela()
    {
        Profesores = new List<Profesor>();
    }

    public Escuela(string nombre, string encargado, string domicilio)
    {
        Nombre = nombre;
        Encargado = encargado;
        Domicilio = domicilio;
    }

    public void AgregarProfesor(Profesor profesor) => Profesores.Add(profesor);

    public override string ToString() => $"Nombre: {Nombre}\n" +
                                         $"Encargado: {Encargado}\n" +
                                         $"Domicilio: {Domicilio}\n";
}