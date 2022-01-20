using System;
namespace CarritoDeCompras
{
    public class ProductoConDescuento: Producto
    {
        public ProductoConDescuento()
        {

        }

		public decimal  Descuento{ get; set; }

        //Se sobre escribe el metodo calcular descuento
        // y se implementa una funcionalidad en la clase hija
        public override decimal CalcularDescuento()
        {
            return this.Precio * (this.Descuento/100);
        }
    }

}
