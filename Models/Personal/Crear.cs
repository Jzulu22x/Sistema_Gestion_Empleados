using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace W5_Ejercicios.Models;

public static class Crear
{
    public static Empleado CrearEmpleado()
    {
        Console.WriteLine("Ingresa el nombre del empleado.");
        string nombre = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nombre))
        {
            Interfaz.MostrarSeparador();
            Console.WriteLine("El nombre no puede estar vacío.");
            Interfaz.MostrarSeparador();

            Interfaz.EsperarTecla();
            return null;
        }

        Console.WriteLine("Ingresa el apellido del empleado.");
        string apellido = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(apellido))
        {
            Interfaz.MostrarSeparador();
            Console.WriteLine("El apellido no puede estar vacío.");
            Interfaz.MostrarSeparador();
            Interfaz.EsperarTecla();
            return null;
            ;
        }

        Console.WriteLine("Ingresa el numero de identificacion.");
        string numero = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(numero))
        {
            if (Convert.ToBoolean(Empresa.ListaEmpleados.Any(e => e.ObtenerNumeroIdentificacion() == numero)))
            {
                Interfaz.MostrarSeparador();
                Console.WriteLine($"El número de identificación {numero} ya se encuentra registrado.");
                Interfaz.MostrarSeparador();
                Interfaz.EsperarTecla();
                return null;

            }
        }
        else
        {
            Console.WriteLine("El número de identificación no puede estar vacío.");
            Interfaz.EsperarTecla();
            return null;


        }
        Console.WriteLine("Ingresa la fecha de nacimiento (dd/MM/yyyy).");
        DateOnly fechaNacimiento;
        if (!DateOnly.TryParse(Console.ReadLine(), out fechaNacimiento))
        {
            Console.WriteLine("La fecha de nacimiento ingresada no es válida.");
            Interfaz.EsperarTecla();
            return null;
            ;
        }

        Console.WriteLine("Ingresa la posición del empleado.");
        string posicion = Console.ReadLine().ToLower();
        if (string.IsNullOrWhiteSpace(posicion))
        {
            Console.WriteLine("La posi78901234Gción no puede estar vacía.");
            Interfaz.EsperarTecla();
            return null;
        }

        Console.WriteLine("Ingresa el salario del empleado.");
        double salario;
        if (!double.TryParse(Console.ReadLine(), out salario))
        {
            Console.WriteLine("El salario ingresado no es válido.");
            Interfaz.EsperarTecla();
            return null;
        }

        var empleadoAgregar = new Empleado(nombre, apellido, numero, fechaNacimiento, posicion, salario);
        return empleadoAgregar;
    }
    public static Cliente CrearCliente()
    {
        Console.WriteLine("Ingresa el nombre del cliente.");
        string nombreCliente = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nombreCliente))
        {
            Console.WriteLine("El nombre no puede estar vacío.");
            Interfaz.EsperarTecla();
            return null;
        }
        Console.WriteLine("Ingresa el apellido del cliente.");
        string apellidoCliente = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(apellidoCliente))
        {
            Console.WriteLine("El apellido no puede estar vacío.");
            Interfaz.EsperarTecla();
            return null;
        }
        Console.WriteLine("Ingresa el número de identificación del cliente.");
        string numeroDeIdentificacionCliente = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(numeroDeIdentificacionCliente))
        {
            Console.WriteLine("El número de identificación no puede estar vacío.");
            Interfaz.EsperarTecla();
            return null;
        }
        Console.WriteLine("Ingresa la fecha de nacimiento del cliente");
        DateOnly fechaNacimientoCliente;
        if (!DateOnly.TryParse(Console.ReadLine(), out fechaNacimientoCliente))
        {
            Console.WriteLine("La fecha de nacimiento ingresada no es válida.");
            Interfaz.EsperarTecla();
            return null;
        }

        Console.WriteLine("Ingresa el Email del cliente");
        string emailCliente = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(emailCliente))
        {
            Console.WriteLine("El Email no puede estar vacío.");
            Interfaz.EsperarTecla();
            return null;
        }

        Console.WriteLine("Ingresa el Teléfono del cliente");
        string telefonoCliente = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(telefonoCliente))
        {
            Console.WriteLine("El Teléfono no puede estar vacío.");
            Interfaz.EsperarTecla();
            return null;
        }

        var nuevoCliente = new Cliente(nombreCliente, apellidoCliente, numeroDeIdentificacionCliente, fechaNacimientoCliente, emailCliente, telefonoCliente);
        return nuevoCliente;
    }
    public static (Empleado nuevoEmpleado, string numeroDeIdentificacionAActualizar) EditarEmpleado()
    {
        Console.WriteLine("Ingresa el número de identificación del empleado a actualizar.");
        string numeroDeIdentificacionAActualizar = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(numeroDeIdentificacionAActualizar))
        {
            Console.WriteLine("El número de identificación no puede estar vacío.");
            Interfaz.EsperarTecla();

            return (null, null);
        }

        if (!Convert.ToBoolean(Empresa.ListaEmpleados.Any(e => e.ObtenerNumeroIdentificacion() == numeroDeIdentificacionAActualizar)))
        {
            Console.WriteLine($"El empleado con el número de identificación {numeroDeIdentificacionAActualizar} no se encuentra registrado.");
            return (null, null);
        }
        foreach (var empleado in Empresa.ListaEmpleados)
        {
            if(empleado.ObtenerNumeroIdentificacion() == numeroDeIdentificacionAActualizar)
            {
                empleado.MostrarInformacion();
            }
        }

        Console.WriteLine("Ingresa el nuevo nombre del empleado.");
        string nombreNuevo = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nombreNuevo))
        {
            Console.WriteLine("El nombre no puede estar vacío.");
            Interfaz.EsperarTecla();
            return (null, null);
        }
        Console.WriteLine("Ingresa el nuevo apellido del empleado.");
        string apellidoNuevo = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(apellidoNuevo))
        {
            Console.WriteLine("El apellido no puede estar vacío.");
            Interfaz.EsperarTecla();
            return (null, null);
        }
        Console.WriteLine("Ingresa la nueva fecha de nacimiento (dd/MM/yyyy).");
        DateOnly fechaNacimientoNuevo;
        if (!DateOnly.TryParse(Console.ReadLine(), out fechaNacimientoNuevo))
        {
            Console.WriteLine("La fecha de nacimiento ingresada no es válida.");
            Interfaz.EsperarTecla();
            return (null, null);
        }
        Console.WriteLine("Ingresa el nuevo numero de documento del empleado.");
        string numeroDeIdentificacionNuevo = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(numeroDeIdentificacionNuevo))
        {
            if (Convert.ToBoolean(Empresa.ListaEmpleados.Any(e => e.ObtenerNumeroIdentificacion() == numeroDeIdentificacionNuevo)))
            {
                Console.WriteLine($"El empleado con el número de identificación {numeroDeIdentificacionAActualizar} no se encuentra registrado.");

                return (null, null);
            }
        }
        else
        {
            Console.WriteLine("El número de identificación no puede estar vacío.");
            Interfaz.EsperarTecla();

            return (null, null);
        }
        Console.WriteLine("Ingresa la nueva posición del empleado.");
        string posicionNuevo = Console.ReadLine().ToLower();
        if (string.IsNullOrWhiteSpace(posicionNuevo))
        {
            Console.WriteLine("La posición no puede estar vacía.");
            Interfaz.EsperarTecla(); ;
            return (null, null);
        }
        Console.WriteLine("Ingresa el nuevo salario del empleado.");
        double salarioNuevo;
        if (!double.TryParse(Console.ReadLine(), out salarioNuevo))
        {
            Console.WriteLine("El salario ingresado no es válido.");
            Interfaz.EsperarTecla();
            return (null, null);
        }
        var nuevoEmpleado = new Empleado(nombreNuevo, apellidoNuevo, numeroDeIdentificacionNuevo, fechaNacimientoNuevo, posicionNuevo, salarioNuevo);
        return (nuevoEmpleado, numeroDeIdentificacionAActualizar);
    }
}