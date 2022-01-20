using System;
using System.Collections.Generic;
using CapaDatos.Modelos;
using System.Linq;

namespace CapaDatos.ClasesCRUD
{
    public class GestionProductos2
    {
        public GestionProductos2()
        {
            this.ListaStockProductos = new List<Producto>();
        }

       public List<Producto> ListaStockProductos { get; set; }

        public void CrearProductos()
        {
            Random random = new Random();
            int numero;
            for (int i = 1; i <= 10; i++)
            {
               
                Producto producto = new Producto();
                producto.Identificador = i;
                numero = random.Next(20);
                char letra = (char)(((int)'A') + random.Next(26));
                producto.Descripcion = "PRODUCTO" +letra + numero + i;                
                producto.Precio = numero;

                Random existencia = new Random();
                producto.Existencia = existencia.Next(100);
                this.ListaStockProductos.Add(producto);
           }
       }
        //Modificar este método
        //modificado.
       public void ImprimirStok()
       {
            var mostrarQuery = from productos in ListaStockProductos
                               select productos.Identificador + " -" + productos.Descripcion + "- " + productos.Precio + "- " + productos.Existencia;
            Console.WriteLine("\n" + mostrarQuery);
        }
        //Añadir método que permita la búsqueda de un producto del stock de productos y devuelva ese producto.
        public string BusquedaStock()
        {
            var buscar = ListaStockProductos.Find(produ => produ.Identificador == 1);
            var retornoP = $"El producto seleccionado es con el identificador #1, siendo {buscar.Descripcion}";
            return (string.Join("\n", retornoP));
        }
        //Añadir método que devuelva la cantidad de productos (stock total) que hay en el local por medio de ListaStockProductos.
        public string StockTotal()
        {
            var stock = ListaStockProductos.Count();
            return (string.Join("\n", stock));
        }
        //Añadir método que devuelva el producto cuyo precio sea el mas alto.
        public string PrecioMayor()
        {
            var precioMayor = ListaStockProductos.OrderByDescending(producto => producto.Precio).Select(producto => $"El Producto {producto.Descripcion} cuenta con el precio más alto de la tienda, siendo: ${producto.Precio}").First();
            return (string.Join("\n", precioMayor));
        }
    }
}

