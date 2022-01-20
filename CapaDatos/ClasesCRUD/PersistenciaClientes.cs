using System;
using System.Collections.Generic;
using System.Linq;
using CapaDatos.Modelos;

namespace CapaDatos.ClasesCRUD
{
    public static class PersistenciaClientes
    {
        public static List<Cliente> ListaClientes { get; set; }

        //CRUD
        //CREATE
        public static void GuardarCliente(Cliente cliente)
        {
            ListaClientes.Add(cliente);
        }

        //UPDATE
        public static void ModificarCliente(string cedula, string nombres, string apellidos)
        {
            Cliente cliente = ListaClientes.Find(x => x.Cedula == cedula);
            cliente.Nombres = nombres;
            cliente.Apellidos = apellidos;
        }

        //DELETE
        public static void EliminarCliente(string cedula)
        {
            ListaClientes.RemoveAll(cliente => cliente.Cedula == cedula);
        }

        //READ
        //UN OBJETO
        public static Cliente BuscarCliente(string cedula)
        {

            return ListaClientes.Find(cliente => cliente.Cedula == cedula);
        }

        //LISTADO DE OBJETOS FORMATEADOS SEGÚN REQUERIMIENTO
        public static string RetornarClientesEnString()
        {
            return ListaClientes.Aggregate("", (acumulador, cliente) => acumulador += $"{cliente.Cedula} \t {cliente.Nombres} \t {cliente.Apellidos} \n");
        }


    }
}
