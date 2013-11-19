using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data;
namespace Laboratorio
{
    public class persistenciaextraccion2OledB:persistenciaextraccion2
    {
        public override List<extraccion> listarextraccionespendientes()
        {
            List<extraccion> lista = new List<extraccion>();

            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;data Source= D:\\laboratorio.accdb");
            conexion.Open();
            OleDbCommand cmd = new OleDbCommand("select cod, cedula, lugar, urgencia, azucar, colesterol, tsh from extracciones where entrega=false", conexion);


            OleDbDataReader datos = cmd.ExecuteReader();

            while (datos.Read())
            {
                extraccion e = new extraccion();
                e.Cod = Convert.ToInt32(datos["Cod"]);
                e.Cedula = datos["Cedula"].ToString();
               e.Lugar = datos["Lugar"].ToString();
                e.Urgencia = Convert.ToBoolean(datos["Urgencia"]);
                e.Azucar = Convert.ToBoolean(datos["Azucar"]);
                e.Colesterol = Convert.ToBoolean(datos["Colesterol"]);
              e.Tsh = Convert.ToBoolean(datos["Tsh"]);
               // e.Costo = Convert.ToInt32(datos["Costo"]);

                lista.Add(e);
            }

            conexion.Close();

            return lista;


        }

        public override void filtrarxcodigo(extraccion ex) {

            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;data Source= D:\\laboratorio.accdb");
            conexion.Open();
            OleDbCommand cmd = new OleDbCommand("Select * from EXTRACCIONES Where Cod=@filtrocodigo", conexion);
            cmd.Parameters.AddWithValue("@filtrocodigo", Convert.ToInt32(ex.Cod));
   


            OleDbDataReader datos = cmd.ExecuteReader();

            conexion.Close();
        }

        public override void actualizardatos(extraccion e)
        {

            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;data Source= D:\\laboratorio.accdb");
            conexion.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE EXTRACCIONES SET Resultadoazucar=@rea, Resultadocolesterol=@rec,Resultadotsh=@ret Where Cod=@filtrocodigo", conexion);
        
            cmd.Parameters.AddWithValue("@rea", e.Resultadoazucar);
            cmd.Parameters.AddWithValue("@rec", e.Resultadocolesterol);
            cmd.Parameters.AddWithValue("@ret", e.Resultadotsh);
            cmd.Parameters.AddWithValue("@filtrocodigo", Convert.ToInt32(e.Cod));
            // cmd.Parameters.AddWithValue("@ent", e.Entrega);


            //OleDbDataReader datos = cmd.ExecuteReader();
            cmd.ExecuteNonQuery();

            conexion.Close();
        }
    }
}           
             
              

