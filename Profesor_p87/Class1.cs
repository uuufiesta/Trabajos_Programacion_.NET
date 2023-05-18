using Alumno_p87;

namespace Profesor_p87;

public class Profesor
{
    public string Nombre { get; set; }
    public DateTime FechaIng { get; set; }
    public string Grupo { get; set; }
    public string Materia { get; set; }
    public double Salario { get; set; }
    public List<Alumno> Alumnos { get; private set; }

    public Profesor()
    {
        Alumnos = new List<Alumno>();
    }

    public Profesor(string nombre, DateTime fechaIng, string grupo, string materia, double salario)
    {
        Nombre = nombre;
        FechaIng = fechaIng;
        Grupo = grupo;
        Materia = materia;
        Salario = salario;
    }
    
    public void AgregarAlumno (Alumno alumno) => Alumnos.Add(alumno);

    public override string ToString() => $"Nombre: {Nombre,-12}, FechaIngreso: {FechaIng.ToString("dd / MM / yyyy")}, " +
                                         $"Grupo: {Grupo}, Materia: {Materia,-7}, Salario: {Salario:C}";
}