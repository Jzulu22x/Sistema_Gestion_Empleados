using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace W5_Ejercicios.Models;
public class Cliente : Persona
{
    public string Email { get; set; }
    public string Telefono { get; set; }

    public Cliente(string nombre, string apellido, string numeroDeIdentificacion, DateOnly fechanacimiento, string email, string telefono) : base (nombre, apellido, numeroDeIdentificacion, fechanacimiento)
    {
        Email = email;
        Telefono = telefono;
    }

    public override void MostrarInfomacion()
    {
        Console.WriteLine($"Información del Cliente:");
        base.MostrarInfomacion();
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Teléfono: {Telefono}");
        Console.WriteLine("----------------------------------------");
    }
}
