// See https://aka.ms/new-console-template for more information



//Calculos();
Primos(5);
//SumarImpares(4);


static void Calculos(){

    int base_r = 5;
    int altura = 10;

    Console.WriteLine("El area de rectangulo es : " + CalcularArea(base_r, altura)); 
    Console.WriteLine("El perimetro es : " + CalcularPermitro(base_r, altura)); 
}




static int CalcularArea(int n1, int n2) => n1 * n2;
static int CalcularPermitro(int n1, int n2) =>(2 * n1) + (2 * n2);

static void SumarPares(int cantidad)
{
    int result = 0;

    for (int i = 1; i <= cantidad; i++)
    {

        if (i % 2 == 0)
        {
            result = result + i;
        }
                     
    }
    Console.WriteLine(result);
    Console.ReadKey();
}


static void SumarImpares(int cantidad)
{
    int result = 0;

    for (int i = 1; i <= cantidad; i++)
    {

        if (i % 2 != 0)
        {
            result = result + i;
            
        }

    }

    Console.WriteLine(result);
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

    while (indice == 1)
    {

        Console.WriteLine("");
    }
}