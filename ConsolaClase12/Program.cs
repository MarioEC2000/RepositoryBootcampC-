// See https://aka.ms/new-console-template for more information
using ConsolaClase12.Ejercicio01;
using ConsolaClase12.Ejercicio02;
using ConsolaClase12.Notificaciones;

Console.WriteLine("Hello, World!");

List<INotificacion> notificaciones = new List<INotificacion>();
notificaciones.Add(new Email());
notificaciones.Add(new SMS());

//Polimorfismo comparten un caracteristica en comun pero tienen diferentes loguicas 

//foreach (var notificacion in notificaciones)
//{
//    notificacion.Enviar();
//}



List<IPedidos> pedidos = new List<IPedidos>();

pedidos.Add(new Producto()
{
    Proveedor = new Provedor()
    { RazonSocial = "Metro", RUC = "13212312" }
});
pedidos.Add(new Producto()
{
    Proveedor = new Provedor()
    { RazonSocial = "Plaza Vea", RUC = "324234324" }
});


//foreach (var pedido in pedidos)
//{
//    pedido.EnviarPedido();
//}


//Empresa empresa = new Empresa() { Empleados = new List<IPagable>() };
//empresa.AgregarEmpleado(new EmpleadoPorHoras() { CostoPorHora = 100, NumeroHoras = 2 });
//empresa.AgregarEmpleado(new EmpleadoContratado() { PagoporContrato = 10000 });
//empresa.AgregarEmpleado(new EmpleadoTiempoCompleto() { salarioFijo = 500 });


//Console.WriteLine(empresa.CalcularPagosEmpleados());

Empresa empresa = new Empresa() { Clientes = new List<IDeuda>() };
empresa.AgregarCliente(new ClienteClasico() { CostoServicio = 2000 });
empresa.AgregarCliente(new ClienteVIP() { CostoServicio = 4000 , DescuentoVip = 500});


Console.WriteLine(empresa.CalcularDeudaClientes());