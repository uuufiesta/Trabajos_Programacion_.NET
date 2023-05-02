// ? Programa principal de Cuanta Bancaria

using Banco_CB_Class;
using Cliente_CB_Class;
using Cuenta_Bancaria_Class;

CuentaBancaria cuenta1 = new CuentaBancaria(5000);
cuenta1.Deposita(10000);
Console.WriteLine($"El saldo es {cuenta1.Saldo}");
bool retiro = cuenta1.Retira(56);
if (retiro)
{
    Console.WriteLine($"Retiro efectuado, nuevo saldo: {cuenta1.Saldo}");
}
else
{
    Console.WriteLine("Ni para los cigarros tienes");
}

Cliente cliente1 = new Cliente("David", "Monreal");
cliente1.Cuenta = cuenta1;
Console.WriteLine($"Cliente: {cliente1}");
Console.WriteLine($"El saldo es {cliente1.Cuenta.Saldo}");
Cliente cliente2 = new Cliente("Carlos", "Cataneda");
cliente2.Cuenta = new CuentaBancaria(1000000);
cliente2.Cuenta.Retira(5000);
Console.WriteLine($"Cliente: {cliente2}");
Console.WriteLine($"El saldo es: {cliente2.Cuenta.Saldo}");

Banco miBanco = new Banco("Banco el uri", "Durango 243");
miBanco.AgregarCliente(cliente1);
miBanco.AgregarCliente(cliente2);

Cliente cliente3 = new Cliente("Uriel", "Pinguino");
cliente3.Cuenta = new CuentaBancaria(6000);
miBanco.AgregarCliente(cliente3);

miBanco.Clientes[0].Cuenta.Deposita(10000);
miBanco.Clientes[1].Cuenta.Retira(1000);
miBanco.Clientes[2].Cuenta.Deposita(15000);

Console.WriteLine($"Banco: {miBanco}");
foreach (Cliente cl in miBanco.Clientes)
{
    Console.WriteLine($"Cliente: {cl}");
    Console.WriteLine($"Saldo: {cl.Cuenta.Saldo}");
}