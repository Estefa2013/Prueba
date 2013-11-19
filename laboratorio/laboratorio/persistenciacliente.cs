using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio
{
    public abstract class persistenciacliente

    {

        //public abstract void registrarcliente(string cedula, string nombre, string direccion, string telefono, string email);
        public abstract void registrarcliente(clientes cli);
    
    }
}