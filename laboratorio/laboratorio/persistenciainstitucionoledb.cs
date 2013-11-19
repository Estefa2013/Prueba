using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data;

namespace Laboratorio
{
    public class persistenciainstitucionoledb:persistenciainstitucion
    {
        private static OleDbConnection crearConexion()
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;data Source= D:\\laboratorio.accdb");
            conexion.Open();


            return conexion;
        }

        public override void registrarinstitucion(institucion i)
        {
            OleDbConnection conexion = crearConexion();

            OleDbCommand cmd = new OleDbCommand("insert into instituciones(Nombre, Mail, Telefono, Direccion) values(@nom,@mail,@tel,@dir)", conexion);
            
            cmd.Parameters.AddWithValue("@nom", i.Nombre);
            cmd.Parameters.AddWithValue("@mail", i.Mail);
            cmd.Parameters.AddWithValue("@tel", i.Telefono);
            cmd.Parameters.AddWithValue("@dir", i.Direccion);
         
            OleDbDataReader datos = cmd.ExecuteReader();

            conexion.Close();

        }

        public override List<institucion> listarInstitucion()
        {
            List<institucion> lista = new List<institucion>();

            OleDbConnection conexion = crearConexion();

            OleDbCommand cmd = new OleDbCommand("SELECT * FROM Instituciones", conexion);
            OleDbDataReader datos = cmd.ExecuteReader();

            while (datos.Read())
            {
                institucion i = new institucion();
                i.Nombre = datos["nombre"].ToString();
                i.Direccion = datos["direccion"].ToString();
                i.Mail = datos["mail"].ToString();
                i.Telefono = datos["telefono"].ToString();
                lista.Add(i);
            }

            conexion.Close();

            return lista;
        }
    }
}