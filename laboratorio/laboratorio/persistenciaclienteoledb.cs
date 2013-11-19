using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
namespace Laboratorio
{
    public class persistenciaclienteoledb : persistenciacliente
    {

        public override void registrarcliente(clientes cli)
        {
          

            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;data Source= D:\\laboratorio.accdb");
            conexion.Open();
            OleDbCommand cmd = new OleDbCommand("insert into clientes values(@ced,@nom,@dir,@tel,@email)", conexion);
            cmd.Parameters.AddWithValue("@ced", cli.Cedula);
            cmd.Parameters.AddWithValue("@nom", cli.Nombre);
            cmd.Parameters.AddWithValue("@dir",cli.Direccion);
            cmd.Parameters.AddWithValue("@tel", cli.Telefono);
            cmd.Parameters.AddWithValue("@email", cli.Email);
            OleDbDataReader datos = cmd.ExecuteReader();

            conexion.Close();

}
    }
}