using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace W5_Ejercicios.Models;
public class Empleado : Persona
{
 public string Posicion { get; set; }
 private double Salario { get; set; }

 public Empleado(string nombre, string apellido, string numeroDeIdentificacion, DateOnly fechanacimiento, string posicion, double salario) : base(nombre, apellido, numeroDeIdentificacion, fechanacimiento)
 {
    Posicion = posicion;
    Salario = salario;
 }

 private double CalcularBonificacion()
 {
    return Salario *= 0.1;
 }
 public override void MostrarInformacion()
 {
   Console.WriteLine("----------------------------------------");
   Console.WriteLine($"Información del Empleado:");
   Console.WriteLine($"Nombre: {Nombre} {Apellido}");
   Console.WriteLine($"Edad: {CalcularEdad()} años");
   Console.WriteLine($"Número de identificación: {NumeroDeIdentificacion}");
   Console.WriteLine($"Fecha de nacimiento: {FechaNacimiento:dd/MM/yyyy}");
   Console.WriteLine($"Posición: {Posicion}");
   Console.WriteLine($"Salario mas bonificacion: ${CalcularBonificacion()}");
   Console.WriteLine("----------------------------------------");
 }
}
