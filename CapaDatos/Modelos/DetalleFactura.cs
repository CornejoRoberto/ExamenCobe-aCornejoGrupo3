using System;
namespace CapaDatos.Modelos
{
    public class DetalleFactura
    {
        public DetalleFactura()
        {
        }

        public Producto ProductoCarrito { get; set; }

        public int Cantidad { get; set; }
    }
}
