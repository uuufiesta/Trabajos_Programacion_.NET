using Cuenta_Bancaria_Class;

namespace Cliente_CB_Class;

public class Cliente
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public CuentaBancaria Cuenta { get; set; }

    public Cliente(string nombre, string apellido)
    {
        Nombre = nombre;
        Apellido = apellido;
    }

    public override string ToString() => $"{Nombre}, {Apellido}";
}