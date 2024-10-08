// See https://aka.ms/new-console-template for more information
using ConsoleClase13;

Console.WriteLine("Hello, World!");


Console.WriteLine("Por favor ingresa un indice ");
int indice = int.Parse(Console.ReadLine());
IngresarIndice(indice);

static void IngresarIndice(int indice)
{

    int[] arreglo = new int[4] { 10, 20, 30, 40 };
	try
	{
        Console.WriteLine($"El valor del indice seleccionado es : {arreglo[indice]}");
    }
	catch (IndexOutOfRangeException)
	{
        Console.WriteLine("El indice esta fuera fuera del rango");
	}

   
}

//Crear una función que te pida ingresar la nota de un estudiante y que te lance una excepcion personalizada para controlar notas válidas,
//    si la nota es válida debes mostrarla, si ingresan una cadena en lugar de un número también debe ser controlado
static void IngresaraNotas()
{
    int cantidadNotas = 0;
    int indice = 0;
    List<int> Notas = new List<int>();

    try
    {
        Console.WriteLine("Cuantas notas deseas ingresar?");
        cantidadNotas = int.Parse(Console.ReadLine());

        while (cantidadNotas > indice)
        {
            Console.WriteLine("Ingresar la nota " + (indice + 1));
            int nota = int.Parse(Console.ReadLine());

            if (nota > 20 || nota < 0)
            {
                throw new IsValidNoteException();
            }

            Notas.Add(nota);
            indice++;
        }

    }
    catch (IsValidNoteException)
    {
        Console.WriteLine("La nota esta fuera del rango ");
    }
    catch (Exception ) 
    {
        Console.WriteLine("Ocurrio un error");
    }


}
