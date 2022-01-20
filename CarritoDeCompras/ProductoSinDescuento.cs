using System;
namespace CarritoDeCompras
{
    public class ProductoSinDescuento : Producto
    {
        public ProductoSinDescuento()
        {

        }

        public DateTime FechaInicioDescuento { get; set; }

        //Se sobre escribe el metodo calcular descuento
        // y se implementa una funcionalidad en la clase hija
        public override decimal CalcularDescuento()
        {
            return 100;
        }

        /*
        public int CalcularFechaDescuiento()
        {
            TimeSpan timespan = DateTime.Today - this.FechaInicioDescuento;
            int dia = timespan.Days;
            int fecha = dia / 365;
            return fecha;
        }*/

    }
    

}


