namespace Red;

public class Red {
    public string Empresa {get; set;}
    public string Propietario {get; set;}
    public string Domicilio {get; set;}
    public List<Nodo.Nodo> Nodos {get; set;}
    public Red(){Nodos = new List<Nodo.Nodo>();}
    public Red(string empresa, string propietario, string domicilio) : this() =>
        (Empresa, Propietario, Domicilio) = (empresa, propietario, domicilio);
    
    public void AgregarNodo(Nodo.Nodo nodo) => Nodos.Add(nodo);

    public int TotalVulnerabilidades() {
        int c = 0;
        foreach(Nodo.Nodo p in Nodos)
            c += p.Vulnerabilidades.Count;
        return c;
    }
    
    public int MayorSaltos() {
        int c = 0;
        foreach(Nodo.Nodo a in Nodos)
            if(a.Saltos >= c) c = a.Saltos;
        return c;
    }
    
    public int MenorSaltos() {
        int c = 100;
        foreach(Nodo.Nodo a in Nodos)
            if(a.Saltos < c) c = a.Saltos;
        return c;
    }

    public override string ToString() => ($"Empresa: {Empresa}\nPropietario: {Propietario}\nDomicilio: {Domicilio}");
    
    public string Resumen() => ($"\nTotal nodos red: {Nodos.Count} \nTotal Vulnerabilidades: {TotalVulnerabilidades()}");

    public string NumSaltos() => ($"\nMayor numero de saltos: {MayorSaltos()} \nMenor numero de saltos: {MenorSaltos()}");
}