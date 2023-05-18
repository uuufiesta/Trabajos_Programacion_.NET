namespace Alumno_p87;

public class Alumno
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public DateTime FechaIng { get; set; }
    public bool Becado { get; set; }
    public List<int> Calif { get; set; }

    public Alumno(string nombre, int edad, DateTime fechaIng, bool becado, List<int> calif)
    {
        Nombre = nombre;
        Edad = edad;
        FechaIng = fechaIng;
        Becado = becado;
        Calif = calif;
    }

    public override string ToString() => ($"Nombre: {Nombre,-12}, Edad: {Edad}, " +
                                          $"FechaIngreso: {FechaIng.ToString("dd/MM/yyyy")}, " +
                                          $"Becado: {(Becado ? "Si" : "No")}, Calificaciones: {string.Join(",", Calif)}");
}