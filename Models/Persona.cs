using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace W5_Ejercicios.Models;
public abstract class Persona
{
    private Guid Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string NumeroDeIdentificacion { get; set; }
    public DateOnly FechaNacimiento { get; set; }

    public Persona(string nombre, string apellido, string numeroDeIdentificacion, DateOnly fechanacimiento)
    {
        Id = Guid.NewGuid();
        Nombre = nombre;
        Apellido = apellido;
        NumeroDeIdentificacion = numeroDeIdentificacion;
        FechaNacimiento = fechanacimiento;
    }
    public byte CalcularEdad()
    {
        var edad = DateTime.Now.Year - FechaNacimiento.Year;
        return Convert.ToByte(edad);
    }

    public virtual void MostrarInfomacion()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Apellido: {Apellido}");
        Console.WriteLine($"Número de Identificación: {NumeroDeIdentificacion}");
        Console.WriteLine($"Fecha de Nacimiento: {FechaNacimiento.ToShortDateString()}");
        Console.WriteLine($"Edad: {CalcularEdad()} años");
    }  
}
