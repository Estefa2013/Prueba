using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio
{
    public abstract class persistenciainstitucion

    {
        public abstract void registrarinstitucion(institucion i);

        public abstract List<institucion> listarInstitucion();
    }
}