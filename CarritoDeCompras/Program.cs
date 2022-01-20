using System;
using System.Linq;
using CapaNegocios;

namespace CarritoDeCompras
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            GestionCliente cliente = new GestionCliente();
            cliente.GuardarCliente("1112223334", "Michael Jackson", "Zambrano Zambrano", "michael@email.ec", "123");
            cliente.GuardarCliente("2223334445", "Juana Maria", "Pueblo Zambrano", "juan@mail.com", "123");
            Console.WriteLine(cliente.ListarUsuarios());
            Console.ReadKey();
             

            GestionProductos gestionamiento = new GestionProductos();
            Console.WriteLine(gestionamiento.ListarProductos());
            Console.ReadKey();
            //GRUPO 3
            //Utilizando expresiones lambda o linq cree los métodos en las capas respectivas que permitan mostrar por pantalla:
            //1) La cantidad total de todos los productos. (2 Puntos)
            Console.WriteLine("La cantidad total de todos los productos es:"+ gestionamiento.TotalProducto());
            Console.ReadKey();
            //2) La suma de todos los precios de los productos para conocer el valor del inventario. (1 Puntos)
            Console.WriteLine("La cantidad total de la suma de los productos es:" + gestionamiento.SumaProductos());
            Console.ReadKey();
            //3) Listado de productos menores a un valor proporcionado y ordenarlos alfabeticamente de A a Z. (2 Puntos)
            Console.WriteLine("Los productos con menor precio al proporcionado es:" + gestionamiento.ProductoConMenorPrecio());
            Console.ReadKey();
            //4) Los productos ordenados por categoria y por precio de mayor a menor. (2 Puntos)
            Console.WriteLine("El orden por categoria y precio:" + gestionamiento.ListaProductosMayorMenor());
            Console.ReadKey();
            //5) Los productos ordenados alfabeticamente de A a Z. (1 Puntos)
            Console.WriteLine("El orden alfabetico es:" + gestionamiento.OrdenAZ());
            Console.ReadKey();

        }

    }
}
