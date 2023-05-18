namespace Nodo;

public class Nodo {
    public string Ip {get; set;}
    public string Tipo {get; set;}    
    public int Puertos {get; set;}
    public int Saltos {get; set;}
    public string So {get; set;}
    public List<Vulnerabilidad.Vulnerabilidad> Vulnerabilidades {get; private set;}
    public Nodo(){Vulnerabilidades = new List<Vulnerabilidad.Vulnerabilidad>();}
    public Nodo(string ip, string tipo, int puertos, int saltos, string so) : this() =>
        (Ip, Tipo, Puertos, Saltos, So) = (ip, tipo, puertos, saltos, so);

    public void AgregarVulnerabilidad(Vulnerabilidad.Vulnerabilidad vulnerabilidad) => Vulnerabilidades.Add(vulnerabilidad);
    
    public override string ToString() =>($"IP: {Ip}, Tipo: {Tipo}, Puertos: {Puertos}, Saltos: {Saltos}, SO: {So}, TotVul: {Vulnerabilidades.Count}");
}