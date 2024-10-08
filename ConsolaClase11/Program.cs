


using ConsolaClase11;



//Empresa empresa = new Empresa()
//{
//    Nombre = "TRAMARSA S.A",
//    Direccion = "Edificio leuro miraflores",
//    Trabajadores = new List<Trabajador>()
//    { 
//        new Trabajador()
//        {
//            Nombre = "Mario",
//            Sueldo = 3000,
//            Apellidos = "E C",
//            NumeroDocumento = 757575757
//        },
//        new Trabajador()
//        {
//            Nombre = "Marck",
//            Sueldo = 500000,
//            Apellidos = "Zucaritas",
//            NumeroDocumento = 757575757
//        }
//    }

//};

//foreach (var trabajador in empresa.Trabajadores)
//{
//    Console.WriteLine("Descuento de sueldo: "+trabajador.DescuentoSueldo());
//}
List<IDescuento> descuentos = new();

descuentos.Add(new Producto() { Resultado = 1000});
descuentos.Add(new Servicio() { Resultado = 1000 });


foreach (var item in descuentos)
{
   
    Console.WriteLine(item.AplicarDescuento());
}