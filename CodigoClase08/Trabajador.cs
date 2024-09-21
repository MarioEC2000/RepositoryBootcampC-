namespace CodigoClase08
{
    public class Trabajador
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string TipoDocumento { get; set; }
        public double SueldoBruto { get; set; }

        public double CalcularDescuento()
        {
            return SueldoBruto * 0.08;
        }

        public double CalcularSueldoNeto(double descuento)
        {
            return SueldoBruto - descuento;
        }
    }
}
