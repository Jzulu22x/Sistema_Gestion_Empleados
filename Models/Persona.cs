using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace W5_Ejercicios.Models;
public class Persona
{
    private Guid Id { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string NumeroDeIdentificacion { get; set; }
    public DateTime FechaNacimiento { get; set; }

    public Persona(string nombre, string apellido, string numeroDeIdentificacion, DateTime fechanacimiento)
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
}
