using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio
{
    public class fachadaactualizar
   {
        private static persistenciaextraccion2 pers2= new persistenciaextraccion2OledB();
       public static void actualizardatos(float resultadoazucar, float resultadocolesterol, float resultadotsh, int cod) { 

        extraccion ex = new extraccion();
        ex.Resultadoazucar = resultadoazucar;
        ex.Resultadocolesterol = resultadocolesterol;
        ex.Resultadotsh = resultadotsh;
        ex.Cod = cod;
        pers2.actualizardatos(ex);
        
        }



    }
}


   