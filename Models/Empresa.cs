using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace W5_Ejercicios.Models;
public  class Empresa
{
    public string Nombre { get; set; }
    public string Direccion { get; set; } 
    public static List<Empleado> ListaEmpleados { get; set; } = new List<Empleado>();
    public static List<Cliente> ListaClientes { get; set; } = new List<Cliente>();

    public Empresa(string nombreEmpresa, string direccion)
    {
        Nombre = nombreEmpresa;   
        Direccion = direccion;
    }

    public static void AgregarEmpleado(Empleado empleado)
    {
        ListaEmpleados.Add(empleado);
        Console.WriteLine($"Empleado agregado exitosamente.");
    }

    public static void EliminarEmpleado(string NumeroDeIdentificacion)
    {
        
        if (Convert.ToBoolean(ListaEmpleados.Any(e => e.ObtenerNumeroIdentificacion() == NumeroDeIdentificacion)))
        {
            var empleadoAEliminar = ListaEmpleados.FirstOrDefault(e => e.ObtenerNumeroIdentificacion() == NumeroDeIdentificacion);
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
                empleado.MostrarInformacion();
            }
        }
    }

    public static void ActualizarEmpleado(string NumeroDeIdentificacion, Empleado empleado)
    {
        if (Convert.ToBoolean(ListaEmpleados.Any(e => e.ObtenerNumeroIdentificacion() == NumeroDeIdentificacion)))
        {
            var empleadoAEliminar = ListaEmpleados.FirstOrDefault(e => e.ObtenerNumeroIdentificacion() == NumeroDeIdentificacion);
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
        if (Convert.ToBoolean(ListaEmpleados.Any(e => e.ObtenerNumeroIdentificacion() == NumeroDeIdentificacion)))
        {
            var empleadoEncontrado = ListaEmpleados.FirstOrDefault(e => e.ObtenerNumeroIdentificacion() == NumeroDeIdentificacion);
            empleadoEncontrado.MostrarInformacion();
        }
        else
        {
            Console.WriteLine($"No se encontró un empleado con el número de identificación {NumeroDeIdentificacion}.");
        }
    }

    public static void MostrarEmpleadosPorCargo(string posicion)
    {
        if(Convert.ToBoolean(ListaEmpleados.Any(p => p.Posicion == posicion)))
        {
            var listaPosiciones = ListaEmpleados.Where(p => p.Posicion.Equals(posicion, StringComparison.OrdinalIgnoreCase)).ToList();
            Console.WriteLine($"Empleados con la posición {posicion}:");
            foreach (var empleado in listaPosiciones)
            {
                empleado.MostrarInformacion();
            }
        }
        else {
            Console.WriteLine($"No hay empleados con la posición {posicion}.");
        }
    }

    //Creacion metodos de la clase cliente
     public static void AgregarCliente(Cliente cliente)
    {
        ListaClientes.Add(cliente);
        Console.WriteLine($"Cliente agregado exitosamente.");
    }

    public static void EliminarCliente(string NumeroDeIdentificacion)
    {
        
        if (Convert.ToBoolean(ListaClientes.Any(e => e.ObtenerNumeroIdentificacion() == NumeroDeIdentificacion)))
        {
            var clienteAEliminar = ListaClientes.FirstOrDefault(e => e.ObtenerNumeroIdentificacion() == NumeroDeIdentificacion);
            ListaClientes.Remove(clienteAEliminar);
            Console.WriteLine($"Cliente con número de identificación {NumeroDeIdentificacion} eliminado exitosamente.");
        }
        else{
            Console.WriteLine($"No se encontró un cliente con el número de identificación {NumeroDeIdentificacion}.");
        }
    }

    public static void MostrarTodosLosClientes()
    {
        if (ListaClientes.Count == 0)
        {
            Console.WriteLine("No hay empleados registrados.");
        }
        else
        {
            Console.WriteLine("Empleados registrados:");
            foreach (var cliente in ListaClientes)
            {
                cliente.MostrarInformacion();
            }
        }
        Interfaz.MostrarPie("Se Mostro la info de los clientes");
    }
}
