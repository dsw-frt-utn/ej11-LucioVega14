using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();

        casoList.AgregarAlumno(new Alumno(1, "Lujan Cano", 8.5));
        casoList.AgregarAlumno(new Alumno(2, "Nacho Ferreyra", 7.0));
        casoList.AgregarAlumno(new Alumno(3, "Martina Manzur", 9.2));

        Console.WriteLine("-- Lista de alumnos --");
        foreach (Alumno a in casoList.GetAlumnos())
            Console.WriteLine(a);

        Alumno encontrado = casoList.BuscarPorNombre("Nacho Ferreyra");
        Console.WriteLine($"\nBúsqueda 'Nacho Ferreyra': {encontrado}");

        Alumno noEncontrado = casoList.BuscarPorNombre("Lucio Vega");
        Console.WriteLine($"Búsqueda 'Lucio Vega': {(noEncontrado == null ? "No existe" : noEncontrado.ToString())}");

        casoList.EliminarAlumno(encontrado);
        Console.WriteLine("\n-- Lista tras eliminar a Nacho --");
        foreach (Alumno a in casoList.GetAlumnos())
            Console.WriteLine(a);

        casoList.EliminarEnPosicion(0);
        Console.WriteLine("\n-- Lista tras eliminar el primer elemento --");
        foreach (Alumno a in casoList.GetAlumnos())
            Console.WriteLine(a);
    }
    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary casoDictionary = new CasoDictionary();

        casoDictionary.AgregarAlumno(new Alumno(101, "Lujan Cano", 8.5));
        casoDictionary.AgregarAlumno(new Alumno(102, "Nacho Ferreyra", 7.0));
        casoDictionary.AgregarAlumno(new Alumno(103, "Martina Manzur", 9.2));

        Console.WriteLine("-- Diccionario de alumnos --");
        foreach (var par in casoDictionary.GetAlumnos())
            Console.WriteLine($"Legajo {par.Key}: {par.Value}");

        Alumno encontrado = casoDictionary.BuscarPorLegajo(103);
        Console.WriteLine($"\nBúsqueda legajo 103: {encontrado}");

        Alumno noEncontrado = casoDictionary.BuscarPorLegajo(850);
        Console.WriteLine($"Búsqueda legajo 850: {(noEncontrado == null ? "No existe" : noEncontrado.ToString())}");

        casoDictionary.EliminarAlumno(102);
        Console.WriteLine("\n-- Diccionario tras eliminar legajo 102 --");
        foreach (var par in casoDictionary.GetAlumnos())
            Console.WriteLine($"Legajo {par.Key}: {par.Value}");
    }


    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq();

        Console.WriteLine($"Primer libro:   {casoLinq.GetPrimero()}");
        Console.WriteLine($"Último libro:   {casoLinq.GetUltimo()}");
        Console.WriteLine($"Total precios:  {casoLinq.GetTotalPrecios():C}");
        Console.WriteLine($"Promedio:       {casoLinq.GetPromedioPrecios():F2}");

        Console.WriteLine("\n-- Libros con Id > 15 --");
        foreach (Libro l in casoLinq.GetListById())
            Console.WriteLine(l.Titulo);

        Console.WriteLine("\n-- Títulos y precios --");
        foreach (string s in casoLinq.GetLibros())
            Console.WriteLine(s);

        Console.WriteLine($"\nMayor precio:  {casoLinq.GetMayorPrecio()}");
        Console.WriteLine($"Menor precio:  {casoLinq.GetMenorPrecio()}");

        Console.WriteLine("\n-- Libros sobre el promedio --");
        foreach (Libro l in casoLinq.GetMayorPromedio())
            Console.WriteLine(l.Titulo);

        Console.WriteLine("\n-- Libros ordenados por título (desc) --");
        foreach (Libro l in casoLinq.GetOrdenadosPorTitulo())
            Console.WriteLine(l.Titulo);
    }
}
