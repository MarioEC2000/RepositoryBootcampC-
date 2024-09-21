// See https://aka.ms/new-console-template for more information



//Calculos();
//Primos(5);
//SumarPares(4);
//SumarImpares(4);
//TablaAlrevez(1);
//Console.WriteLine(SumarNaturales(4));
//SumarCuadrados(9);
//Menu();


//ValidarNotas(-5);


using System.Collections.Generic;

static void Calculos(){

    int base_r = 5;
    int altura = 10;

    Console.WriteLine("El area de rectangulo es : " + CalcularArea(base_r, altura)); 
    Console.WriteLine("El perimetro es : " + CalcularPermitro(base_r, altura)); 
}



static int SumarNaturales(int indice)
{
    int suma = 0;

    for (int i = 1; i <= indice; i++)
    {
        suma = suma + i;
    }

    return suma;
}
static int CalcularArea(int n1, int n2) => n1 * n2;
static int CalcularPermitro(int n1, int n2) =>(2 * n1) + (2 * n2);

static void SumarPares(int cantidad)
{
    int result = 0;

    for (int i = 1; i <= cantidad; i++)
    {
        var numeroPar = i % 2;

        if (numeroPar == 0)
        {
            result = result + i;
            Console.WriteLine("Es numero par: " +i);
        }
    }

    Console.WriteLine("Sumatoria de numeros pares : " + result);
    Console.ReadKey();
}


static void SumarImpares(int cantidad)
{
    int result = 0;

    for (int i = 1; i <= cantidad; i++)
    {
        var numeroPar = i % 2;

        if (numeroPar == 1)
        {
            result = result + i;
            Console.WriteLine("Es numero par: " + i);
        }
    }

    Console.WriteLine("Sumatoria de numeros pares : " + result);
    Console.ReadKey();
}



static void Primos(int n1)
{
    int indice = 1;
    int suma = 0;
    while (indice <=n1)
    {
        suma = indice * indice;
        indice++;
        Console.WriteLine(suma);
    }
}

static void TablaAlrevez(int n1)
{
    int indice = 12;

    while (indice != 0)
    {

        Console.WriteLine($"{n1} X {indice} = {n1 * indice}");
        indice--;

    }
}

static void SumarCuadrados(int numero)
{
    int sumarCuadrados = 0;
    int indice = 1;
    int numeroCuadrado = 0;

    while (indice < numero)
    {
        numeroCuadrado = indice * indice;
        sumarCuadrados = sumarCuadrados + numeroCuadrado;
        Console.WriteLine("es un numero cuadrado " + numeroCuadrado);
        indice ++;
    }

    Console.WriteLine("Suma total de numeros cuadrados" + sumarCuadrados);
}

static void ValidarNotas(int nota)
{   
    do
    {
       Console.WriteLine("Ingrese una nota valida");
       nota = Int32.Parse(Console.ReadLine());
        
    } while (nota < 0 || nota > 20);

    Console.WriteLine("su nota es " + nota);
}

static void Menu()
{
    bool condicion = false;
    double sueldo = 0;
    do
    {
        Console.WriteLine($"1) 5ta Categoria");
        Console.WriteLine($"2) 4ta Categoria");
        Console.WriteLine($"3) Salir");

        string opcion = Console.ReadLine();

        Console.WriteLine($"Ingresa tu sueldo");
        sueldo = Convert.ToDouble(Console.ReadLine());


        switch (opcion)
        {
            case "1":
                sueldo = sueldo - (sueldo * 0.14);
                break;
            case "2":
                sueldo = sueldo - (sueldo * 0.08);
                break;
            default:
                condicion = true;
                break;

        }

        Console.WriteLine("Su sueldo es :"+ sueldo);
        Console.WriteLine("================");

    } while (condicion);
}



//ImprimirNotas();

//int[] notas = { 1, 2, 3 };
//int[] notas2 = { 1, 2, 3,4,5 };
//ArregloPersonalizado(notas);
//ArregloPersonalizado(notas2);

static void ImprimirNotas()
{
    int[] notas = new int[5];

    notas[0] = 18;
    notas[1] = 16;
    notas[2] = 20;
    notas[3] = 09;
    notas[4] = 05;

    Console.WriteLine("Mayor: "+ notas.Max());

    foreach (int i in notas)
        Console.WriteLine(i);
}


static void ArregloPersonalizado(int[] array )
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}



//ImprimirSueldos();

static void ImprimirSueldos()
{
    int[] sueldos = new int[5];
    int indice = 0;
    int totalSueldos = 0;

    while (sueldos.Count() > indice)
    {
        Console.WriteLine("Ingresa el sueldo " + (indice+1));
        sueldos[indice] = Int32.Parse(Console.ReadLine());
        indice++;
    }

    for (int i = 0; i < sueldos.Length; i++)
    {
        totalSueldos = totalSueldos + sueldos[i];
    }

    Console.WriteLine("Total sueldo "+totalSueldos);
    Console.WriteLine("Promedio Sueldo " + (totalSueldos / sueldos.Count()));

}


//int[] notas = new int[5];
//notas = IngresarNotas(notas);
//Console.WriteLine($"Promedio {CalcularPromedio(notas)}"); 


//foreach (var item in notas)
//{
//    Console.WriteLine(item);
//}

static int[] IngresarNotas(int[] notas)
{
    for (int i = 0; i < notas.Length; i++)
    {
        Console.WriteLine("Ingresar nota "+(i+1));
        notas[i] = Int32.Parse(Console.ReadLine());
    }

    return notas;
}

static int CalcularNotaMayor(int[] notas)
{
    int notaMayor = 0;

    for (int i = 0; i < notas.Length; i++)
    {
        if (notaMayor < notas[i])
        {
            notaMayor = notas[i];    
        }
    }

    Console.WriteLine("Mayor : " + notaMayor);
    return notaMayor;
}

static int CalcularNotaMenor(int[] notas)
{
    int notaMenor = notas[0];

    for (int i = 0; i < notas.Length; i++)
    {
        if (notas[i] < notaMenor)
        {
            notaMenor = notas[i];
        }
    }

    Console.WriteLine("Menor : " + notaMenor);
    return notaMenor;
}

static int CalcularPromedio(int[] notas)
{
    int sumanotas = 0;
    int notaPromedio = 0;

    for (int i = 0; i < notas.Length; i++)
    {
        sumanotas = sumanotas + notas[i];
    }

    notaPromedio = (sumanotas - CalcularNotaMenor(notas) - CalcularNotaMayor(notas)) / (notas.Length - 2);

    return notaPromedio;
}


//Console.WriteLine("Ingresar cantidad de nombres :");
//var cantidadNombres = Int32.Parse(Console.ReadLine());
//var lstNombres = IngresarNombres(cantidadNombres);
//var nombreEncontrado1 = lstNombres.IndexOf("Mariano");
//Console.WriteLine(nombreEncontrado1);
//MostrarNombres(lstNombres);



static List<string> IngresarNombres(int cantidadNombres)
{
    List<string> nombres = new List<string>();

    for (int i = 0; i < cantidadNombres; i++)
    {
        Console.WriteLine("Ingresar nombre " + (i + 1));
        nombres.Add(Console.ReadLine());
    }

    return nombres;
}

static void MostrarNombres(List<string> lstNombres)
{
    lstNombres.Sort();
    Console.WriteLine("------------LISTADO----------");
    foreach (var item in lstNombres)
    {
        Console.WriteLine(item);
    }
}



//int cantidad = 5;
//SumarNaturalesListado(cantidad);
static void SumarNaturalesListado(int cantidad)
{
    int suma = 0;   
    for (int i = 0; i < cantidad; i++)
    {
        suma += i;
        Console.WriteLine(suma);
    }
    Console.WriteLine("Total :"+suma);
}


//int cantidadNotas = 3;
//var lstNotas = IngresarCalificaciones(cantidadNotas);
//Console.WriteLine("Promedio :" + CalcularPromedioNotas(lstNotas, cantidadNotas)); 


static List<float> IngresarCalificaciones(int cantidad)
{
    cantidad += 1;
    List<float> lstNotas = new();
    int indice = 1;

    do
    {
        Console.WriteLine("Diguita la nota " + indice);
        lstNotas.Add(float.Parse(Console.ReadLine()));
        indice++;

    } while (cantidad > indice);
    return lstNotas;
}

static float CalcularPromedioNotas(List<float> lstNotas,int cantidadNotas )
{
    float suma = 0;

    foreach (var nota in lstNotas)
    {
        suma += nota;
    }

    return suma / cantidadNotas;
}



//var lstNotas = IngresarNotas2(5);
//MayorNota(lstNotas);
//MenorNota(lstNotas);

static List<double> IngresarNotas2(int ctnNotas)
{
    int indice = 0;
    List<double> lstNotas = new();

    do
    {
        Console.WriteLine("Ingresar nota " + (indice + 1));
        var nota = double.Parse(Console.ReadLine());
        lstNotas.Add(nota);
        indice++;   

    } while (indice < ctnNotas);

    return lstNotas;
}

static void MayorNota(List<double> lstNotas)
{
    Console.WriteLine("Nota mayor :" +lstNotas.Max()); 
}

static void MenorNota(List<double> lstNotas)
{
    Console.WriteLine("Nota menor :" + lstNotas.Min());
}

static void PromedioNotas(List<double> lstNotas)
{
    Console.WriteLine("Nota menor :" + lstNotas.Average());
}


//var notasAlumnos = IngresarNotasArray(2);
//MayorNotaArray(notasAlumnos,2);
//MenorNotaArray(notasAlumnos,2);

//foreach (var item in notasAlumnos)
//{
//    Console.WriteLine(item);
//}


static decimal[,] IngresarNotasArray(int ctnAlumnosNotas)
{
    int indice = 0;
    decimal[,] arrayAlumnosNotas = new decimal[ctnAlumnosNotas, 2];
    //List<double> lstNotas = new();

    do
    {
        Console.WriteLine("Ingresar nota para el alumno #" + (indice + 1));
        var nota = decimal.Parse(Console.ReadLine());
        arrayAlumnosNotas[indice,0] = nota;
        arrayAlumnosNotas[indice, 1] = (indice +1);
        indice++;

    } while (indice < ctnAlumnosNotas);

    return arrayAlumnosNotas;
}

static void MayorNotaArray(decimal[,] array,int ctnNotas)
{
    decimal mayor = 0;

    for (int i = 0; i < ctnNotas; i++)
    {
        if (mayor < array[i, 0]  )
        {
            mayor = array[i, 0];
        }
    }

    Console.WriteLine("La nota mayor es "+ mayor);
}

static void MenorNotaArray(decimal[,] array, int ctnNotas)
{
    decimal menor = array[0, 0];

    for (int i = 0; i < ctnNotas; i++)
    {
        if (menor > array[i, 0])
        {
            menor = array[i, 0];
        }
    }

    Console.WriteLine("La nota menor es " + menor);
}

//static void PromedioNotas(List<double> lstNotas)
//{
//    Console.WriteLine("Nota menor :" + lstNotas.Average());
//}

MenuTest();

static void MenuTest()
{
    string opcion = string.Empty;

    do
    {
        Console.WriteLine("Bienvenido!");
        Console.WriteLine("!=======================!");
        Console.WriteLine("Ingresa la opcion que deseas usar:");
        Console.WriteLine("1) Suma");
        Console.WriteLine("2) Resta");
        Console.WriteLine("3) Multiplicacion");
        Console.WriteLine("4) Division");
        Console.WriteLine("5) Raiz Cuadrada");
        Console.WriteLine("6) Salir");
        opcion = Console.ReadLine();

        if (!opcion.Equals("6"))
        {
            Calculos2(opcion);
        }


    } while (!opcion.Equals("6"));

    Console.WriteLine("Adios!");
    Console.WriteLine("!=======================!");

}

static void Calculos2(string opcion)
{
    Console.WriteLine("Ingresar el n1 : ");
    int n1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingresar el n2 : ");
    int n2 = int.Parse(Console.ReadLine());

    switch (opcion)
    {
        case "1":
            Console.WriteLine("Resultado de Suma "+ (n1 + n2)); 
            break;
        case "2":
            Console.WriteLine("Resultado de resta " + (n1 - n2));
            break;
        case "3":
            Console.WriteLine("Resultado de multiplicacion " + (n1 * n2));
            break;
        case "4":
            Console.WriteLine("Resultado de division " + (n1 / n2));
            break;
        case "5":
            Console.WriteLine("Resultado de Suma " + (n1 + n2));
            break;
        default:
            Console.WriteLine("Opcion no encontrada");
            break;
    }
}