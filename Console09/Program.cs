// See https://aka.ms/new-console-template for more information


using Console09;

Estudiante estudianteTecsup = new Estudiante()
{
    Nombre = "Mariano",
    Apellidos = "Espinoza Cordova",
    FechaNacimiento = DateTime.Parse("2000-02-02 00:00:00")
};

//Console.WriteLine(estudianteTecsup.CalcularEdad()); 
Console.WriteLine(estudianteTecsup.MostrarInfo()); 