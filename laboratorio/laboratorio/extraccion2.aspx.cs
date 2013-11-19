using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
namespace Laboratorio
{
    public partial class extraccion2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;data Source= D:\\laboratorio.accdb");
            conexion.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT Cod FROM extracciones where Entrega=no", conexion);
            OleDbDataReader datos = cmd.ExecuteReader();
            while (datos.Read())
            {

                DropDownList1.Items.Add(datos[0].ToString());
            }
            conexion.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            fachadalistar.listarextraccionespendientes();
            GridView1.DataSource = fachadalistar.listarextraccionespendientes();
            GridView1.DataBind();
           
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
           
        }

        protected void btningresar_Click(object sender, EventArgs e)
        {
            fachadaactualizar.actualizardatos(float.Parse(txtazucar.Text), float.Parse(txtcolesterol.Text), float.Parse(txttsh.Text), Convert.ToInt32(DropDownList1.SelectedValue));
        }

        protected void btnfiltrar_Click(object sender, EventArgs e)
        {
            fachadafiltrar.filtrarxcodigo(Convert.ToInt32(DropDownList1.SelectedValue));
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}