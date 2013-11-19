using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
namespace Laboratorio
{
    public partial class Extracciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.Ace.OLEDB.12.0;data Source= D:\\laboratorio.accdb");
            conexion.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT CEDULA FROM CLIENTES", conexion);
            OleDbDataReader datos = cmd.ExecuteReader();
            while (datos.Read())
            {

                DropDownList1.Items.Add(datos[0].ToString());
            }        
           
            OleDbCommand cmd1 = new OleDbCommand("SELECT Nombre FROM Instituciones", conexion);
            OleDbDataReader datos1 = cmd1.ExecuteReader();
            while (datos1.Read())
            {

                DropDownList3.Items.Add(datos1[0].ToString());
            }
            conexion.Close();
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            // persistenciaextraccion per = new persistenciaextraccionoledb();

            //per.registrarextraccion( txtcliente.Text,txttipo.Text, ddllugar.SelectedValue, Convert.ToInt32 (txtcosto.Text), Convert.ToInt32 (txtazucar.Text), Convert.ToInt32 (txtcolesterol.Text), txtentrega.Text);

            //fachadamuestra.registrarextraccion();
            fachadaregistrar.registrarextraccion(DropDownList1.SelectedValue, ddllugar.SelectedValue, checkUrgencia.Checked, checkAzucar.Checked, CheckColesterol.Checked, CheckTsh.Checked, CheckBox1.Checked, Convert.ToInt32(TextBox1.Text), DropDownList2.SelectedValue, DropDownList3.SelectedValue);

        }
    

        protected void Button1_Click(object sender, EventArgs e)
        {
          
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
               
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            

    
        }

        protected void ddllugar_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool institucion = false;
            if (ddllugar.SelectedValue == "institucion")
            {
                DropDownList3.Visible = true;
                institucion = true;
            }
            else
            {
                institucion = false;
                DropDownList3.Visible = false;
            }

        }
    }
}