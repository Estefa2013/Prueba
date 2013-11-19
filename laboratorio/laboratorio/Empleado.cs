using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio
{
    public class Empleado
        {
            private string cedula;

            public string Cedula
            {
                get { return cedula; }
                set { cedula = value; }
            }
            private string nombre;

            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }

            private string direccion;

            public string Direccion
            {
                get { return direccion; }
                set { direccion = value; }
            }
            private string telefono;

            public string Telefono
            {
                get { return telefono; }
                set { telefono = value; }
            }
            private string cargo;

            public string Cargo
            {
                get { return cargo; }
                set { cargo = value; }
            }
        }
    
}