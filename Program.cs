using W5_Ejercicios.Models;

bool run = true;

Empleado empleado1 = new Empleado("Juan", "Pérez", "12345678A", new DateOnly(1985, 5, 20), "gerente", 50000.00);
Empleado empleado2 = new Empleado("María", "López", "23456789B", new DateOnly(1990, 7, 15), "desarrollador", 45000.00);
Empleado empleado3 = new Empleado("Carlos", "García", "34567890C", new DateOnly(1982, 3, 10), "desarrollador", 47000.00);
Empleado empleado4 = new Empleado("Ana", "Martínez", "45678901D", new DateOnly(1995, 11, 25), "diseñadora", 43000.00);
Empleado empleado5 = new Empleado("Luis", "Rodríguez", "56789012E", new DateOnly(1987, 6, 30), "tester", 40000.00);
Empleado empleado6 = new Empleado("Elena", "Sánchez", "67890123F", new DateOnly(1992, 9, 5), "soporte tecnico", 42000.00);
Empleado empleado7 = new Empleado("Jorge", "Fernández", "78901234G", new DateOnly(1989, 1, 12), "marketing", 46000.00);
Empleado empleado8 = new Empleado("Laura", "Gómez", "89012345H", new DateOnly(1986, 4, 18), "marketing", 44000.00);
Empleado empleado9 = new Empleado("Pedro", "Díaz", "90123456I", new DateOnly(1984, 8, 22), "finanzas", 48000.00);
Empleado empleado10 = new Empleado("Marta", "Ruiz", "01234567J", new DateOnly(1991, 12, 28), "legal", 49000.00);

Empresa.AgregarEmpleado(empleado1);
Empresa.AgregarEmpleado(empleado2);
Empresa.AgregarEmpleado(empleado3);
Empresa.AgregarEmpleado(empleado4);
Empresa.AgregarEmpleado(empleado5);
Empresa.AgregarEmpleado(empleado6);
Empresa.AgregarEmpleado(empleado7);
Empresa.AgregarEmpleado(empleado8);
Empresa.AgregarEmpleado(empleado9);
Empresa.AgregarEmpleado(empleado10);

while (run)
{
    Console.Clear();
    Console.WriteLine("Bienvenido al gestor de empleados");
    Console.WriteLine("1. Agregar empleado");
    Console.WriteLine("2. Eliminar empleado");
    Console.WriteLine("3. Mostrar Empleados");
    Console.WriteLine("5. Buscar empleado");
    Console.WriteLine("6. Mostrar empleados por posición");
    Console.WriteLine("7. Actualizar empleado");
    Console.WriteLine("8. Salir");
    Console.WriteLine();

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
            if (string.IsNullOrWhiteSpace(nombre))
            {
                Console.WriteLine("El nombre no puede estar vacío.");
                Console.WriteLine();
                Console.WriteLine("Presiona culquier tecla para continuar");
                Console.ReadKey();
                break;
            }

            Console.WriteLine("Ingresa el apellido del empleado.");
            string apellido = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(apellido))
            {
                Console.WriteLine("El apellido no puede estar vacío.");
                Console.WriteLine();
                Console.WriteLine("Presiona culquier tecla para continuar");
                Console.ReadKey();
                break;
            }

            Console.WriteLine("Ingresa el numero de identificacion.");
            string numero = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(numero))
            {
                if (Convert.ToBoolean(Empresa.ListaEmpleados.Any(e => e.NumeroDeIdentificacion == numero)))
                {
                    Console.WriteLine($"El número de identificación {numero} ya se encuentra registrado.");
                    Console.WriteLine();
                    Console.WriteLine("Presiona culquier tecla para continuar");
                    Console.ReadKey();
                    break;
                }
            }
            else
            {
                Console.WriteLine("El número de identificación no puede estar vacío.");
                Console.WriteLine();
                Console.WriteLine("Presiona culquier tecla para continuar");
                Console.ReadKey();
                break;

            }

            Console.WriteLine("Ingresa la fecha de nacimiento (dd/MM/yyyy).");
            DateOnly fechaNacimiento;
            if (!DateOnly.TryParse(Console.ReadLine(), out fechaNacimiento))
            {
                Console.WriteLine("La fecha de nacimiento ingresada no es válida.");
                Console.WriteLine();
                Console.WriteLine("Presiona culquier tecla para continuar");
                Console.ReadKey();
                break;
            }

            Console.WriteLine("Ingresa la posición del empleado.");
            string posicion = Console.ReadLine().ToLower();
            if (string.IsNullOrWhiteSpace(posicion))
            {
                Console.WriteLine("La posi78901234Gción no puede estar vacía.");
                Console.WriteLine();
                Console.WriteLine("Presiona culquier tecla para continuar");
                Console.ReadKey();
                break;
            }

            Console.WriteLine("Ingresa el salario del empleado.");
            double salario;
            if (!double.TryParse(Console.ReadLine(), out salario))
            {
                Console.WriteLine("El salario ingresado no es válido.");
                Console.WriteLine();
                Console.WriteLine("Presiona culquier tecla para continuar");
                Console.ReadKey();
                break;
            }

            var empleadoAgregar = new Empleado(nombre, apellido, numero, fechaNacimiento, posicion, salario);
            Empresa.AgregarEmpleado(empleadoAgregar);

            Console.WriteLine();
            Console.WriteLine("Presiona culquier tecla para continuar");
            Console.ReadKey();
            break;

        case 2:
            Console.WriteLine("Eliminar Empleado.");
            Console.WriteLine();
            Console.WriteLine("Ingresa el número de identificación del empleado a eliminar.");
            string numeroDeIdentificacionAEliminar = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(numeroDeIdentificacionAEliminar))
            {
                Console.WriteLine("El número de identificación no puede estar vacío.");
                Console.WriteLine();
                Console.WriteLine("Presiona culquier tecla para continuar");
                Console.ReadKey();
                break;
            }
            Empresa.EliminarEmpleado(numeroDeIdentificacionAEliminar);
            Console.WriteLine();
            Console.WriteLine("Presiona culquier tecla para continuar");
            Console.ReadKey();
            break;

        case 3:
            Empresa.MostrarTodosLosEmpleados();
            Console.WriteLine();
            Console.WriteLine("Presiona culquier tecla para continuar");
            Console.ReadKey();
            break;

        case 5:
            Console.WriteLine("Buscar Empleado.");
            Console.WriteLine();
            Console.WriteLine("Ingresa el número de identificación del empleado a buscar.");
            string numeroDeIdentificacionABuscar = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(numeroDeIdentificacionABuscar))
            {
                Console.WriteLine("El número de identificación no puede estar vacío.");
                Console.WriteLine();
                Console.WriteLine("Presiona culquier tecla para continuar");
                Console.ReadKey();
                break;
            }
            Console.WriteLine();
            Empresa.BuscarEmpleado(numeroDeIdentificacionABuscar);
            Console.WriteLine();
            Console.WriteLine("Presiona culquier tecla para continuar");
            Console.ReadKey();
            break;
        case 6:
            Console.WriteLine("Mostrar Empleados por posición.");
            Console.WriteLine();
            Console.WriteLine("Ingresa la posición de los empleados a mostrar.");
            string posicionAMostrar = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(posicionAMostrar))
            {
                Console.WriteLine("La posición no puede estar vacía.");
                Console.WriteLine();
                Console.WriteLine("Presiona culquier tecla para continuar");
                Console.ReadKey();
                break;
            }

            Empresa.MostrarEmpleadosPorCargo(posicionAMostrar);
            Console.WriteLine();
            Console.WriteLine("Presiona culquier tecla para continuar");
            Console.ReadKey();
            break;
        case 7:
            Console.WriteLine("Actualizar Empleado.");
            Console.WriteLine();
            Console.WriteLine("Ingresa el número de identificación del empleado a actualizar.");
            string numeroDeIdentificacionAActualizar = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(numeroDeIdentificacionAActualizar))
            {
                Console.WriteLine("El número de identificación no puede estar vacío.");
                Console.WriteLine();
                Console.WriteLine("Presiona culquier tecla para continuar");
                Console.ReadKey();
                break;
            }


            Console.WriteLine("Ingresa el nuevo nombre del empleado.");
            string nombreNuevo = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nombreNuevo))
            {
                Console.WriteLine("El nombre no puede estar vacío.");
                Console.WriteLine();
                Console.WriteLine("Presiona culquier tecla para continuar");
                Console.ReadKey();
                break;
            }
            Console.WriteLine("Ingresa el nuevo apellido del empleado.");
            string apellidoNuevo = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(apellidoNuevo))
            {
                Console.WriteLine("El apellido no puede estar vacío.");
                Console.WriteLine();
                Console.WriteLine("Presiona culquier tecla para continuar");
                Console.ReadKey();
                break;
            }
            Console.WriteLine("Ingresa la nueva fecha de nacimiento (dd/MM/yyyy).");
            DateOnly fechaNacimientoNuevo;
            if (!DateOnly.TryParse(Console.ReadLine(), out fechaNacimientoNuevo))
            {
                Console.WriteLine("La fecha de nacimiento ingresada no es válida.");
                Console.WriteLine();
                Console.WriteLine("Presiona culquier tecla para continuar");
                Console.ReadKey();
                break;
            }
            Console.WriteLine("Ingresa el nuevo numero de documento del empleado.");
            string numeroDeIdentificacionNuevo = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(numeroDeIdentificacionNuevo))
            {
                if (Convert.ToBoolean(Empresa.ListaEmpleados.Any(e => e.NumeroDeIdentificacion == numeroDeIdentificacionNuevo)))
                {
                    Console.WriteLine($"El número de identificación {numeroDeIdentificacionNuevo} ya se encuentra registrado.");
                    Console.WriteLine();
                    Console.WriteLine("Presiona culquier tecla para continuar");
                    Console.ReadKey();
                    break;
                }
            }
            else
            {
                Console.WriteLine("El número de identificación no puede estar vacío.");
                Console.WriteLine();
                Console.WriteLine("Presiona culquier tecla para continuar");
                Console.ReadKey();
                break;
            }
            Console.WriteLine("Ingresa la nueva posición del empleado.");
            string posicionNuevo = Console.ReadLine().ToLower();
            if (string.IsNullOrWhiteSpace(posicionNuevo))
            {
                Console.WriteLine("La posición no puede estar vacía.");
                Console.WriteLine();
                Console.WriteLine("Presiona culquier tecla para continuar");
                Console.ReadKey();
                break;
            }
            Console.WriteLine("Ingresa el nuevo salario del empleado.");
            double salarioNuevo;
            if (!double.TryParse(Console.ReadLine(), out salarioNuevo))
            {
                Console.WriteLine("El salario ingresado no es válido.");
                Console.WriteLine();
                Console.WriteLine("Presiona culquier tecla para continuar");
                Console.ReadKey();
                break;
            }
            var nuevoEmpleado = new Empleado(nombreNuevo, apellidoNuevo, numeroDeIdentificacionNuevo, fechaNacimientoNuevo, posicionNuevo, salarioNuevo);
            Empresa.ActualizarEmpleado(numeroDeIdentificacionAActualizar, nuevoEmpleado);
            Console.WriteLine();
            Console.WriteLine("Presiona culquier tecla para continuar");
            Console.ReadKey();
            break;

        case 8:
            run = false;
            Console.WriteLine("Gracias por utilizar el gestor de empleados.");
            break;

        default:
            Console.WriteLine("Opción inválida. Intente nuevamente.");
            Console.WriteLine();
            Console.WriteLine("Presiona culquier tecla para continuar");
            Console.ReadKey();
            break;
    }
}