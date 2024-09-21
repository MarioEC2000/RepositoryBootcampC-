// See https://aka.ms/new-console-template for more information
using CodigoClase08;

Console.WriteLine("Hello, World!");

//Trabajador trabajador = new Trabajador()
//{
//    Nombres = "Mariano",
//    Apellidos = "EC",
//    TipoDocumento = "DNI",
//    SueldoBruto = 3000
//};

//var descuento = trabajador.CalcularDescuento();
//Console.WriteLine(trabajador.CalcularSueldoNeto(descuento));


Estudiante estudiante1 = new Estudiante()
{
    Nombres = "Mariano",
    Apellidos = "Espinoza Cordova",
    Materias = new List<string>(),
    Notas = new List<decimal>()
};

estudiante1.Materias.Add("Matematicas");
estudiante1.Materias.Add("Fisica");
estudiante1.Materias.Add("Arte");


estudiante1.Notas.Add(19);
estudiante1.Notas.Add(10);
estudiante1.Notas.Add(20);

Console.WriteLine($"El promedio es : {estudiante1.CalcularPromedio()}");
Console.Read();
