


using HtmlAgilityPack;

public class Program
{
    static async Task Main(string[] args)
    {
        string url = "https://www.sbs.gob.pe/app/pp/sistip_portal/paginas/publicacion/tipocambiopromedio.aspx";        
        HttpClient client = new HttpClient();
        var response = await client.GetStringAsync(url);

        if (response != null)
        {
            var html = new HtmlDocument();    
            html.LoadHtml(response);
            var table = html.DocumentNode.SelectSingleNode("//table[@id='ctl00_cphContent_rgTipoCambio_ctl00']");
            var row = html.DocumentNode.SelectSingleNode(".//tr[@id='ctl00_cphContent_rgTipoCambio_ctl00__0']");
            var nombreMoneda = html.DocumentNode.SelectSingleNode(".//td[@class='APLI_fila3']");     
            var montoMoneda = html.DocumentNode.SelectNodes(".//td[@class='APLI_fila2']");
            var moneda = nombreMoneda.InnerText.Trim();
            var compra = montoMoneda[0].InnerText.Trim();
            var venta = montoMoneda[1].InnerText.Trim();
            Console.WriteLine(moneda);
            Console.WriteLine(compra);
            Console.WriteLine(venta);


        }
    }
}