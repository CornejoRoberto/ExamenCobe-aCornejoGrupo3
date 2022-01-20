using System;
namespace CapaDatos.Modelos
{
    public class CabeceraFactura
    {
        public CabeceraFactura()
        {
        }

        //Crear la clase cliente
        //public class MyProperty { get; set; }

        public Cliente ClienteCabecera { get; set; }
        public Empresa EmpresaCabecera { get; set; }


    }
}
