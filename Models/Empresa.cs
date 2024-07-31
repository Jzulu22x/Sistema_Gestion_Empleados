using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace W5_Ejercicios.Models;
public static class Empresa
{
    public static string Nombre { get; set; } = "Empresa XYZ";
    public static string Direccion { get; set; } = "Calle 123, Casa 456";
    public static List<Empleado> ListaEmpleados { get; set; } = new List<Empleado>();

    public static void AgregarEmpleado(Empleado empleado)
    {
        ListaEmpleados.Add(empleado);
        Console.WriteLine($"Empleado {empleado.Nombre} {empleado.Apellido} agregado exitosamente.");
    }

    public static void EliminarEmpleado(string NumeroDeIdentificacion)
    {
        
        if (Convert.ToBoolean(ListaEmpleados.Where(e => e.NumeroDeIdentificacion == NumeroDeIdentificacion)))
        {
            var empleadoAEliminar = ListaEmpleados.FirstOrDefault(e => e.NumeroDeIdentificacion == NumeroDeIdentificacion);
            ListaEmpleados.Remove(empleadoAEliminar);
            Console.WriteLine($"Empleado con número de identificación {NumeroDeIdentificacion} eliminado exitosamente.");
        }
        else{
            Console.WriteLine($"No se encontró un empleado con el número de identificación {NumeroDeIdentificacion}.");
        }
    }

    public static void MostrarTodosLosEmpleados()
    {
        if (ListaEmpleados.Count == 0)
        {
            Console.WriteLine("No hay empleados registrados.");
        }
        else
        {
            Console.WriteLine("Empleados registrados:");
            foreach (var empleado in ListaEmpleados)
            {
                empleado.MostrarInfomacion();
            }
        }
    }

    public static void ActualizarEmpleado(string NumeroDeIdentificacion, Empleado empleado)
    {
        if (Convert.ToBoolean(ListaEmpleados.Where(e => e.NumeroDeIdentificacion == NumeroDeIdentificacion)))
        {
            var empleadoAEliminar = ListaEmpleados.FirstOrDefault(e => e.NumeroDeIdentificacion == NumeroDeIdentificacion);
            ListaEmpleados.Remove(empleadoAEliminar);
            ListaEmpleados.Add(empleado);
            Console.WriteLine($"Empleado con número de identificación {NumeroDeIdentificacion} actualizado exitosamente.");
        }
        else
        {
            Console.WriteLine($"No se encontró un empleado con el número de identificación {NumeroDeIdentificacion}.");
        }
    }

    public static void BuscarEmpleado(string NumeroDeIdentificacion)
    {
        if (Convert.ToBoolean(ListaEmpleados.Where(e => e.NumeroDeIdentificacion == NumeroDeIdentificacion)))
        {
            var empleadoEncontrado = ListaEmpleados.FirstOrDefault(e => e.NumeroDeIdentificacion == NumeroDeIdentificacion);
            empleadoEncontrado.MostrarInfomacion();
        }
        else
        {
            Console.WriteLine($"No se encontró un empleado con el número de identificación {NumeroDeIdentificacion}.");
        }
    }

    public static void MostrarEmpleadosPorCargo(string posicion)
    {
        if(Convert.ToBoolean(ListaEmpleados.Where(p => p.Posicion == posicion)))
        {
            var listaPosiciones = ListaEmpleados.Where(p => p.Posicion == posicion).ToList();
            Console.WriteLine($"Empleados con la posición {posicion}:");
            foreach (var empleado in listaPosiciones)
            {
                empleado.MostrarInfomacion();
            }
        }
        else {
            Console.WriteLine($"No hay empleados con la posición {posicion}.");
        }
    }
}
