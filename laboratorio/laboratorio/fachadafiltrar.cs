using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio
{
    public class fachadafiltrar
    {


        private static persistenciaextraccion2 pers = new persistenciaextraccion2OledB();
        public static void filtrarxcodigo(int cod) { 
        
            extraccion ex = new extraccion();
        
            ex.Cod = cod;
        
            pers.filtrarxcodigo(ex);
        
        }
       

     
        
        
       
    
       

    }
}