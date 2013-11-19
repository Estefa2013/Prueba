using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
namespace Laboratorio
{
    public class persistenciaextraccionoledb:persistenciaextraccion
    {
        public override void registrarextraccion(extraccion ex)
        {


            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;data Source= D:\\laboratorio.accdb");
            conexion.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO EXTRACCIONES(Cedula, Lugar,Urgencia,Azucar,Colesterol,Tsh , Entrega, Costo, Encargado, Institucion) VALUES(@ced,@lug,@urg,@azu,@col,@tsh,@ent, @pre, @enc, @ins)", conexion);
            
            cmd.Parameters.AddWithValue("@ced", ex.Cedula);
            cmd.Parameters.AddWithValue("@lug", ex.Lugar);
            cmd.Parameters.AddWithValue("@urg", ex.Urgencia);
            cmd.Parameters.AddWithValue("@azu", ex.Azucar);
            cmd.Parameters.AddWithValue("@col", ex.Colesterol);
            cmd.Parameters.AddWithValue("@ths", ex.Tsh);         
            cmd.Parameters.AddWithValue("@ent", ex.Entrega);
            cmd.Parameters.AddWithValue("@pre", ex.Costo);
            cmd.Parameters.AddWithValue("@enc", ex.Encargado);
            cmd.Parameters.AddWithValue("@ins", ex.Institucion);

  
            OleDbDataReader datos = cmd.ExecuteReader();

            conexion.Close();

        }
       
 
    }
}