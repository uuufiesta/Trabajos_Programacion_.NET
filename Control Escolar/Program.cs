// Aqui se realiza la ejecucion del programa principal del control escolar

using Alumno_p87;
using Escuela_p87;
using Microsoft.VisualBasic.CompilerServices;
using Profesor_p87;

Escuela escuela = new Escuela(nombre: "Universidad Autonoma de Zacatecas", encargado: "El de la guayabera", domicilio: "Carretera guadalajara km 206");
escuela.AgregarProfesor(new Profesor(nombre: "Jose Perez", fechaIng: DateTime.Now, grupo: "1A", materia: "Fisica", salario: 12000));
escuela.AgregarProfesor(new Profesor(nombre: "Sergio Perez", fechaIng: DateTime.Now, grupo: "8B", materia: "Algebra", salario: 11000));
escuela.AgregarProfesor(new Profesor(nombre: "Fernando Alonso", fechaIng: DateTime.Now, grupo: "5C", materia: "Programacion", salario: 13000));
escuela.AgregarProfesor(new Profesor(nombre: "Chick Hicks", fechaIng: DateTime.Now, grupo: "3A", materia: "Artes", salario: 14000));

escuela.Profesores[0].AgregarAlumno(new Alumno(nombre: "Alex Zuniga", edad: 18, fechaIng: DateTime.Now, becado: true, calif: new List<int> { 7, 7, 7 }));
escuela.Profesores[0].AgregarAlumno(new Alumno(nombre: "Miguel Sanchez", edad: 20, fechaIng: DateTime.Now, becado: false, calif: new List<int> { 8, 8, 8 }));
escuela.Profesores[0].AgregarAlumno(new Alumno(nombre: "Angel Naguib", edad: 21, fechaIng: DateTime.Now, becado: true, calif: new List<int> { 9, 9, 9 }));
escuela.Profesores[1].AgregarAlumno(new Alumno(nombre: "Charles Leclerc", edad: 18, fechaIng: DateTime.Now, becado: true, calif: new List<int> { 6, 6, 6 }));
escuela.Profesores[1].AgregarAlumno(new Alumno(nombre: "Kevin Martinez", edad: 21, fechaIng: DateTime.Now, becado: false, calif: new List<int> { 8, 8, 8 }));
escuela.Profesores[2].AgregarAlumno(new Alumno(nombre: "Victor Matrinez", edad: 22, fechaIng: DateTime.Now, becado: true, calif: new List<int> { 7, 7, 7 }));

Console.WriteLine("\n Datos generales de la escuela:");
Console.WriteLine($"{escuela}");

Console.WriteLine("\n Profesores:");
foreach (Profesor p in escuela.Profesores)
    Console.WriteLine(p.ToString());

Console.WriteLine("\n Alumnos por profesor:");
foreach (Profesor p in escuela.Profesores)
{
    Console.WriteLine($"\n Nombre: {p.Nombre}, Grupo: {p.Grupo}\n");
    if (p.Alumnos.Count != 0)
    {
        p.Alumnos.ForEach(a => Console.WriteLine(a.ToString()));
    }
    else Console.WriteLine("No tiene alumnos aun");
}