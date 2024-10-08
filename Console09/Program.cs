// See https://aka.ms/new-console-template for more information


using Console09;

Estudiante estudianteTecsup = new Estudiante()
{
    Nombre = "Mariano",
    Apellidos = "Espinoza Cordova",
    FechaNacimiento = DateTime.Parse("2000-02-02 00:00:00")
};




//Console.WriteLine(estudianteTecsup.CalcularEdad());
//Console.WriteLine(estudianteTecsup.MostrarInfo());


//Polimorfismo trabajar con herencia y compartir caracteristicas en común en este caso CalcularArea
Cuadrado cuadrado = new Cuadrado() { lado = 10};
Triangulo triangulo = new Triangulo() { baseTriangulo = 15,altura = 20};
Rectangulo rectangulo = new Rectangulo() { baseRectangulo = 10 , altura = 14};   

//cuadrado.CalcularAreaCuadrado(10);
//triangulo.CalcularAreaTriangulo(15,10);
//rectangulo.CalcularAreaRectangulo(15,10);


//cuadrado.CalcularPerimetro();
//Console.WriteLine("Perimetro cuadrado "+ cuadrado.Perimetro);

//rectangulo.CalcularPerimetro();
//Console.WriteLine("Perimetro rectangulo "+ rectangulo.Perimetro);


List<Poligono> lstPoligono = new List<Poligono>();
lstPoligono.Add(cuadrado);
lstPoligono.Add(triangulo);
lstPoligono.Add(rectangulo);

foreach (var poligono in lstPoligono)
{
    poligono.CalcularArea();
    poligono.CalcularPerimetro();
    Console.WriteLine(poligono.Area);
}


