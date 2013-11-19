using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio
{
    public abstract class persistenciaextraccion2
    {
        public abstract List<extraccion> listarextraccionespendientes();
        public abstract void filtrarxcodigo(extraccion ex);
        public abstract void actualizardatos(extraccion e);
    }
}