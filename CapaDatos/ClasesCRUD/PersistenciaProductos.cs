using System;
using System.Collections.Generic;
using System.Linq;
using CapaDatos.Modelos;

namespace CapaDatos.ClasesCRUD
{
    public static class PersistenciaProductos
    {

        public static List<Producto> ListaProductos { get; set; }

        /// <summary>
        /// Método para crear productos aleatoreamente.
        /// </summary>
        public static void CrearProductos()
        {
            Random random = new Random();
            int numero;
            for (int i = 1; i <= 10; i++)
            {

                Producto producto = new Producto();
                producto.Identificador = i;
                numero = random.Next(20);
                char letra = (char)(((int)'A') + random.Next(26));
                producto.Descripcion = "PRODUCTO" + letra + numero + i;
                producto.Precio = numero;
                Random existencia = new Random();
                producto.Existencia = existencia.Next(100);
                ListaProductos.Add(producto);
            }
        }

        

        //CRUD
        //CREATE
        public static void GuardarProducto(Producto producto)
        {
            ListaProductos.Add(producto);
        }

        //UPDATE
        public static void ModificarProducto(int identificador, string descripcion, string categoria)
        {
            Producto producto = ListaProductos.Find(x => x.Identificador == identificador);
            producto.Descripcion = descripcion;
            producto.Categoria = categoria;
        }

        //DELETE
        public static void EliminarProducto(int identificador)
        {
            ListaProductos.RemoveAll(producto => producto.Identificador == identificador);
        }

        //READ
        //UN OBJETO
        public static Producto BuscarProducto(int identificador)
        {

            return ListaProductos.Find(producto => producto.Identificador == identificador);
        }

        //LISTADO DE OBJETOS FORMATEADOS SEGÚN REQUERIMIENTO
        public static string RetornarProductosEnString()
        {
            return ListaProductos.Aggregate("", (acumulador, producto) => acumulador += $"{producto.Identificador} \t {producto.Descripcion} \t {producto.Categoria} \n");
        }


        //Ordena los productos por precio, de mayormenor.
        public static string ProductosMayorMenor()
        {
            var ProductoPrecio = ListaProductos.OrderByDescending(precio1 => precio1.Precio).Select(x => $"El producto {x.Descripcion} ,con precio {x.Precio}");

            return (string.Join("\n", ProductoPrecio));
        }

        //Lista del producto con menor precio
        public static string ProductoConMenorPrecio()
        {
            var preciosMenor = ListaProductos.OrderBy(Mn => Mn.Precio).Select(producto => $"El Producto {producto.Descripcion} cuenta con el precio más bajo, siendo: ${producto.Precio}").First();
            return (string.Join("\n", preciosMenor));
        }

        //Listado de los productos menores al valor recibido
        public static string ListadoMayor()
        {
            //AQUI DECLARAMOS EL VALOR DETERMINADO PARA LA ELABORACIÓN
            int nuevoValor = 100;
            var lista = ListaProductos.Where(mayor => mayor.Precio < nuevoValor).OrderBy(mayor => mayor.Precio).Select(producto => $"Producto {producto.Descripcion} con precio de: ${producto.Precio}");
            return (string.Join("\n", lista));

        }
        //Devuelve productos ordenados de la A a la Z
        public static string OrdenAZ()
        {
            var OrdenAZ = ListaProductos.OrderByDescending(x=>x.Descripcion).Select(x=> new{x.Descripcion, x.Categoria });
            return (string.Join("\n", OrdenAZ));
        }
        //Devuelve el total de los productos:
        public static string TotalProductos()
        {
                var stock = ListaProductos.Count();
                return (string.Join("\n", stock));  
        }
        //Devuelve la suma de los precios de los productos:
        public static String SumaProductos()
        {
            var sumita = ListaProductos.Sum(x=> x.Precio);
            return (string.Join("\n", sumita));
        }
        
    }
}
