using Cliente_CB_Class;

namespace Banco_CB_Class;

public class Banco
{
    public string Nombre { get; set; }
    public string Domicilio { get; set; }
    public List<Cliente> Clientes { get; set; }

    public Banco() => Clientes = new List<Cliente>();

    public Banco(string nombre, string domicilio) : this() => (Nombre, Domicilio) = (nombre, domicilio);

    public void AgregarCliente(Cliente cliente) => Clientes.Add(cliente);

    public override string ToString() => $"{Nombre}, {Domicilio}";
}