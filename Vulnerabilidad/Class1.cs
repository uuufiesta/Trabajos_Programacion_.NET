namespace Vulnerabilidad
{
    public class Vulnerabilidad
    {
        public string Clave { get; set; }
        public string Vendedor { get; set; }
        public string Descripcion { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }

        public Vulnerabilidad()
        {
        }

        public Vulnerabilidad(string clave, string vendedor, string descripcion, string tipo, DateTime fecha) =>
            (Clave, Vendedor, Descripcion, Tipo, Fecha) = (clave, vendedor, descripcion, tipo, fecha);

        public override string ToString() =>
            ($"Clave: {Clave}, Vendedor: {Vendedor}, Descripcion: {Descripcion}, Tipo: {Tipo}, Fecha: {Fecha.ToString("dd/MM/yyyy")}, Antiguedad: {DateTime.Now.Year - Fecha.Year}");
    }
}