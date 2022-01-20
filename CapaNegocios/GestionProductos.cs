using System;
using System.Linq;
using System.Collections.Generic;
using CapaDatos.ClasesCRUD;
using CapaDatos.Modelos;

namespace CapaNegocios
{
    public class GestionProductos
    {

        //RETORNA Los productos ordenados por categoria y por precio de mayor a menor..
        public string ListaProductosMayorMenor()
        {
            return PersistenciaProductos.ProductosMayorMenor();
        }

        //RETORNA La cantidad total de todos los productos.
        public string TotalProducto()
        {
            return PersistenciaProductos.TotalProductos();
        }
        //RETORNA La suma de todos los precios de los productos para conocer el valor del inventario.
        public string SumaProductos()
        {
            return PersistenciaProductos.SumaProductos();
        }
        //RETORNA LOS PRODUCTOS ORDENADOS ALFABETICAMENTE DE LA A HASTA LA Z.
        public string OrdenAZ()
        {
            return PersistenciaProductos.OrdenAZ();
        }
        //RETORNA Listado de productos menores a un valor proporcionado y ordenarlos alfabeticamente de A a Z.
        public string ProductoConMenorPrecio()
        {
            return PersistenciaProductos.ListadoMayor();
        }

        public GestionProductos()
        {
            PersistenciaProductos.ListaProductos = new List<Producto>();
            PersistenciaProductos.CrearProductos();
        }
        public void GuardarProducto(int identificador, string descripcion, decimal precio, int existencia, string categoria)
        {
            PersistenciaProductos.GuardarProducto(new Producto(identificador, descripcion, precio, existencia, categoria));
        }
        public string ListarProductos()
        {
            return "IDENTIFICADOR\t\t\tDESCRIPCION\t\t\tCATEGORIA\n" + PersistenciaProductos.RetornarProductosEnString();
        }

       

    }
}
