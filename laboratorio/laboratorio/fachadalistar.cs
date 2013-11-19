using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio
{
    public class fachadalistar
    {

        private static persistenciaextraccion2 pers2 = new persistenciaextraccion2OledB();
        public static List<extraccion> listarextraccionespendientes() {

            return pers2.listarextraccionespendientes();
        }
    }
}