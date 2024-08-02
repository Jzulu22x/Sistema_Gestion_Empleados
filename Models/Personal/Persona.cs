using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace W5_Ejercicios.Models;
public abstract class Persona
{
    protected Guid Id { get; set; }
    protected string Nombre { get; set; }
    protected string Apellido { get; set; }
    protected string NumeroDeIdentificacion { get; set; }
    protected DateOnly FechaNacimiento { get; set; }

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
    public string ObtenerNumeroIdentificacion()
    {
        return NumeroDeIdentificacion;
    }
    public abstract void MostrarInformacion();   
}
