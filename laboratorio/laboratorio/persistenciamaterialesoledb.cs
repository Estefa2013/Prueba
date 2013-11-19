using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data;
namespace Laboratorio
{
    public class persistenciamaterialesoledb:persistenciamateriales
    {
        public override void registrarmateriales(material mat)
        {


            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;data Source= D:\\laboratorio.accdb");
            conexion.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO MATERIALES(Nombre, Precioxunidad) VALUES(@nom,@prec)", conexion);
            cmd.Parameters.AddWithValue("@nom", mat.Nombrematerial);

            cmd.Parameters.AddWithValue("@prec", mat.Precioxunidad);
            
           
            OleDbDataReader datos = cmd.ExecuteReader();

            conexion.Close();

        }

    }
}