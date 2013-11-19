using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio
{
    public class material
    {
        private string nombrematerial;

        public string Nombrematerial
        {
            get { return nombrematerial; }
            set { nombrematerial = value; }
        }
        private int precioxunidad;

        public int Precioxunidad
        {
            get { return precioxunidad; }
            set { precioxunidad = value; }
        }
    }
}