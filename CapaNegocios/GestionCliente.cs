using System;
using System.Collections.Generic;
using CapaDatos;
using CapaDatos.ClasesCRUD;
using CapaDatos.Modelos;

namespace CapaNegocios
{
    public class GestionCliente
    {
        public GestionCliente()
        {
            PersistenciaClientes.ListaClientes = new List<Cliente>();
        }

        public void GuardarCliente(string cedula, string nombres, string apellidos, string usuario, string contrasenia)
        {
           PersistenciaClientes.GuardarCliente(new Cliente(cedula, nombres, apellidos, usuario, contrasenia));
        }

        public string ListarUsuarios()
        {
            return "CEDULA\t\t\tNOMBRES\t\t\tAPELLIDOS\n" + PersistenciaClientes.RetornarClientesEnString();
        }
    }
}
