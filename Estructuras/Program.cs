// See https://aka.ms/new-console-template for more information


using static System.Runtime.InteropServices.JavaScript.JSType;

List<string> lstNombres = new();
List<int> lstEdades = new();



lstEdades.Add(24);
lstNombres.Add("Mariano");


lstEdades.Add(23);
lstNombres.Add("Maria");


Dictionary<string, int> Persona = new();

Persona.Add(lstNombres[0], lstEdades[0]);

//foreach (int edades in lstEdades)
//{
//    Persona.Add(" ", edades);

//    foreach (string nombre in lstNombres)
//    {
//        Persona.Add(nombre, 0);
//    }

//}


Console.WriteLine(Persona.Values.ToString());