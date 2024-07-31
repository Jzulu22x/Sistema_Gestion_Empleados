using W5_Ejercicios.Models;

bool run = true;

while (run)
{
    Console.WriteLine("Bienvenido al gestor de empleados");
    Console.WriteLine("1. Agregar empleado");
    Console.WriteLine("2. Eliminar empleado");
    Console.WriteLine("3.Mostrar Empleados");
    Console.WriteLine("5. Buscar empleado");
    Console.WriteLine("6. Mostrar empleados por posición");
    Console.WriteLine("7. Actualizar empleado");

    int opcion;

    if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 7)
    {
        Console.WriteLine("Opción inválida. Intente nuevamente.");
        continue;
    }
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Agregar Empleado.");
            Console.WriteLine();

            Console.WriteLine("Ingresa el nombre del empleado.");
            string nombre = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(nombre))
            {
                Console.WriteLine("El nombre no puede estar vacío.");
                break;
            }

            Console.WriteLine("Ingresa el apellido del empleado.");
            string apellido = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(apellido))
            {
                Console.WriteLine("El apellido no puede estar vacío.");
                break;
            }

            Console.WriteLine("Ingresa el numero de identificacion.");
            string numero = Console.ReadLine();
            if(!string.IsNullOrWhiteSpace(numero))
            {
                if(Convert.ToBoolean(Empresa.ListaEmpleados.Where(e => e.NumeroDeIdentificacion == numero)))
                {
                    Console.WriteLine($"El número de identificación {numero} ya se encuentra registrado.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("El número de identificación no puede estar vacío.");
                break;

            }

            Console.WriteLine("Ingresa la fecha de nacimiento (dd/MM/yyyy).");
            DateOnly fechaNacimiento;
            if(!DateOnly.TryParse(Console.ReadLine(), out fechaNacimiento))
            {
                Console.WriteLine("La fecha de nacimiento ingresada no es válida.");
                break;
            }

            Console.WriteLine("Ingresa la posición del empleado.");
            string posicion = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(posicion))
            {
                Console.WriteLine("La posición no puede estar vacía.");
                break;
            }

            Console.WriteLine("Ingresa el salario del empleado.");
            double salario;
            if(!double.TryParse(Console.ReadLine(), out salario))
            {
                Console.WriteLine("El salario ingresado no es válido.");
                break;
            }

            var empleadoAgregar = new Empleado(nombre, apellido, numero, fechaNacimiento, posicion, salario);
            Empresa.AgregarEmpleado(empleadoAgregar);
            break;

        case 2:
            Console.WriteLine("Eliminar Empleado.");
            Console.WriteLine();
            Console.WriteLine("Ingresa el número de identificación del empleado a eliminar.");
            string numeroDeIdentificacionAEliminar = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(numeroDeIdentificacionAEliminar))
            {
                Console.WriteLine("El número de identificación no puede estar vacío.");
                break;
            }
            Empresa.EliminarEmpleado(numeroDeIdentificacionAEliminar);
            break;

        case 3:
            Empresa.MostrarTodosLosEmpleados();
            break;

        case 5:
            Console.WriteLine("Buscar Empleado.");
            Console.WriteLine();
            Console.WriteLine("Ingresa el número de identificación del empleado a buscar.");
            string numeroDeIdentificacionABuscar = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(numeroDeIdentificacionABuscar))
            {
                Console.WriteLine("El número de identificación no puede estar vacío.");
                break;
            }
            Empresa.BuscarEmpleado(numeroDeIdentificacionABuscar);
            break;
        case 6:
            Console.WriteLine("Mostrar Empleados por posición.");
            Console.WriteLine();
            Console.WriteLine("Ingresa la posición de los empleados a mostrar.");
            string posicionAMostrar = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(posicionAMostrar))
            {
                Console.WriteLine("La posición no puede estar vacía.");
                break;
            }

            Empresa.MostrarEmpleadosPorCargo(posicionAMostrar);
            break;
        case 7:
            Console.WriteLine("Actualizar Empleado.");
            Console.WriteLine();
            Console.WriteLine("Ingresa el número de identificación del empleado a actualizar.");
            string numeroDeIdentificacionAActualizar = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(numeroDeIdentificacionAActualizar))
            {
                Console.WriteLine("El número de identificación no puede estar vacío.");
                break;
            }
            

            Console.WriteLine("Ingresa el nuevo nombre del empleado.");
            string nombreNuevo = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(nombreNuevo))
            {
                Console.WriteLine("El nombre no puede estar vacío.");
                break;
            }
            Console.WriteLine("Ingresa el nuevo apellido del empleado.");
            string apellidoNuevo = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(apellidoNuevo))
            {
                Console.WriteLine("El apellido no puede estar vacío.");
                break;
            }
            Console.WriteLine("Ingresa la nueva fecha de nacimiento (dd/MM/yyyy).");
            DateOnly fechaNacimientoNuevo;
            if(!DateOnly.TryParse(Console.ReadLine(), out fechaNacimientoNuevo))
            {
                Console.WriteLine("La fecha de nacimiento ingresada no es válida.");
                break;
            }
            Console.WriteLine("Ingresa el nuevo numero de documento del empleado.");
            string numeroDeIdentificacionNuevo = Console.ReadLine();
            if(!string.IsNullOrWhiteSpace(numeroDeIdentificacionNuevo))
            {
                if(Convert.ToBoolean(Empresa.ListaEmpleados.Where(e => e.NumeroDeIdentificacion == numeroDeIdentificacionNuevo)))
                {
                    Console.WriteLine($"El número de identificación {numeroDeIdentificacionNuevo} ya se encuentra registrado.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("El número de identificación no puede estar vacío.");
                break;
            }
            Console.WriteLine("Ingresa la nueva posición del empleado.");
            string posicionNuevo = Console.ReadLine();
            if(string.IsNullOrWhiteSpace(posicionNuevo))
            {
                Console.WriteLine("La posición no puede estar vacía.");
                break;
            }
            Console.WriteLine("Ingresa el nuevo salario del empleado.");
            double salarioNuevo;
            if(!double.TryParse(Console.ReadLine(), out salarioNuevo))
            {
                Console.WriteLine("El salario ingresado no es válido.");
                break;
            }
            var nuevoEmpleado = new Empleado(nombreNuevo, apellidoNuevo, numeroDeIdentificacionNuevo, fechaNacimientoNuevo, posicionNuevo, salarioNuevo);
            Empresa.ActualizarEmpleado(numeroDeIdentificacionAActualizar, nuevoEmpleado);
            break;
            
        case 8:
            run = false;
            Console.WriteLine("Gracias por utilizar el gestor de empleados.");
            break;
        default:
            Console.WriteLine("Opción inválida. Intente nuevamente.");
            break;
    }
}