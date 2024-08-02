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

Cliente cliente1 = new Cliente("Juan", "Pérez", "ID001", new DateOnly(1990, 1, 15), "juan.perez@example.com", "123-456-7890");
Cliente cliente2 = new Cliente("María", "García", "ID002", new DateOnly(1985, 5, 23), "maria.garcia@example.com", "123-456-7891");
Cliente cliente3 = new Cliente("Elena", "Ramírez", "ID010", new DateOnly(1994, 6, 25), "elena.ramirez@example.com", "123-456-7899");
Cliente cliente4 = new Cliente("Carlos", "Martínez", "ID003", new DateOnly(1992, 3, 10), "carlos.martinez@example.com", "123-456-7892");
Cliente cliente5 = new Cliente("Ana", "López", "ID004", new DateOnly(1988, 7, 30), "ana.lopez@example.com", "123-456-7893");
Cliente cliente6 = new Cliente("Luis", "González", "ID005", new DateOnly(1995, 9, 5), "luis.gonzalez@example.com", "123-456-7894");
Cliente cliente7 = new Cliente("Laura", "Hernández", "ID006", new DateOnly(1993, 12, 12), "laura.hernandez@example.com", "123-456-7895");
Cliente cliente8 = new Cliente("Miguel", "Rodríguez", "ID007", new DateOnly(1980, 11, 18), "miguel.rodriguez@example.com", "123-456-7896");
Cliente cliente9 = new Cliente("Sara", "Fernández", "ID008", new DateOnly(1991, 4, 22), "sara.fernandez@example.com", "123-456-7897");
Cliente cliente10 = new Cliente("David", "Sánchez", "ID009", new DateOnly(1987, 8, 16), "david.sanchez@example.com", "123-456-7898");

Empresa.AgregarCliente(cliente1);
Empresa.AgregarCliente(cliente2);
Empresa.AgregarCliente(cliente3);
Empresa.AgregarCliente(cliente4);
Empresa.AgregarCliente(cliente5);
Empresa.AgregarCliente(cliente6);
Empresa.AgregarCliente(cliente7);
Empresa.AgregarCliente(cliente8);
Empresa.AgregarCliente(cliente9);
Empresa.AgregarCliente(cliente10);

var riwi = new Empresa("riwi","De la moda outlet");

while (run)
{
    Console.Clear();
    Interfaz.MostrarTitulo("Gestion Empresa");
    Console.WriteLine("1. Agregar empleado");
    Console.WriteLine("2. Eliminar empleado");
    Console.WriteLine("3. Mostrar Empleados");
    Console.WriteLine("4. Buscar empleado");
    Console.WriteLine("5. Mostrar empleados por posición");
    Console.WriteLine("6. Actualizar empleado");
    Console.WriteLine("7. Agregar Cliente");
    Console.WriteLine("8. Eliminar Cliente");
    Console.WriteLine("9. Mostrar Clientes");
    Console.WriteLine("10. Salir");
    Interfaz.MostrarSeparador();

    int opcion;

    if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 10)
    {
        Console.WriteLine("Opción inválida. Intente nuevamente.");
        continue;
    }
    switch (opcion)
    {
        case 1:
            Console.Clear();
            Interfaz.MostrarTitulo("Agregar Empleado.");
            Console.WriteLine();

            var result = Crear.CrearEmpleado();
            if (result != null)
            {
                Empresa.AgregarEmpleado(result);
            }
            else
            {
                Console.WriteLine("No se pudo crear el empleado.");
            }

            Interfaz.EsperarTecla();
            break;

        case 2:
            Console.Clear();
            Interfaz.MostrarTitulo("Eliminar Empleado.");
            Console.WriteLine();
            Console.WriteLine("Ingresa el número de identificación del empleado a eliminar.");
            string numeroDeIdentificacionAEliminar = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(numeroDeIdentificacionAEliminar))
            {
                Console.WriteLine("El número de identificación no puede estar vacío.");
                Interfaz.EsperarTecla();
                break;
            }
            Empresa.EliminarEmpleado(numeroDeIdentificacionAEliminar);
            Interfaz.EsperarTecla();
            break;

        case 3:
            Console.Clear();
            Interfaz.MostrarTitulo("Mostrar Empleados.");
            Empresa.MostrarTodosLosEmpleados();
            Interfaz.EsperarTecla();
            break;

        case 4:
            Console.Clear();
            Interfaz.MostrarTitulo("Buscar Empleado.");
            Console.WriteLine();
            Console.WriteLine("Ingresa el número de identificación del empleado a buscar.");
            string numeroDeIdentificacionABuscar = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(numeroDeIdentificacionABuscar))
            {
                Console.WriteLine("El número de identificación no puede estar vacío.");
                Interfaz.EsperarTecla();
                break;
            }
            Console.WriteLine();
            Empresa.BuscarEmpleado(numeroDeIdentificacionABuscar);
            Interfaz.EsperarTecla();
            break;

        case 5:
            Console.Clear();
            Interfaz.MostrarTitulo("Mostrar Empleados por posición.");
            Console.WriteLine();
            Console.WriteLine("Ingresa la posición de los empleados a mostrar.");
            string posicionAMostrar = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(posicionAMostrar))
            {
                Console.WriteLine("La posición no puede estar vacía.");
                Interfaz.EsperarTecla();
                break;
            }

            Empresa.MostrarEmpleadosPorCargo(posicionAMostrar);
            Interfaz.EsperarTecla();
            break;

        case 6:
            Console.Clear();
            Interfaz.MostrarTitulo("Actualizar Empleado");
            Console.WriteLine();
            var (nuevoEmpleado, numeroDeIdentificacionAActualizar) = Crear.EditarEmpleado();
            Empresa.ActualizarEmpleado(numeroDeIdentificacionAActualizar, nuevoEmpleado);
            Interfaz.EsperarTecla();
            break;

        case 7:
            Console.Clear();
            Interfaz.MostrarTitulo("Agregar Cliente.");
            Console.WriteLine();
            var resultClient = Crear.CrearCliente();
            Empresa.AgregarCliente(resultClient);
            Interfaz.EsperarTecla();
            break;

        case 8:
            Console.Clear();
            Interfaz.MostrarTitulo("Eliminar Cliente.");
            Console.WriteLine();
            Console.WriteLine("Ingresa el número de identificación del cliente a eliminar.");
            string numeroDeIdentificacionAEliminarEmpleado = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(numeroDeIdentificacionAEliminarEmpleado))
            {
                Console.WriteLine("El número de identificación no puede estar vacío.");
                Interfaz.EsperarTecla();
                break;
            }
            Empresa.EliminarCliente(numeroDeIdentificacionAEliminarEmpleado);
            Interfaz.EsperarTecla();
            break;

        case 9:
            Console.Clear();
            Interfaz.MostrarTitulo("Mostrar Clientes.");
            Console.WriteLine();
            Empresa.MostrarTodosLosClientes();
            Interfaz.EsperarTecla();
            break;

        case 10:
            run = false;
            Interfaz.MostrarSeparador();
            Console.WriteLine("Gracias por utilizar el gestor de empleados.");
            Interfaz.MostrarSeparador();

            break;

        default:
            Interfaz.MostrarSeparador();
            Console.WriteLine("Opción inválida. Intente nuevamente.");
            Interfaz.EsperarTecla();
            Interfaz.MostrarSeparador();
            break;
    }
}