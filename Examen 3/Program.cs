// Created by Luis Mario Avila Maldonado

﻿using System.Text.Json;
Red.Red red = null;
string archivo = "redes.json";
string jsonRedes = "";
int op;


void Inicializar() {
    Console.Clear();
    Console.WriteLine("Inicializando con datos de prueba ------");
    if(red is null) {
        red = new Red.Red(empresa:"Red Uriel, S.A. de C.V", propietario:"Uriel el pinguino", domicilio:"Av. Lomas del patrocinio, Zacatecas Zac");
        red.AgregarNodo(new Nodo.Nodo(ip:"172.168.0.10", tipo:"Servidor", puertos:5, saltos:10, so:"Windows"));
        red.AgregarNodo(new Nodo.Nodo(ip:"172.168.0.12", tipo:"Equipo activo", puertos:2, saltos:12, so:"ios"));
        red.AgregarNodo(new Nodo.Nodo(ip:"172.168.0.20", tipo:"Computadora", puertos:8, saltos:5, so:"Windows"));
        red.AgregarNodo(new Nodo.Nodo(ip:"172.168.0.15", tipo:"Servidor", puertos:10, saltos:22, so:"Linux"));

        red.Nodos[0].AgregarVulnerabilidad(new Vulnerabilidad.Vulnerabilidad(clave:"CVE-2018-2435", vendedor:"Microsoft", 
        descripcion:"HTTP.sys permite a atacantes remotos ejecutar codigo arbitrario", tipo:"remota", fecha:DateTime.Parse("23/07/2018")));
        red.Nodos[0].AgregarVulnerabilidad(new Vulnerabilidad.Vulnerabilidad(clave:"CVE-2014-0204", vendedor:"Microsoft", 
        descripcion:"El servicio LSASS permite causar una denegacion de servicio", tipo:"local", fecha:DateTime.Parse("04/09/2014")));
        red.Nodos[1].AgregarVulnerabilidad(new Vulnerabilidad.Vulnerabilidad(clave:"CVE-2019-4867", vendedor:"Cisco", 
        descripcion:"Cisco Firepower Management Center XSS", tipo:"remota", fecha:DateTime.Parse("21/02/2019")));
        red.Nodos[2].AgregarVulnerabilidad(new Vulnerabilidad.Vulnerabilidad(clave:"CVE-2011-2538", vendedor:"Microsoft", 
        descripcion:"Multiples desbordamientos de enteros en APIs Microsoft .NET 1.1", tipo:"local", fecha:DateTime.Parse("30/11/2011")));
        red.Nodos[2].AgregarVulnerabilidad(new Vulnerabilidad.Vulnerabilidad(clave:"CVE-2020-7972", vendedor:"Microsoft", 
        descripcion:"Elevacion de privilegios Kernel Segura en Windows 10 Gold", tipo:"local", fecha:DateTime.Parse("14/07/2020")));
        red.Nodos[2].AgregarVulnerabilidad(new Vulnerabilidad.Vulnerabilidad(clave:"CVE-2021-4956", vendedor:"Adobe", 
        descripcion:"Adobe Flash Player 24.0.0.194 corrupcion de memoria explotable", tipo:"remota", fecha:DateTime.Parse("06/05/2021")));

        Console.WriteLine("\nDatos de prueba han sido cargados ---------");
    } else {Console.WriteLine("\nYa existen datos cargados -----------");}
}


void AddNode() {
    Nodo.Nodo nodo = new Nodo.Nodo();
    if(red is not null) {
        Console.Clear();
        Console.WriteLine("*** Agregar nodo a la red -----------");
        Console.WriteLine("\nIntroduce los datos del nuevo nodo:");
        Console.Write("IP: "); nodo.Ip = Console.ReadLine();
        Console.Write("Tipo: "); nodo.Tipo = Console.ReadLine();
        Console.Write("Puertos: "); nodo.Puertos = int.Parse(Console.ReadLine());
        Console.Write("Saltos: "); nodo.Saltos = int.Parse(Console.ReadLine());
        Console.Write("SO: "); nodo.So = Console.ReadLine();
        red.AgregarNodo(nodo);
        Console.WriteLine("\nNodo agregado ------------------");
        red.Nodos.ForEach(p => Console.WriteLine(p.ToString()));
    } else {Console.WriteLine("\nNo hay datos en memoria para AgregarNodo ------");}
}


void AddVuln() {
    Vulnerabilidad.Vulnerabilidad vulnerabilidad = new Vulnerabilidad.Vulnerabilidad();
    int option;
    if(red is not null) {
        Console.Clear();
        Console.WriteLine("*** Agregar vulnerabilidad al nodo -------");
        if(red.Nodos.Count != 0) {
            for(int i = 0; i < red.Nodos.Count; i++)
                Console.WriteLine($"{i} - {red.Nodos[i].Ip}");
            Console.Write("\nElige el nodo: "); option = int.Parse(Console.ReadLine());
            Console.Write("Introduce los datos de la nueva vulnerabilidad:\n");
            Console.WriteLine(red.Nodos[option].ToString());
            Console.Write("Clave: "); vulnerabilidad.Clave = Console.ReadLine();
            Console.Write("Vendedor: "); vulnerabilidad.Vendedor = Console.ReadLine();
            Console.Write("Descripcion: "); vulnerabilidad.Descripcion = Console.ReadLine();
            Console.Write("Tipo(local/remota): "); vulnerabilidad.Tipo = Console.ReadLine();
            Console.Write("Fecha: "); vulnerabilidad.Fecha = DateTime.Parse(Console.ReadLine());
            red.Nodos[option].AgregarVulnerabilidad(vulnerabilidad);
            Console.WriteLine("\nVulnerabilidad agregada -----------");
            red.Nodos[option].Vulnerabilidades.ForEach(p => Console.WriteLine(p.ToString()));
        } else {Console.WriteLine("\nNo hay nodos para AgregarVulnerabilidad ------");}
    } else {Console.WriteLine("\nNo hay datos en memoria para AgregarVulnerabilidad -");}
}


void LoadData() {
    Console.Clear();
    Console.WriteLine("Cargar los datos de un archivo ---------------------");
    if(File.Exists(archivo)) {
        jsonRedes = File.ReadAllText("redes.json");
        Console.WriteLine(jsonRedes);
        red = new Red.Red();
        red = JsonSerializer.Deserialize<Red.Red>(jsonRedes);
        Console.WriteLine("\nLos datos han sido cargados --------------------------" + archivo);
    } else {Console.WriteLine("\nEl archivo de datos no existe ----------------------");}
}


void SaveData() {
    Console.Clear();
    Console.WriteLine("Guardar los datos en un archivo --------------------");
    if(red is not null) {
        jsonRedes = JsonSerializer.Serialize(red);
        File.WriteAllText(archivo,jsonRedes);
        Console.WriteLine("\nDatos guardados en el archivo ----------------------" + archivo);
    } else {Console.WriteLine("\nNo hay datos en memoria para guardar ---------------");}
}


void Report() {
    char resp;
    Console.Clear();
    Console.WriteLine("*** Reporte de red ---------------------------------");
    if(red is not null) {
        Console.WriteLine("*** Datos generales de la red ----------------------");
        Console.WriteLine($"{red}");
        Console.WriteLine($"{red.Resumen()}");

        Console.WriteLine("\n\n*** Datos generales de los nodos -------------------");
        red.Nodos.ForEach(p => Console.WriteLine(p.ToString()));
        Console.WriteLine(red.NumSaltos());

        Console.WriteLine("\n\n*** Vulnerabilidades por nodo ----------------------");
        foreach(Nodo.Nodo p in red.Nodos) {
            Console.WriteLine($"\n> IP: {p.Ip}, Tipo: {p.Tipo}\n");
            Console.WriteLine("Vulnerabilidades:");
            if(p.Vulnerabilidades.Count != 0) {
                p.Vulnerabilidades.ForEach(a => Console.WriteLine(a.ToString()));
            } else Console.WriteLine("No hay vulnerabilidades...");
        }
    } else {
        Console.WriteLine("\nNo hay datos en memoria !!!!!!!!");
        Console.Write("Deseas cargar datos para prueba (S/N)? -----------");
        resp = (Console.ReadLine()).ToUpper()[0];
        if(resp == 'S') Inicializar();
    }
}



int Menu() {
    int elec;
    Console.Clear();
    Console.WriteLine("----------------- MENU DE OPCIONES -----------------");
    Console.WriteLine("Reporte de datos ............................. [ 1 ]");
    Console.WriteLine("Agregar nodo ................................. [ 2 ]");
    Console.WriteLine("Agregar vulnerabilidad a un nodo ............. [ 3 ]");
    Console.WriteLine("Cargar los datos de un archivo ............... [ 4 ]");
    Console.WriteLine("Guardar los datos en un archivo .............. [ 5 ]");
    Console.WriteLine("Salir ........................................ [ 6 ]");
    Console.Write("Selecciona una opción:  ");
    elec = int.Parse(Console.ReadLine());
    return elec;
}


// ? Main
do {
    op = Menu();
    switch(op) {
        case 1 : Report(); break;
        case 2 : AddNode(); break;
        case 3 : AddVuln(); break;
        case 4 : LoadData(); break;
        case 5 : SaveData(); break;
        case 6 : Console.WriteLine("\n*********** Gracias por usar el programa ***********\n");break;
    }
    Console.WriteLine("\n***** Presiona una tecla para continuar *****");
    Console.ReadLine();
} while( op!= 6);