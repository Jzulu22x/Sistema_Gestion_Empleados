using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace W5_Ejercicios.Models;
public static class Interfaz
{
    public static void EsperarTecla()
    {
        Console.WriteLine();
        Console.WriteLine("Presiona culquier tecla para continuar");
        Console.ReadKey();
    }
    public static void MostrarTitulo(string titulo)
    {
        Console.WriteLine(new string('-', 40));
        Console.WriteLine(titulo.ToUpper());
        Console.WriteLine(new string('-', 40));
        Console.WriteLine();

    }
    public static void MostrarPie(string pie)
    {
        Console.WriteLine();
        Console.WriteLine(new string('#', 40));
        Console.WriteLine(pie);
        Console.WriteLine(new string('#', 40));
        Console.WriteLine();
    }
    public static void MostrarSeparador()
    {
        Console.WriteLine();
        Console.WriteLine(new string('-', 40));
        Console.WriteLine();
    }
}
