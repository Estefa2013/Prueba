using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data;

namespace Laboratorio
{
    public class PersistenciaEmpleadoOleDb:PersistenciaEmpleado
    {
        private static OleDbConnection crearConexion()
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;data Source= D:\\laboratorio.accdb");
            conexion.Open();


            return conexion;
        }

        public override void registrarempleado(Empleado em)
        {
            OleDbConnection conexion = crearConexion();

            OleDbCommand cmd = new OleDbCommand("INSERT INTO Empleado VALUES(@ced,@nom,@dir,@tel,@cargo)", conexion);
            cmd.Parameters.AddWithValue("@ced", em.Cedula);
            cmd.Parameters.AddWithValue("@nom", em.Nombre);
            cmd.Parameters.AddWithValue("@dir", em.Direccion);
            cmd.Parameters.AddWithValue("@tel", em.Telefono);
            cmd.Parameters.AddWithValue("@cargo", em.Cargo);

            OleDbDataReader datos = cmd.ExecuteReader();

            conexion.Close();

        }
    }
}