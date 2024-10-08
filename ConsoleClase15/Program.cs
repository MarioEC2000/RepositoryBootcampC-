// See https://aka.ms/new-console-template for more information
using ConsoleClase15.Entidades;

Console.WriteLine("Hello, World!");


List<EmpleadoBase> empleados = new List<EmpleadoBase>();


Gerente gerente = new Gerente()
{
    IdEmpleando = 1 ,
    NombreEmpleado = "Mariano Espinoza C",
    Puesto = "Gerente de Sistemas"
};

Desarrollador desarrollador = new Desarrollador()
{
    IdEmpleando = 2,
    NombreEmpleado = "Edwin S",
    Puesto = "Programador Java"
};


empleados.Add(desarrollador);
empleados.Add(gerente);

//foreach (var empleado in empleados)
//{
//    empleado.CalcularSueldo();
//    empleado.MostrarDetalle();
//}







static void MenuTest()
{
    string opcion = string.Empty;
    List<EmpleadoBase> empleados = new List<EmpleadoBase>();

    do
    {
        Console.WriteLine("Bienvenido!");
        Console.WriteLine("!=======================!");
        Console.WriteLine("Ingresa la opcion que deseas usar:");
        Console.WriteLine("1) Ingresar Empleado");
        Console.WriteLine("2) Mostrar Listado de Empleado");
        Console.WriteLine("3) Salir");
        opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1":
                Console.WriteLine("Ingresar NombreEmpleado");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingresar Puesto G (Gerente) / GR (Gerente RRHH)/D (Desarrollador) /C (Consultor)");
                string Puesto = Console.ReadLine();

                if (Puesto.ToUpper() == "G")
                {
                    Gerente empleadoNuevo = new Gerente()
                    {
                        IdEmpleando = empleados.Count() + 1,
                        NombreEmpleado = nombre,
                        Puesto = "Gerente"
                    };
                    empleados.Add(empleadoNuevo);
                }

                if (Puesto.ToUpper() == "GR")
                {
                    GerenteRRHH empleadoNuevo = new GerenteRRHH()
                    {
                        IdEmpleando = empleados.Count() + 1,
                        NombreEmpleado = nombre,
                        Puesto = "Gerente RRHH"
                    };
                    empleados.Add(empleadoNuevo);
                }

                if (Puesto.ToUpper() == "D")
                {
                    Desarrollador empleadoNuevo = new Desarrollador()
                    {
                        IdEmpleando = empleados.Count() + 1,
                        NombreEmpleado = nombre,
                        Puesto = "Desarrollador"
                    };
                    empleados.Add(empleadoNuevo);
                }

                if (Puesto.ToUpper() == "C")
                {
                    Consultor empleadoNuevo = new Consultor()
                    {
                        IdEmpleando = empleados.Count() + 1,
                        NombreEmpleado = nombre,
                        Puesto = "Consultor"
                    };
                    empleados.Add(empleadoNuevo);
                }
                break;

            case "2":
               
                decimal resultadoSueldoTotal = 0;
                Console.WriteLine("========== EMPLEADOS ==========");
                Console.WriteLine("Cantidad de empleados: "  + empleados.Count());
                
                
                foreach (var empleado in empleados)
                {
                    empleado.MostrarDetalle(empleado);
                    resultadoSueldoTotal += empleado.CalcularSueldo();
                }

                Console.WriteLine("Suma total de sueldos de empleados: " + resultadoSueldoTotal);


                break;
            default:
                break;
        }


    } while (!opcion.Equals("3"));

    Console.WriteLine("Adios!");
    Console.WriteLine("!=======================!");

}

MenuTest();
Console.Read();