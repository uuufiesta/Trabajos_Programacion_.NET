// * Programa principal de empleado orientado a objetos

// $ Importamos la clase a nuestro programa
using Empleado_Class;

// * Instanciamos y reservamos memoria
Empleado empleado01 = new Empleado();
Empleado empleado02 = new Empleado();

// * Asignamos valores a traves de las propiedades
empleado01.Nombre = "Mario";
empleado01.Edad = 22;
empleado02.Nombre = "Jose";
empleado02.Edad = 73;

// * Llamamos a los metodos
empleado01.ImprimirDato();
empleado02.ImprimirDato();