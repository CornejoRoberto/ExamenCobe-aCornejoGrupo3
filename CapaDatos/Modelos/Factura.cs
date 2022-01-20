using System;
using System.Collections.Generic;

namespace CapaDatos.Modelos
{
    public class Factura
    {
        //Cabecera de Factura
        public CabeceraFactura Cabecera { get; set; }
        //Detalle de carrito
        //Lista de detalle de carrito (Producto y la cantidad)
        public List<DetalleFactura> Detalle { get; set; }

        public Factura()
        {
            this.Detalle = new List<DetalleFactura>();
        }

        


        public void CalcularSubtotal()
        {
            //Acumulador o sumador
            decimal subtotal = 0;
            foreach (DetalleFactura item in this.Detalle)
            {
                subtotal = subtotal + (item.Cantidad * item.ProductoCarrito.Precio);
            }

            //this.SubTotal = subtotal;
        }

        public void CalcularIVA()
        {

        }

        public void CalcularDescuento()
        {
            
        }

        public void CalcularTotal()
        {
            //this.Total = this.SubTotal - this.Descuento;
        }

    }
}
