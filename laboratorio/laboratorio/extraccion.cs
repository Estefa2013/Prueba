using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio
{
    public class extraccion
    {


        int cod;

        public int Cod
        {
            get { return cod; }
            set { cod = value; }
        }
        
        
        string cedula;

        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        private string lugar;

        public string Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }

        private Boolean urgencia;

        public Boolean Urgencia
        {
            get { return urgencia; }
            set { urgencia = value; }
        }

        private Boolean azucar;

        public Boolean Azucar
        {
            get { return azucar; }
            set { azucar = value; }
        }
        private Boolean colesterol;

        public Boolean Colesterol
        {
            get { return colesterol; }
            set { colesterol = value; }
        }
        private Boolean tsh;

        public Boolean Tsh
        {
            get { return tsh; }
            set { tsh = value; }
        }

        private float resultadoazucar;

        public float Resultadoazucar
        {
            get { return resultadoazucar; }
            set { resultadoazucar = value; }
        }

        private float resultadocolesterol;

        public float Resultadocolesterol
        {
            get { return resultadocolesterol; }
            set { resultadocolesterol = value; }
        }

    

    
        private float resultadotsh;

        public float Resultadotsh
        {
            get { return resultadotsh; }
            set { resultadotsh = value; }
        }

        private Boolean entrega;

        public Boolean Entrega
        {
            get { return entrega; }
            set { entrega = value; }
        }

        private int costo;

        public int Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        private string encargado;

        public string Encargado
        {
            get { return encargado; }
            set { encargado = value; }
        }
        private string institucion;

        public string Institucion
        {
            get { return institucion; }
            set { institucion = value; }
        }
    }

}